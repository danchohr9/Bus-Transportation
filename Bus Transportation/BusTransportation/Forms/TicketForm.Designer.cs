namespace BusTransportation
{
    partial class TicketForm
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
            this.transportDV = new System.Windows.Forms.DataGridView();
            this.trasnportTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personDV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketCb = new System.Windows.Forms.ComboBox();
            this.addBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.transportIdTb = new System.Windows.Forms.TextBox();
            this.personIdTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transportDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDV)).BeginInit();
            this.SuspendLayout();
            // 
            // transportDV
            // 
            this.transportDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportDV.Location = new System.Drawing.Point(41, 41);
            this.transportDV.Name = "transportDV";
            this.transportDV.RowHeadersWidth = 51;
            this.transportDV.Size = new System.Drawing.Size(304, 118);
            this.transportDV.TabIndex = 54;
            this.transportDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transportDV_RowHeaderMouseClick);
            // 
            // trasnportTb
            // 
            this.trasnportTb.Enabled = false;
            this.trasnportTb.Location = new System.Drawing.Point(79, 164);
            this.trasnportTb.Margin = new System.Windows.Forms.Padding(2);
            this.trasnportTb.Name = "trasnportTb";
            this.trasnportTb.Size = new System.Drawing.Size(266, 20);
            this.trasnportTb.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Select transport:";
            // 
            // personTb
            // 
            this.personTb.Enabled = false;
            this.personTb.Location = new System.Drawing.Point(79, 302);
            this.personTb.Margin = new System.Windows.Forms.Padding(2);
            this.personTb.Name = "personTb";
            this.personTb.Size = new System.Drawing.Size(266, 20);
            this.personTb.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Select person:";
            // 
            // personDV
            // 
            this.personDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDV.Location = new System.Drawing.Point(41, 207);
            this.personDV.Name = "personDV";
            this.personDV.RowHeadersWidth = 51;
            this.personDV.Size = new System.Drawing.Size(304, 90);
            this.personDV.TabIndex = 60;
            this.personDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.personDV_RowHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ticket type:";
            // 
            // ticketCb
            // 
            this.ticketCb.FormattingEnabled = true;
            this.ticketCb.Location = new System.Drawing.Point(41, 355);
            this.ticketCb.Name = "ticketCb";
            this.ticketCb.Size = new System.Drawing.Size(107, 21);
            this.ticketCb.TabIndex = 66;
            this.ticketCb.SelectedIndexChanged += new System.EventHandler(this.ticketCb_SelectedIndexChanged);
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(41, 381);
            this.addBt.Margin = new System.Windows.Forms.Padding(2);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(304, 33);
            this.addBt.TabIndex = 70;
            this.addBt.Text = "Book";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Pick a seat:";
            // 
            // transportIdTb
            // 
            this.transportIdTb.Enabled = false;
            this.transportIdTb.Location = new System.Drawing.Point(41, 164);
            this.transportIdTb.Margin = new System.Windows.Forms.Padding(2);
            this.transportIdTb.Name = "transportIdTb";
            this.transportIdTb.Size = new System.Drawing.Size(34, 20);
            this.transportIdTb.TabIndex = 72;
            // 
            // personIdTb
            // 
            this.personIdTb.Enabled = false;
            this.personIdTb.Location = new System.Drawing.Point(41, 302);
            this.personIdTb.Margin = new System.Windows.Forms.Padding(2);
            this.personIdTb.Name = "personIdTb";
            this.personIdTb.Size = new System.Drawing.Size(34, 20);
            this.personIdTb.TabIndex = 73;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.personIdTb);
            this.Controls.Add(this.transportIdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketCb);
            this.Controls.Add(this.personTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personDV);
            this.Controls.Add(this.trasnportTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transportDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transportDV;
        private System.Windows.Forms.TextBox trasnportTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView personDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ticketCb;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transportIdTb;
        private System.Windows.Forms.TextBox personIdTb;
    }
}