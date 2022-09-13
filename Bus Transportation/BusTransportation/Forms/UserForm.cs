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
    public partial class UserForm : Form
    {
        private MySqlConnection conn;
        public UserForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            roleCb.Items.Add("User(3)");
            roleCb.Items.Add("Employee(2)");
            roleCb.Items.Add("Administrator(1)");
            roleCb.SelectedIndex = 0;
            DisplayUser();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            editUser();
        }

        private void DisplayUser()
        {
            string query = "SELECT * FROM User";
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
            }
        }

        private bool checkIfUserExists(string username)
        {
            try
            {
                conn.Open();
                using (var sqlCommand = new MySqlCommand("SELECT * FROM User WHERE username = '" + username + "'", conn))
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

        private void addUser()
        {
            int role=3;
            if (roleCb.SelectedIndex == 1) role = 2;
            if (roleCb.SelectedIndex == 2) role = 1;
            string query = $"INSERT INTO User (id, name, email, username, password, role_id) VALUES" +
                "(NULL, @Name, @Email, @Username, @Password, @Role)";
            if (nameTb.Text != null && emailTb.Text != null && usernameTb.Text != null && passTb != null && nameTb.Text.Length > 0
                && emailTb.Text.Length > 0 && usernameTb.Text.Length > 0 && passTb.Text.Length > 0)
            {
                if (checkIfUserExists(usernameTb.Text) != false)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", nameTb.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTb.Text);
                        cmd.Parameters.AddWithValue("@Username", usernameTb.Text);
                        cmd.Parameters.AddWithValue("@Password", passTb.Text);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("User successfully added.");
                        DisplayUser();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Query error:" + e.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all tabs.");
            }
        }

        private void editUser()
        {
            if (idTb.TextLength > 0) {
                int role = 3;
                if (roleCb.SelectedIndex == 1) role = 2;
                if (roleCb.SelectedIndex == 2) role = 1;
                string query = $"Update User SET name = @Name, username = @Username, email = @Email, password = @Password, role_id = @Role WHERE ID= @Id";
                Console.Write(query);
                try
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    conn.Open();
                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@Name", nameTb.Text);
                    command.Parameters.AddWithValue("@Email", emailTb.Text);
                    command.Parameters.AddWithValue("@Username", usernameTb.Text);
                    command.Parameters.AddWithValue("@Password", passTb.Text);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Id", idTb.Text);
                    command.ExecuteNonQuery();  //zaduljitelni, inache nqma da se izpulni zaqvkata
                    MessageBox.Show("User editted");
                    conn.Close();
                    DisplayUser();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error:" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an user");
            }
        }

        private void deleteUser()
        {
            if (idTb.TextLength > 0)
            {
                deleteTickets();
                string query = "DELETE FROM User WHERE ID=" + idTb.Text;
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.CommandText = query;
                command.Connection = conn;
                command.ExecuteNonQuery();  //zaduljitelni, inache nqma da se izpulni zaqvkata
                MessageBox.Show("User deleted.");
                conn.Close();
                DisplayUser();
            }
            else
            {
                MessageBox.Show("Please select an user");
            }
        }

        private void deleteTickets()
        {
            string query = "DELETE FROM Ticket WHERE person_id=" + idTb.Text;
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();
            command.CommandText = query;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void usersDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            idTb.Text = usersDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            usernameTb.Text = usersDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            passTb.Text = usersDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameTb.Text = usersDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailTb.Text = usersDV.Rows[e.RowIndex].Cells[4].Value.ToString();

            string role = usersDV.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (role.Equals("1")) roleCb.SelectedIndex = 2;
            if (role.Equals("2")) roleCb.SelectedIndex = 1;
            if (role.Equals("3")) roleCb.SelectedIndex = 0;
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            deleteUser();
        }
    }
}
