using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTransportation.Forms
{
    public partial class UserTicketForm : Form
    {
        private MySqlConnection conn;
        private string username;
        public UserTicketForm(string username)
        {
            this.username = username;
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void UserTicketForm_Load(object sender, EventArgs e)
        {
            searchByCb.Items.Add("Beginning");
            searchByCb.Items.Add("Destination");
            searchByCb.SelectedIndex = 0;
            loadTransports();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                string seat = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                string userId = getUserId();
                string query = $"INSERT INTO Ticket (person_id, transport_id, seatNum, status_id) VALUES" +
                    "(@Person, @Transport, @Seat, @Status)";

                HashSet<string> transports = getUsedTransports();
                if (transports.Contains(transportIdTb.Text))
                {
                    MessageBox.Show("You have already booked a ticket for this transport.");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Person", userId);
                        cmd.Parameters.AddWithValue("@Transport", transportIdTb.Text);
                        cmd.Parameters.AddWithValue("@Seat", seat);
                        cmd.Parameters.AddWithValue("@Status", "1");
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //printTicket();
                        MessageBox.Show("Ticket successfully reserved.");
                        RadioButton rb = (RadioButton)Controls[seat];
                        rb.Enabled = false;
                        rb.Checked = false;
                        loadTransports();

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Query error:" + exception.Message);
                        conn.Close();
                    }
                }
            }
        }

        private HashSet<string> getUsedTransports()
        {
            HashSet<string> transports = new HashSet<string>();

            string query = "SELECT transport_id FROM Ticket where person_id = " + getUserId();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transports.Add(reader["transport_id"].ToString());
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }

            return transports;
        }


        private void loadTransports()
        {
            string query = "SELECT t.id, c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart, t.timeArrive, price, bus_id FROM Transport t" +
                " join City c on t.beginning = c.id join City cc on t.destination = cc.id where t.timeDepart >= CURRENT_TIMESTAMP";


                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    transportDV.DataSource = dt;
                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error:" + e.Message);
                    conn.Close();
                }
            
        }

        public int searchBus(string busId)
        {
            int i = 0;
            string query = "SELECT busType_id FROM Bus where id = '" + busId + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i = (int)reader["busType_id"];
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return i;
        }

        public void generateSeats(int seats, int yEnd)
        {
            List<int> takenSeats = getTakenSeats(transportIdTb.Text);
            clearSeats();
            int plus = 0;
            int x = 400;
            int y = 50;
            int seat = 1;
            for (int j = 40; j <= yEnd; j += 40)
            {
                if (j == 120) j += 40;
                for (int i = 1; i <= seats; i++)
                {
                    RadioButton rdo = new RadioButton();
                    rdo.Name = seat.ToString();
                    rdo.Text = seat.ToString();
                    rdo.ForeColor = Color.Black;
                    rdo.Location = new Point(x + j, y + plus);
                    rdo.AutoSize = true;
                    if (takenSeats.Contains(seat)) rdo.Enabled = false;
                    this.Controls.Add(rdo);
                    plus = plus + 20;
                    seat++;
                }
                plus = 0;
            }
        }

        public List<int> getTakenSeats(string transportId)
        {
            List<int> seats = new List<int>();

            string query = "SELECT seatNum FROM Ticket where transport_id = '" + transportId + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seats.Add((int)reader["seatNum"]);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }

            return seats;
        }

        public void clearSeats()
        {
            foreach (Control item in this.Controls.OfType<RadioButton>().ToList())
            {
                this.Controls.Remove(item);
            }
        }

        public bool checkInfo()
        {
            if (trasnportTb.Text.Length < 1)
            {
                MessageBox.Show("Choose a transport");
                return false;
            }
            if (this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) == null)
            {
                MessageBox.Show("Choose a seat");
                return false;
            }
            return true;
        }

        private string getUserId()
        {
            string i = "0";
            string query = "SELECT id FROM User where username = '" + username + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i = reader["id"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return i;
        }

        private void transportDV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            string transport;
            transport = transportDV.Rows[e.RowIndex].Cells[1].Value.ToString()
                + " - " + transportDV.Rows[e.RowIndex].Cells[2].Value.ToString() + " | " + transportDV.Rows[e.RowIndex].Cells[3].Value.ToString()
                + " - " + transportDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            trasnportTb.Text = transport;
            int type = searchBus(transportDV.Rows[e.RowIndex].Cells[6].Value.ToString());
            transportIdTb.Text = transportDV.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (type == 1) generateSeats(8, 120);
            if (type == 2) generateSeats(10, 200);
            if (type == 3) generateSeats(14, 200);
        }

        private void searchTransport()
        {
            string query="";
            if (searchByCb.SelectedIndex == 0)
            {
                query = "SELECT t.id, c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart, t.timeArrive, price, bus_id FROM Transport t" +
                        " join City c on t.beginning = c.id join City cc on t.destination = cc.id where c.name = '"+searchTb.Text+ "' and t.timeDepart >= CURRENT_TIMESTAMP";
            }
            else
            {
                query = "SELECT t.id, c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart, t.timeArrive, price, bus_id FROM Transport t"+
                        " join City c on t.beginning = c.id join City cc on t.destination = cc.id where cc.name = '" + searchTb.Text + "' and t.timeDepart >= CURRENT_TIMESTAMP";
            }

            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                transportDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTransport();
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            loadTransports();
        }
    }
}
