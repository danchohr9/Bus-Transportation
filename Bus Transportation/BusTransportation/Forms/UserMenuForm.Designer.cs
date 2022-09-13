namespace BusTransportation.Forms
{
    partial class UserMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenuForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.logoutBt = new System.Windows.Forms.Button();
            this.ticketsBt = new System.Windows.Forms.Button();
            this.dashboardBt = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenuTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(676, 434);
            this.panelDesktop.TabIndex = 12;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(162)))));
            this.panelMenuTop.Controls.Add(this.label1);
            this.panelMenuTop.Controls.Add(this.welcomeLbl);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(200, 80);
            this.panelMenuTop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged as:";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(11, 44);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(37, 18);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "User";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(298, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Home";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelSide.Controls.Add(this.panelMenuTop);
            this.panelSide.Controls.Add(this.logoutBt);
            this.panelSide.Controls.Add(this.ticketsBt);
            this.panelSide.Controls.Add(this.dashboardBt);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 514);
            this.panelSide.TabIndex = 10;
            // 
            // logoutBt
            // 
            this.logoutBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBt.ForeColor = System.Drawing.Color.Black;
            this.logoutBt.Image = ((System.Drawing.Image)(resources.GetObject("logoutBt.Image")));
            this.logoutBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBt.Location = new System.Drawing.Point(5, 182);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(189, 40);
            this.logoutBt.TabIndex = 5;
            this.logoutBt.Text = "Log Out";
            this.logoutBt.UseVisualStyleBackColor = true;
            this.logoutBt.Click += new System.EventHandler(this.logoutBt_Click);
            // 
            // ticketsBt
            // 
            this.ticketsBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsBt.ForeColor = System.Drawing.Color.Black;
            this.ticketsBt.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBt.Image")));
            this.ticketsBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ticketsBt.Location = new System.Drawing.Point(5, 136);
            this.ticketsBt.Name = "ticketsBt";
            this.ticketsBt.Size = new System.Drawing.Size(189, 40);
            this.ticketsBt.TabIndex = 3;
            this.ticketsBt.Text = "Tickets";
            this.ticketsBt.UseVisualStyleBackColor = true;
            this.ticketsBt.Click += new System.EventHandler(this.ticketsBt_Click);
            // 
            // dashboardBt
            // 
            this.dashboardBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dashboardBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBt.ForeColor = System.Drawing.Color.Black;
            this.dashboardBt.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBt.Image")));
            this.dashboardBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboardBt.Location = new System.Drawing.Point(5, 89);
            this.dashboardBt.Name = "dashboardBt";
            this.dashboardBt.Size = new System.Drawing.Size(189, 40);
            this.dashboardBt.TabIndex = 0;
            this.dashboardBt.Text = "Dashboard";
            this.dashboardBt.UseVisualStyleBackColor = false;
            this.dashboardBt.Click += new System.EventHandler(this.dashboardBt_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(676, 80);
            this.panelTitleBar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Home";
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 514);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelSide);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserMenuForm";
            this.Text = "UserMenuForm";
            this.Load += new System.EventHandler(this.UserMenuForm_Load);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.Button ticketsBt;
        private System.Windows.Forms.Button dashboardBt;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label2;
    }
}