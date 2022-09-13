using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTransportation.Forms;
using MySql.Data.MySqlClient;

namespace BusTransportation
{
    public partial class LoginForm : Form
    {
        private MySqlConnection conn;
        public static String user = "";
        public LoginForm()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=bus_transport";
            conn = new MySqlConnection(connection);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }


        private void login()
        {
            string query = $"Select * from User where username=@Username and password=@Password";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", usernameTb.Text);
                cmd.Parameters.AddWithValue("@Password", passTb.Text);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                cmd.ExecuteNonQuery();
                if(dt.Rows.Count > 0)
                {
                    user = usernameTb.Text;
                    string role = dt.Rows[0].ItemArray[5].ToString();
                    if (role == "1")
                    {
                        MenuForm menu = new MenuForm();
                        menu.Show();
                    }
                    if (role == "2")
                    {
                        EmployeeMenuForm menu = new EmployeeMenuForm();
                        menu.Show();
                    }
                    if (role == "3")
                    {
                        UserMenuForm menu = new UserMenuForm();
                        menu.Show();
                    }
                    this.Hide();
                }
                else
                {
                    messageLbl.Visible = true;
                    usernameTb.Text = "";
                    passTb.Text = "";
                }
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Query error:" + e.Message);
                conn.Close();
            }
        }

        /*private void runQuery()
        {
            string query = usernameTb.Text;

            if(query== "")
            {
                MessageBox.Show("Please insert some sql query.");
            }
            MySqlCommand command = new MySqlCommand(query, conn);
            command.CommandTimeout = 60;

            try
            {
                conn.Open();
                MySqlDataReader myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("Check console for results!");
                    while (myReader.Read())
                    {                           //id                        //username                      //password                      //name
                        Console.WriteLine(myReader.GetString(0)+" - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("Query executed successfully");
                }
            }catch(Exception e)
            {
                MessageBox.Show("Query error:"+e.Message);
            }

            //INSERT INTO User(`id`, `username`, `password`, `name`) VALUES (NULL, "user1", "password1", "Ivan")
        }*/

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }
    }
}
