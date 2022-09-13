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
    public partial class BusForm : Form
    {
        private MySqlConnection conn;
        public BusForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void BusForm_Load(object sender, EventArgs e)
        {
            busTypeCb.Items.Add("Small(1)");
            busTypeCb.Items.Add("Medium(2)");
            busTypeCb.Items.Add("Large(3)");
            busTypeCb.SelectedIndex = 0;
            DisplayBus();
        }

        private void DisplayBus()
        {
            string query = "SELECT * FROM Bus";
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                busesDV.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
            }
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            addBus();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            editBus();
        }

        public bool checkIfBusDoesntExists(string plate)
        {
            try
            {
                conn.Open();
                using (var sqlCommand = new MySqlCommand("SELECT * FROM Bus WHERE id = '" + plate + "'", conn))
                {
                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        reader.Dispose();
                        conn.Close();
                        return false;

                    }
                    else
                    {
                        reader.Close();
                        reader.Dispose();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
            }
            return false;
        }

        private void addBus()
        {
            int size = 1;
            if (busTypeCb.SelectedIndex == 1) size = 2;
            if (busTypeCb.SelectedIndex == 2) size = 3;
            string query = $"INSERT INTO Bus (id, brand, busType_id) VALUES" +
                "(@Plate, @Brand, @BusType)";
            if (plateTb.Text != null && brandTb.Text != null && plateTb.Text.Length > 0 && brandTb.Text.Length > 0)
            {
                if (checkIfBusDoesntExists(plateTb.Text) != false)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Plate", plateTb.Text);
                        cmd.Parameters.AddWithValue("@Brand", brandTb.Text);
                        cmd.Parameters.AddWithValue("@BusType", size);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Bus successfully added.");
                        DisplayBus();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Query error:" + e.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bus already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all tabs.");
            }
        }

        private void editBus()
        {
            if (idTb.TextLength > 0)
            {
                int size = 1;
                if (busTypeCb.SelectedIndex == 1) size = 2;
                if (busTypeCb.SelectedIndex == 2) size = 3;
                string query = $"Update Bus SET brand = @Brand, busType_id = @BusType WHERE ID = @Id";
                Console.Write(query);
                if (plateTb.Text != null && brandTb.Text != null && plateTb.Text.Length > 0 && brandTb.Text.Length > 0)
                {
                        try
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Brand", brandTb.Text);
                            cmd.Parameters.AddWithValue("@BusType", size);
                            cmd.Parameters.AddWithValue("@Id", idTb.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Bus successfully added.");
                            DisplayBus();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Query error:" + e.Message);
                        }
                }
                else
                {
                    MessageBox.Show("Please fill all tabs.");
                }
            }
        }

        private void usersDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTb.Text = busesDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            plateTb.Text = busesDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            brandTb.Text = busesDV.Rows[e.RowIndex].Cells[1].Value.ToString();

            string bus_type = busesDV.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (bus_type.Equals("1")) busTypeCb.SelectedIndex = 0;
            if (bus_type.Equals("2")) busTypeCb.SelectedIndex = 1;
            if (bus_type.Equals("3")) busTypeCb.SelectedIndex = 2;
        }
    }
}
