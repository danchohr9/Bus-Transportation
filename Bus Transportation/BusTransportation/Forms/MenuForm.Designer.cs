namespace BusTransportation
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.editTicketBt = new System.Windows.Forms.Button();
            this.logoutBt = new System.Windows.Forms.Button();
            this.transportationsBt = new System.Windows.Forms.Button();
            this.ticketsBt = new System.Windows.Forms.Button();
            this.busesBt = new System.Windows.Forms.Button();
            this.usersBt = new System.Windows.Forms.Button();
            this.dashboardBt = new System.Windows.Forms.Button();
            this.panelSide.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelSide.Controls.Add(this.editTicketBt);
            this.panelSide.Controls.Add(this.panelMenuTop);
            this.panelSide.Controls.Add(this.logoutBt);
            this.panelSide.Controls.Add(this.transportationsBt);
            this.panelSide.Controls.Add(this.ticketsBt);
            this.panelSide.Controls.Add(this.busesBt);
            this.panelSide.Controls.Add(this.usersBt);
            this.panelSide.Controls.Add(this.dashboardBt);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(267, 633);
            this.panelSide.TabIndex = 4;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(162)))));
            this.panelMenuTop.Controls.Add(this.label1);
            this.panelMenuTop.Controls.Add(this.welcomeLbl);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(267, 98);
            this.panelMenuTop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged as:";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(15, 54);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(47, 22);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "User";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(397, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 29);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Home";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(267, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(901, 98);
            this.panelTitleBar.TabIndex = 8;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(267, 98);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(901, 535);
            this.panelDesktop.TabIndex = 9;
            // 
            // editTicketBt
            // 
            this.editTicketBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTicketBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTicketBt.ForeColor = System.Drawing.Color.Black;
            this.editTicketBt.Image = ((System.Drawing.Image)(resources.GetObject("editTicketBt.Image")));
            this.editTicketBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editTicketBt.Location = new System.Drawing.Point(7, 336);
            this.editTicketBt.Margin = new System.Windows.Forms.Padding(4);
            this.editTicketBt.Name = "editTicketBt";
            this.editTicketBt.Size = new System.Drawing.Size(252, 49);
            this.editTicketBt.TabIndex = 7;
            this.editTicketBt.Text = "Edit Tickets";
            this.editTicketBt.UseVisualStyleBackColor = true;
            this.editTicketBt.Click += new System.EventHandler(this.editTicketBt_Click);
            // 
            // logoutBt
            // 
            this.logoutBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBt.ForeColor = System.Drawing.Color.Black;
            this.logoutBt.Image = ((System.Drawing.Image)(resources.GetObject("logoutBt.Image")));
            this.logoutBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBt.Location = new System.Drawing.Point(7, 450);
            this.logoutBt.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(252, 49);
            this.logoutBt.TabIndex = 5;
            this.logoutBt.Text = "Log Out";
            this.logoutBt.UseVisualStyleBackColor = true;
            this.logoutBt.Click += new System.EventHandler(this.logoutBt_Click);
            // 
            // transportationsBt
            // 
            this.transportationsBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transportationsBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportationsBt.ForeColor = System.Drawing.Color.Black;
            this.transportationsBt.Image = ((System.Drawing.Image)(resources.GetObject("transportationsBt.Image")));
            this.transportationsBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.transportationsBt.Location = new System.Drawing.Point(7, 393);
            this.transportationsBt.Margin = new System.Windows.Forms.Padding(4);
            this.transportationsBt.Name = "transportationsBt";
            this.transportationsBt.Size = new System.Drawing.Size(252, 49);
            this.transportationsBt.TabIndex = 4;
            this.transportationsBt.Text = "Transportations";
            this.transportationsBt.UseVisualStyleBackColor = true;
            this.transportationsBt.Click += new System.EventHandler(this.transportationsBt_Click);
            // 
            // ticketsBt
            // 
            this.ticketsBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsBt.ForeColor = System.Drawing.Color.Black;
            this.ticketsBt.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBt.Image")));
            this.ticketsBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ticketsBt.Location = new System.Drawing.Point(7, 279);
            this.ticketsBt.Margin = new System.Windows.Forms.Padding(4);
            this.ticketsBt.Name = "ticketsBt";
            this.ticketsBt.Size = new System.Drawing.Size(252, 49);
            this.ticketsBt.TabIndex = 3;
            this.ticketsBt.Text = "Tickets";
            this.ticketsBt.UseVisualStyleBackColor = true;
            this.ticketsBt.Click += new System.EventHandler(this.ticketsBt_Click);
            // 
            // busesBt
            // 
            this.busesBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busesBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busesBt.ForeColor = System.Drawing.Color.Black;
            this.busesBt.Image = ((System.Drawing.Image)(resources.GetObject("busesBt.Image")));
            this.busesBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.busesBt.Location = new System.Drawing.Point(7, 223);
            this.busesBt.Margin = new System.Windows.Forms.Padding(4);
            this.busesBt.Name = "busesBt";
            this.busesBt.Size = new System.Drawing.Size(252, 49);
            this.busesBt.TabIndex = 2;
            this.busesBt.Text = "Buses";
            this.busesBt.UseVisualStyleBackColor = true;
            this.busesBt.Click += new System.EventHandler(this.busesBt_Click);
            // 
            // usersBt
            // 
            this.usersBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBt.ForeColor = System.Drawing.Color.Black;
            this.usersBt.Image = ((System.Drawing.Image)(resources.GetObject("usersBt.Image")));
            this.usersBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.usersBt.Location = new System.Drawing.Point(7, 166);
            this.usersBt.Margin = new System.Windows.Forms.Padding(4);
            this.usersBt.Name = "usersBt";
            this.usersBt.Size = new System.Drawing.Size(252, 49);
            this.usersBt.TabIndex = 1;
            this.usersBt.Text = "Users";
            this.usersBt.UseVisualStyleBackColor = true;
            this.usersBt.Click += new System.EventHandler(this.usersBt_Click);
            // 
            // dashboardBt
            // 
            this.dashboardBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dashboardBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBt.ForeColor = System.Drawing.Color.Black;
            this.dashboardBt.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBt.Image")));
            this.dashboardBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboardBt.Location = new System.Drawing.Point(7, 110);
            this.dashboardBt.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardBt.Name = "dashboardBt";
            this.dashboardBt.Size = new System.Drawing.Size(252, 49);
            this.dashboardBt.TabIndex = 0;
            this.dashboardBt.Text = "Dashboard";
            this.dashboardBt.UseVisualStyleBackColor = false;
            this.dashboardBt.Click += new System.EventHandler(this.dashboardBt_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 633);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSide);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelSide.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button dashboardBt;
        private System.Windows.Forms.Button usersBt;
        private System.Windows.Forms.Button busesBt;
        private System.Windows.Forms.Button ticketsBt;
        private System.Windows.Forms.Button transportationsBt;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button editTicketBt;
    }
}