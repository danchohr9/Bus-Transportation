using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace BusTransportation
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        public Form1()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            register();
        }

        public bool validate()
        {
            if (nameTb.Text.Length < 3)
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Name is too short.";
                return false;
            }
            else if (usernameTb.Text.Length < 3)
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Username is too short.";
                return false;
            }
            else if (isValidEmail(emailTb.Text) == false)
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Incorrect email format.";
                return false;
            }
            else if (passTb.Text.Length < 8)
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Password must be 8 or more symbols.";
                return false;
            }
            else if (!passTb.Text.Equals(repeatPassTb.Text))
            {
                messageLbl.Visible = true;
                messageLbl.Text = "Passwords do not match.";
                return false;
            }else if(checkIfUserDoesntExist(usernameTb.Text) == false)
            {
                messageLbl.Visible = true;
                messageLbl.Text = "User already exists.";
                return false;
            }
            return true;
        }

        public bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public bool checkIfUserDoesntExist(string username)
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

        private void register()
        {
            if (validate()==true) {
                string query = $"INSERT INTO User (id, name, email, username, password, role_id) VALUES" +
                    "(NULL, @Name, @Email, @Username, @Password, @Role)";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTb.Text);
                    cmd.Parameters.AddWithValue("@Email", emailTb.Text);
                    cmd.Parameters.AddWithValue("@Username", usernameTb.Text);
                    cmd.Parameters.AddWithValue("@Password", passTb.Text);
                    cmd.Parameters.AddWithValue("@Role", 3);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoginForm lg = new LoginForm();
                    lg.Show();
                    this.Close();

                }
                catch(Exception e)
                {
                    MessageBox.Show("Query error:" + e.Message);
                }
            }
        }

    }
}
