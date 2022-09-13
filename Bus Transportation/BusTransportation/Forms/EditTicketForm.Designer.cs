namespace BusTransportation
{
    partial class EditTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usersDV = new System.Windows.Forms.DataGridView();
            this.personIdTb = new System.Windows.Forms.TextBox();
            this.transportIdTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transportCb = new System.Windows.Forms.ComboBox();
            this.personCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.showAllBt = new System.Windows.Forms.Button();
            this.showActiveBt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "Edit ticket:";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(615, 59);
            this.idTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(71, 22);
            this.idTb.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Selected ticket:";
            // 
            // usersDV
            // 
            this.usersDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDV.Location = new System.Drawing.Point(479, 84);
            this.usersDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usersDV.Name = "usersDV";
            this.usersDV.RowHeadersWidth = 51;
            this.usersDV.Size = new System.Drawing.Size(391, 402);
            this.usersDV.TabIndex = 58;
            this.usersDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersDV_RowHeaderMouseClick);
            // 
            // personIdTb
            // 
            this.personIdTb.Enabled = false;
            this.personIdTb.Location = new System.Drawing.Point(48, 140);
            this.personIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personIdTb.Name = "personIdTb";
            this.personIdTb.Size = new System.Drawing.Size(44, 22);
            this.personIdTb.TabIndex = 81;
            // 
            // transportIdTb
            // 
            this.transportIdTb.Enabled = false;
            this.transportIdTb.Location = new System.Drawing.Point(48, 84);
            this.transportIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transportIdTb.Name = "transportIdTb";
            this.transportIdTb.Size = new System.Drawing.Size(44, 22);
            this.transportIdTb.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Select person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Select transport:";
            // 
            // transportCb
            // 
            this.transportCb.FormattingEnabled = true;
            this.transportCb.Location = new System.Drawing.Point(99, 84);
            this.transportCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transportCb.Name = "transportCb";
            this.transportCb.Size = new System.Drawing.Size(343, 24);
            this.transportCb.TabIndex = 82;
            this.transportCb.SelectedIndexChanged += new System.EventHandler(this.transportCb_SelectedIndexChanged);
            // 
            // personCb
            // 
            this.personCb.FormattingEnabled = true;
            this.personCb.Location = new System.Drawing.Point(99, 140);
            this.personCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personCb.Name = "personCb";
            this.personCb.Size = new System.Drawing.Size(343, 24);
            this.personCb.TabIndex = 83;
            this.personCb.SelectedIndexChanged += new System.EventHandler(this.personCb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "Ticket type:";
            // 
            // ticketCb
            // 
            this.ticketCb.FormattingEnabled = true;
            this.ticketCb.Location = new System.Drawing.Point(48, 194);
            this.ticketCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketCb.Name = "ticketCb";
            this.ticketCb.Size = new System.Drawing.Size(141, 24);
            this.ticketCb.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Pick a seat:";
            // 
            // editBt
            // 
            this.editBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(48, 224);
            this.editBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(141, 34);
            this.editBt.TabIndex = 87;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(48, 263);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(141, 34);
            this.deleteBt.TabIndex = 88;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = false;
            this.deleteBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // showAllBt
            // 
            this.showAllBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showAllBt.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.showAllBt.Location = new System.Drawing.Point(795, 57);
            this.showAllBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllBt.Name = "showAllBt";
            this.showAllBt.Size = new System.Drawing.Size(75, 26);
            this.showAllBt.TabIndex = 89;
            this.showAllBt.Text = "Show all";
            this.showAllBt.UseVisualStyleBackColor = false;
            this.showAllBt.Click += new System.EventHandler(this.showAllBt_Click);
            // 
            // showActiveBt
            // 
            this.showActiveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showActiveBt.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.showActiveBt.Location = new System.Drawing.Point(692, 57);
            this.showActiveBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showActiveBt.Name = "showActiveBt";
            this.showActiveBt.Size = new System.Drawing.Size(97, 26);
            this.showActiveBt.TabIndex = 90;
            this.showActiveBt.Text = "Show active";
            this.showActiveBt.UseVisualStyleBackColor = false;
            this.showActiveBt.Click += new System.EventHandler(this.showActiveBt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.button3.Location = new System.Drawing.Point(367, 56);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 91;
            this.button3.Text = "Show all";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.button4.Location = new System.Drawing.Point(264, 56);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 25);
            this.button4.TabIndex = 92;
            this.button4.Text = "Show active";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showActiveBt);
            this.Controls.Add(this.showAllBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketCb);
            this.Controls.Add(this.personCb);
            this.Controls.Add(this.transportCb);
            this.Controls.Add(this.personIdTb);
            this.Controls.Add(this.transportIdTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usersDV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditTicket";
            this.Text = "EditTicket";
            this.Load += new System.EventHandler(this.EditTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView usersDV;
        private System.Windows.Forms.TextBox personIdTb;
        private System.Windows.Forms.TextBox transportIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox transportCb;
        private System.Windows.Forms.ComboBox personCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ticketCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button showAllBt;
        private System.Windows.Forms.Button showActiveBt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}