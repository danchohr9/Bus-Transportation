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
    public partial class DashboardForm : Form
    {
        private MySqlConnection conn;
        public DashboardForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            displayList();
        }

        private void displayList()
        {
            listBox1.Items.Add("Total upcoming transports:"+getTodaysAmountOfTransports().ToString());
            listBox1.Items.Add("Total registered users:" + getUsersCount().ToString());
            listBox1.Items.Add("Total registered buses:" + getBusesCount().ToString());
            listBox1.Items.Add("Total tickets for upcoming transports:" + getTicketsForTheDayCount());
        }

        private int getTodaysAmountOfTransports()
        {
            int count = 0;
            string query = "SELECT id FROM Transport where timeDepart >= CURRENT_TIMESTAMP";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return count;
        }

        private int getUsersCount()
        {
            int count = 0;
            string query = "SELECT id FROM User";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return count;
        }

        private int getBusesCount()
        {
            int count = 0;
            string query = "SELECT id FROM Bus";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return count;
        }

        private int getTicketsForTheDayCount()
        {
            int count = 0;
            string query = "SELECT tt.id FROM Ticket tt join Transport t on tt.transport_id=t.id where t.timeDepart >= CURRENT_TIMESTAMP";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
            return count;
        }
    }
}
