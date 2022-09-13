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
    public partial class EditTicket : Form
    {
        private MySqlConnection conn;
        public EditTicket()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void EditTicket_Load(object sender, EventArgs e)
        {
            loadActiveTickets();
            loadUsers();
            personCb.SelectedIndex = 0;
            loadTransports();
            transportCb.SelectedIndex = 0;

            ticketCb.Items.Add("Reserved");
            ticketCb.Items.Add("Purchased");
            ticketCb.SelectedIndex = 0;
        }

        private void loadTickets()
        {
            string query = "SELECT t.id, u.username as \"User\", t.transport_id, t.seatNum, s.name as \"Status\" FROM Ticket t join User u on t.person_id = u.id join Ticketstatus s on t.status_id = s.id";
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                usersDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Query error:" + exception.Message);
                conn.Close();
            }
        }

        public string getIdByUsername(string username)
        {
            string query = "SELECT id FROM User where username='"+username+"'";
            string id="";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader["id"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return id;
        }

        private void usersDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTb.Text = usersDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string transportId, userId, status;
            int seat;
            transportId = usersDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            userId = getIdByUsername(usersDV.Rows[e.RowIndex].Cells[1].Value.ToString());
            seat = (int)usersDV.Rows[e.RowIndex].Cells[3].Value;
            status = usersDV.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (status == "reserved") ticketCb.SelectedIndex = 0;
            if (status == "purchased") ticketCb.SelectedIndex = 1;


            transportCb.SelectedIndex = transportCb.FindStringExact(getTransport(transportId));
            personCb.SelectedIndex = personCb.FindStringExact(getUser(userId));

            int type = searchBus(transportId);


            if (type == 1) generateSeats(8, 120, seat);
            if (type == 2) generateSeats(10, 200, seat);
            if (type == 3) generateSeats(14, 200, seat);
        }

        private void loadUsers()
        {
            string query = "SELECT id, username FROM User";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                     personCb.Items.Add(reader["id"]+": "+reader["username"]);
                }
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
            string query = "SELECT t.id as \"Id\", c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart as \"Departure\", t.timeArrive, price, bus_id FROM Transport t join City c on t.beginning = c.id join City cc on t.destination = cc.id";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transportCb.Items.Add(reader["Id"] + ": " + reader["Beginning"] + "->" + reader["Destination"] + "(" + reader["Departure"] + ")");
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        public string getUser(string id)
        {
            string query = "SELECT id, username FROM User where id="+id;
            string result = "";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader["id"] + ": " + reader["username"];
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return result;
        }

        public string getTransport(string id)
        {
            string query = "SELECT t.id as \"Id\", c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart as \"Departure\", t.timeArrive, price, bus_id FROM Transport t join City c on t.beginning = c.id join City cc on t.destination = cc.id where t.id="+id;
            string result = "";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader["Id"] + ": " + reader["Beginning"] + "->" + reader["Destination"] + "(" + reader["Departure"] + ")";
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return result;
        }

        public int searchBus(string transportId)
        {
            int i = 0;
            string query = "SELECT b.busType_id FROM Bus b join Transport t on b.id=t.bus_id where t.id=" + transportId;
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

        public bool checkInfo()
        {
            if(idTb.Text.Length < 1)
            {
                MessageBox.Show("Select a ticket");
                return false;
            }
            if (transportIdTb.Text.Length < 1)
            {
                MessageBox.Show("Choose a transport");
                return false;
            }
            if (this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) == null)
            {
                MessageBox.Show("Choose a seat");
                return false;
            }
            if (personIdTb.Text.Length < 1)
            {
                MessageBox.Show("Choose a person");
                return false;
            }
            return true;
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                string statusId = (ticketCb.SelectedIndex + 1).ToString();
                string seat = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                string query = $"Update Ticket SET person_id = @Person, transport_id = @Transport, seatNum = @Seat, status_id = @Status WHERE ID = @Id";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Person", personIdTb.Text);
                    cmd.Parameters.AddWithValue("@Transport", transportIdTb.Text);
                    cmd.Parameters.AddWithValue("@Seat", seat);
                    cmd.Parameters.AddWithValue("@Status", statusId);
                    cmd.Parameters.AddWithValue("@Id", idTb.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    printTicket();
                    MessageBox.Show("Ticket successfully edited.");
                    RadioButton rb = (RadioButton)Controls[seat];
                    rb.Enabled = false;
                    rb.Checked = false;
                    loadTickets();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Query error:" + exception.Message);
                    conn.Close();
                }
            }
        }

        public string getTransportPrice(String transportId)
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


            string path = transportCb.GetItemText(transportCb.SelectedItem), date = path;

            path = path.Substring(0, path.IndexOf("("));
            date = date.Substring(date.IndexOf("(") + 1);

            string[] ticket = {"Билет на "+personCb.GetItemText(personCb.SelectedItem), "Разписание: " + path, "Отпътуване - Пристигане " + date,
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

        private void personCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = personCb.GetItemText(personCb.SelectedItem);
            if (selected.Length > 0)
            {
                string stringBeforeChar = selected.Substring(0, selected.IndexOf(":"));
                personIdTb.Text = stringBeforeChar;
            }
        }

        private void transportCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = transportCb.GetItemText(transportCb.SelectedItem);
            if (selected.Length > 0)
            {
                string stringBeforeChar = selected.Substring(0, selected.IndexOf(":"));
                transportIdTb.Text = stringBeforeChar;

                int type = searchBus(transportIdTb.Text);


                if (type == 1) generateSeats(8, 120, 0);
                if (type == 2) generateSeats(10, 200, 0);
                if (type == 3) generateSeats(14, 200, 0);
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

        public void generateSeats(int seats, int yEnd, int s)
        {
            List<int> takenSeats = getTakenSeats(transportIdTb.Text);
            clearSeats();
            int plus = 0;
            int x = 110;
            int y = 155;
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
                    if (seat == s) rdo.Checked = true;
                    this.Controls.Add(rdo);
                    plus = plus + 20;
                    seat++;
                }
                plus = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTb.TextLength > 0)
            {
                string query = "DELETE FROM Ticket WHERE id='" + idTb.Text + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.CommandText = query;
                command.Connection = conn;
                command.ExecuteNonQuery();  //zaduljitelni, inache nqma da se izpulni zaqvkata
                MessageBox.Show("Ticket removed.");
                conn.Close();
                loadActiveTickets();
            }
            else
            {
                MessageBox.Show("Please select a ticket");
            }
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            loadTickets();
        }

        private void showActiveBt_Click(object sender, EventArgs e)
        {
            loadActiveTickets();
        }

        private void loadActiveTickets()
        {
            string query = "SELECT t.id, u.username as \"User\", t.transport_id, t.seatNum, s.name as \"Status\" FROM Ticket t"+
                " join User u on t.person_id = u.id join Ticketstatus s on t.status_id = s.id join Transport tr on t.transport_id=tr.id where tr.timeDepart >= CURRENT_TIMESTAMP";
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                usersDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Query error:" + exception.Message);
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transportCb.Items.Clear();
            loadTransports();
            transportCb.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transportCb.Items.Clear();
            loadActiveTransports();
            transportCb.SelectedIndex = 0;
        }

        private void loadActiveTransports()
        {
            string query = "SELECT t.id as \"Id\", c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart as \"Departure\", t.timeArrive, price, bus_id"+
                " FROM Transport t join City c on t.beginning = c.id join City cc on t.destination = cc.id where t.timeDepart >= CURRENT_TIMESTAMP";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transportCb.Items.Add(reader["Id"] + ": " + reader["Beginning"] + "->" + reader["Destination"] + "(" + reader["Departure"] + ")");
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }
    }
}
