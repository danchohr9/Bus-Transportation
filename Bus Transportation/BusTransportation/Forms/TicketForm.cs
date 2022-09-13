using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTransportation
{
    public partial class TicketForm : Form
    {
        private MySqlConnection conn;
        public TicketForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            ticketCb.Items.Add("Reserved(1)");
            ticketCb.Items.Add("Purchased(2)");
            ticketCb.SelectedIndex = 0;
            loadUsers();
            loadTransports();
        }

        private void loadUsers()
        {
            string query = "SELECT id, username, name, email FROM User";
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                personDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void loadTransports()
        {
            DateTime today = DateTime.Today;
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

        private void transportDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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


        private void personDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string person;
            person = personDV.Rows[e.RowIndex].Cells[1].Value.ToString()
                + " | " + personDV.Rows[e.RowIndex].Cells[2].Value.ToString() + " | " + personDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            personTb.Text = person;
            personIdTb.Text = personDV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        public void generateSeats(int seats, int yEnd)
        {
            List<int> takenSeats = getTakenSeats(transportIdTb.Text);
            clearSeats();
            int plus = 0;
            int x = 340;
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
            if (personTb.Text.Length < 1)
            {
                MessageBox.Show("Choose a person");
                return false;
            }
            return true;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                string statusId = (ticketCb.SelectedIndex+1).ToString();
                string seat = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                string query = $"INSERT INTO Ticket (person_id, transport_id, seatNum, status_id) VALUES" +
                    "(@Person, @Transport, @Seat, @Status)";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Person", personIdTb.Text);
                    cmd.Parameters.AddWithValue("@Transport", transportIdTb.Text);
                    cmd.Parameters.AddWithValue("@Seat", seat);
                    cmd.Parameters.AddWithValue("@Status", statusId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    printTicket();
                    MessageBox.Show("Ticket successfully created.");
                    RadioButton rb = (RadioButton)Controls[seat];
                    rb.Enabled = false;
                    rb.Checked = false;

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Query error:" + exception.Message);
                    conn.Close();
                }
            }
        }

        private string getTransportPrice(String transportId)
        {
            string price = "";
            string query = "SELECT price FROM Transport where id = '" + transportId + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    price = reader["price"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return price;
        }

        private void printTicket()
        {
            string seat = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            //suzdavane na dialogovata kutiq za zapis
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filePath = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";//|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = "ticket#route" + transportIdTb.Text + "seat" + seat;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }


            string path = trasnportTb.Text, date = trasnportTb.Text;

            path = path.Substring(0, path.IndexOf("|"));
            date = date.Substring(date.IndexOf("|")+1);

            string[] ticket = {"Билет на: "+personTb.Text, "Разписание: " + path, "Отпътуване - Пристигане:" + date,
                                "Цена: "+getTransportPrice(transportIdTb.Text).ToString() + "лв.","Място: "+
                                seat, "Статус на билета: "+ticketCb.Text};

            if (filePath != "")
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (string s in ticket)
                    {
                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }

        }

        private void ticketCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketCb.SelectedIndex == 0) addBt.Text = "Book";
            if (ticketCb.SelectedIndex == 1) addBt.Text = "Buy";
        }
    }
}
