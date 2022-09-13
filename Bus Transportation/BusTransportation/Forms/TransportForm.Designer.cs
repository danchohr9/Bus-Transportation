namespace BusTransportation
{
    partial class TransportForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.usersDV = new System.Windows.Forms.DataGridView();
            this.beginningCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationCb = new System.Windows.Forms.ComboBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.busCb = new System.Windows.Forms.ComboBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.DateTimePicker();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Beginning:";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(431, 69);
            this.idTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(54, 20);
            this.idTb.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Selected transport:";
            // 
            // deleteBt
            // 
            this.deleteBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(28, 365);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(253, 31);
            this.deleteBt.TabIndex = 55;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = false;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // editBt
            // 
            this.editBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(28, 331);
            this.editBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(253, 31);
            this.editBt.TabIndex = 54;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // usersDV
            // 
            this.usersDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDV.Location = new System.Drawing.Point(310, 89);
            this.usersDV.Name = "usersDV";
            this.usersDV.RowHeadersWidth = 51;
            this.usersDV.Size = new System.Drawing.Size(353, 307);
            this.usersDV.TabIndex = 53;
            this.usersDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersDV_RowHeaderMouseClick);
            // 
            // beginningCb
            // 
            this.beginningCb.FormattingEnabled = true;
            this.beginningCb.Location = new System.Drawing.Point(32, 110);
            this.beginningCb.Name = "beginningCb";
            this.beginningCb.Size = new System.Drawing.Size(107, 21);
            this.beginningCb.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Time departure:";
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(28, 294);
            this.addBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(253, 33);
            this.addBt.TabIndex = 47;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Transport registration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Destination:";
            // 
            // destinationCb
            // 
            this.destinationCb.FormattingEnabled = true;
            this.destinationCb.Location = new System.Drawing.Point(167, 110);
            this.destinationCb.Name = "destinationCb";
            this.destinationCb.Size = new System.Drawing.Size(107, 21);
            this.destinationCb.TabIndex = 59;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(32, 167);
            this.departureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(168, 20);
            this.departureDate.TabIndex = 61;
            this.departureDate.ValueChanged += new System.EventHandler(this.departureDate_ValueChanged);
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(32, 212);
            this.arrivalDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(168, 20);
            this.arrivalDate.TabIndex = 63;
            this.arrivalDate.ValueChanged += new System.EventHandler(this.arrivalDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Time arrival:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Select bus:";
            // 
            // busCb
            // 
            this.busCb.FormattingEnabled = true;
            this.busCb.Location = new System.Drawing.Point(32, 262);
            this.busCb.Name = "busCb";
            this.busCb.Size = new System.Drawing.Size(107, 21);
            this.busCb.TabIndex = 64;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(167, 262);
            this.priceTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(107, 20);
            this.priceTb.TabIndex = 66;
            this.priceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "Price:";
            // 
            // arrivalTime
            // 
            this.arrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTime.Location = new System.Drawing.Point(204, 212);
            this.arrivalTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(78, 20);
            this.arrivalTime.TabIndex = 69;
            this.arrivalTime.ValueChanged += new System.EventHandler(this.arrivalTime_ValueChanged);
            // 
            // departureTime
            // 
            this.departureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTime.Location = new System.Drawing.Point(204, 167);
            this.departureTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(78, 20);
            this.departureTime.TabIndex = 68;
            this.departureTime.ValueChanged += new System.EventHandler(this.departureTime_ValueChanged);
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busCb);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.usersDV);
            this.Controls.Add(this.beginningCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportForm";
            this.Text = "TransportForm";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.DataGridView usersDV;
        private System.Windows.Forms.ComboBox beginningCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinationCb;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox busCb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker arrivalTime;
        private System.Windows.Forms.DateTimePicker departureTime;
    }
}