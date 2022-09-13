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

namespace BusTransportation
{
    public partial class TransportForm : Form
    {
        private MySqlConnection conn;
        DateTime departDateTime;
        DateTime arrivalDateTime;
        HashSet<string> buses;
        HashSet<string> allBuses;
        public TransportForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            displayTransports();
            loadCities(destinationCb);
            loadCities(beginningCb);
            destinationCb.SelectedIndex = 0;
            beginningCb.SelectedIndex = 0;

            departDateTime = departureDate.Value.Date + departureTime.Value.TimeOfDay;
            arrivalDateTime = arrivalDate.Value.Date + arrivalTime.Value.TimeOfDay;
            allBuses = getAllBuses();
            loadBuses();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                int beginningCityId = beginningCb.SelectedIndex + 1;
                int destinationCityId = destinationCb.SelectedIndex + 1;
                string busId = busCb.SelectedItem.ToString();
                string query = $"INSERT INTO Transport (beginning, destination, timeDepart, timeArrive, price, bus_id) VALUES" +
                    "(@Beginning, @Destination, @TimeDepart, @TimeArrive, @Price, @BusId)";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Beginning", beginningCityId);
                    cmd.Parameters.AddWithValue("@Destination", destinationCityId);
                    cmd.Parameters.AddWithValue("@TimeDepart", departDateTime);
                    cmd.Parameters.AddWithValue("@TimeArrive", arrivalDateTime);
                    cmd.Parameters.AddWithValue("@Price", priceTb.Text);
                    cmd.Parameters.AddWithValue("@BusId", busId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Transport successfully added.");
                    displayTransports();
                    loadBuses();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Query error:" + exception.Message);
                    conn.Close();
                }
            }
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            if (idTb.TextLength > 0)
            {
                if (checkInfo() == true)
                {
                    int beginningCityId = beginningCb.SelectedIndex + 1;
                    int destinationCityId = destinationCb.SelectedIndex + 1;
                    string busId = busCb.SelectedItem.ToString();
                    string query = $"Update Transport SET beginning = @Beginning, destination = @Destination, timeDepart = @TimeDepart, timeArrive = @TimeArrive, price = @Price, bus_id = @BusId WHERE ID= @Id";
                    Console.Write(query);
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.CommandText = query;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Beginning", beginningCityId);
                        cmd.Parameters.AddWithValue("@Destination", destinationCityId);
                        cmd.Parameters.AddWithValue("@TimeDepart", departDateTime);
                        cmd.Parameters.AddWithValue("@TimeArrive", arrivalDateTime);
                        cmd.Parameters.AddWithValue("@Price", priceTb.Text);
                        cmd.Parameters.AddWithValue("@BusId", busId);
                        cmd.Parameters.AddWithValue("@Id", idTb.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Transport edited.");
                        displayTransports();
                        loadBuses();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Query error:" + exception.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a transport");
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            if (idTb.TextLength > 0)
            {
                deleteTickets();
                string query = "DELETE FROM Transport WHERE ID=" + idTb.Text;
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.CommandText = query;
                command.Connection = conn;
                command.ExecuteNonQuery();
                MessageBox.Show("Transport deleted.");
                conn.Close();
                displayTransports();
                loadBuses();
            }
            else
            {
                MessageBox.Show("Please select a transport");
            }
        }

        private void deleteTickets()
        {
            string query = "DELETE FROM Ticket WHERE transport_id=" + idTb.Text;
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

        private HashSet<string> getAllBuses()
        {
            HashSet<string> b = new HashSet<string>();

            string query = "SELECT b.id FROM Bus b";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    b.Add(reader["id"].ToString());
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }

            return b;
        }

        private void loadCities(ComboBox cb)
        {
            string query = "SELECT id,name FROM City";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader["name"].ToString());
                    cb.ValueMember = reader["id"].ToString();
                    cb.DisplayMember = reader["name"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void loadBuses()
        {
            busCb.Items.Clear();
            getUsedBuses();
            allBuses = getAllBuses();
            allBuses.ExceptWith(buses);
            foreach (string s in allBuses)
            {
                busCb.Items.Add(s);
            }
            busCb.SelectedIndex = 0;
        }

        private void displayTransports()
        {
            string query = "SELECT t.id, c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart, t.timeArrive, price, bus_id FROM Transport t join City c on t.beginning = c.id join City cc on t.destination = cc.id";
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                usersDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private bool checkInfo()
        {
            if (priceTb.Text.Length < 1)
            {
                MessageBox.Show("Invalid price");
                return false;
            }
            if(destinationCb.SelectedIndex == beginningCb.SelectedIndex)
            {
                MessageBox.Show("Can not travel to the same city");
                return false;
            }
            if(departDateTime.CompareTo(arrivalDateTime) >= 0)
            {
                MessageBox.Show("Departure can not be after arrival.");
                return false;
            }
            return true;
        }

        private void priceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void departureDate_ValueChanged(object sender, EventArgs e)
        {
            departDateTime = departureDate.Value.Date + departureTime.Value.TimeOfDay;
            loadBuses();
        }

        private void departureTime_ValueChanged(object sender, EventArgs e)
        {
            departDateTime = departureDate.Value.Date + departureTime.Value.TimeOfDay;
            loadBuses();
        }

        private void arrivalDate_ValueChanged(object sender, EventArgs e)
        {
            arrivalDateTime = arrivalDate.Value.Date + arrivalTime.Value.TimeOfDay;
            loadBuses();
        }

        private void arrivalTime_ValueChanged(object sender, EventArgs e)
        {
            arrivalDateTime = arrivalDate.Value.Date + arrivalTime.Value.TimeOfDay;
            loadBuses();
        }

        private void getUsedBuses()
        {
            buses = new HashSet<string>();
            string query = "SELECT bus_id FROM Transport where (timeDepart BETWEEN @departDate AND @arriveDate) or (timeArrive BETWEEN @departDate AND @arriveDate)";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@departDate", departDateTime);
                cmd.Parameters.AddWithValue("@arriveDate", arrivalDateTime);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    buses.Add(reader["bus_id"].ToString());
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void usersDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTb.Text = usersDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            beginningCb.SelectedItem = usersDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            destinationCb.SelectedItem = usersDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceTb.Text = usersDV.Rows[e.RowIndex].Cells[5].Value.ToString();
            busCb.SelectedItem = usersDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            //nameTb.Text = usersDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            //emailTb.Text = usersDV.Rows[e.RowIndex].Cells[4].Value.ToString();

            string role = usersDV.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    }
}
