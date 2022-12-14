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
    public partial class UserMenuForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = LoginForm.user;
            this.Text = "Welcome " + LoginForm.user;
            loadDashboard(new UserDashboardForm(welcomeLbl.Text), sender);
        }

        private void dashboardBt_Click(object sender, EventArgs e)
        {
            openChildForm(new UserDashboardForm(welcomeLbl.Text), sender);
        }

        private void ticketsBt_Click(object sender, EventArgs e)
        {
            openChildForm(new UserTicketForm(welcomeLbl.Text), sender);
        }

        private void logoutBt_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void loadDashboard(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void openChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    disableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(255, 255, 222);
                    currentButton.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void disableButton()
        {
            foreach (Control previousBtn in panelSide.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 255, 192);
                    previousBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
