namespace BusTransportation
{
    partial class UserForm
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
            this.addBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.usersDV = new System.Windows.Forms.DataGridView();
            this.editBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User registration:";
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(23, 318);
            this.addBt.Margin = new System.Windows.Forms.Padding(2);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(253, 33);
            this.addBt.TabIndex = 7;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(23, 81);
            this.nameTb.Margin = new System.Windows.Forms.Padding(2);
            this.nameTb.MaxLength = 60;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(254, 36);
            this.nameTb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Username:";
            // 
            // passTb
            // 
            this.passTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTb.Location = new System.Drawing.Point(23, 251);
            this.passTb.Margin = new System.Windows.Forms.Padding(2);
            this.passTb.MaxLength = 50;
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(254, 36);
            this.passTb.TabIndex = 17;
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(23, 138);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTb.MaxLength = 60;
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(254, 36);
            this.usernameTb.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(23, 195);
            this.emailTb.Margin = new System.Windows.Forms.Padding(2);
            this.emailTb.MaxLength = 60;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(254, 36);
            this.emailTb.TabIndex = 14;
            // 
            // roleCb
            // 
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Location = new System.Drawing.Point(23, 292);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(253, 21);
            this.roleCb.TabIndex = 22;
            // 
            // usersDV
            // 
            this.usersDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDV.Location = new System.Drawing.Point(297, 81);
            this.usersDV.Name = "usersDV";
            this.usersDV.RowHeadersWidth = 51;
            this.usersDV.Size = new System.Drawing.Size(353, 339);
            this.usersDV.TabIndex = 23;
            this.usersDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersDV_RowHeaderMouseClick);
            // 
            // editBt
            // 
            this.editBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(23, 355);
            this.editBt.Margin = new System.Windows.Forms.Padding(2);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(253, 31);
            this.editBt.TabIndex = 24;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(23, 389);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(253, 31);
            this.deleteBt.TabIndex = 25;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = false;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Selected user:";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(391, 59);
            this.idTb.Margin = new System.Windows.Forms.Padding(2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(54, 20);
            this.idTb.TabIndex = 28;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.usersDV);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.DataGridView usersDV;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTb;
    }
}