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
    public partial class UserDashboardForm : Form
    {
        private MySqlConnection conn;
        private string username;
        public UserDashboardForm(string username)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);
            this.username = username;
            InitializeComponent();
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            displayActiveTickets();
        }

        private void displayActiveTickets()
        {
            string query = "SELECT t.id as \"Id\", c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart as \"Departure\", ti.seatNum as \"Seat\", t.price as \"Price\"" +
                        " FROM Ticket ti join Transport t on ti.transport_id = t.id join City c on t.beginning = c.id join City cc on t.destination = cc.id" +
                        " where ti.person_id = " + getIdByUsername(username) + " and t.timeDepart >= CURRENT_TIMESTAMP";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Beginning"] + "->" + reader["Destination"] + "(" + reader["Departure"] + "), seat:" + reader["Seat"] + ", price:" + reader["Price"] + "лв.");
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void displayAllTickets()
        {
            string query = "SELECT t.id as \"Id\", c.name as \"Beginning\", cc.name as \"Destination\", t.timeDepart as \"Departure\", ti.seatNum as \"Seat\", t.price as \"Price\"" +
                " FROM Ticket ti join Transport t on ti.transport_id = t.id join City c on t.beginning = c.id join City cc on t.destination = cc.id" +
                " where ti.person_id = "+ getIdByUsername(username);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Beginning"] + "->" + reader["Destination"] + "(" + reader["Departure"] + "), seat:" + reader["Seat"] + ", price:" + reader["Price"] + "лв.");
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        private void showActiveBt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            displayActiveTickets();
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            displayAllTickets();
        }

        private string getIdByUsername(string username)
        {
            string query = "SELECT id FROM User where username='" + username + "'";
            string id = "";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
