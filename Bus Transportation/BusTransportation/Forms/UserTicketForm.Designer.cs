namespace BusTransportation.Forms
{
    partial class UserTicketForm
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
            this.transportIdTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBt = new System.Windows.Forms.Button();
            this.trasnportTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transportDV = new System.Windows.Forms.DataGridView();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.searchByCb = new System.Windows.Forms.ComboBox();
            this.showAllBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transportDV)).BeginInit();
            this.SuspendLayout();
            // 
            // transportIdTb
            // 
            this.transportIdTb.Enabled = false;
            this.transportIdTb.Location = new System.Drawing.Point(12, 343);
            this.transportIdTb.Margin = new System.Windows.Forms.Padding(2);
            this.transportIdTb.Name = "transportIdTb";
            this.transportIdTb.Size = new System.Drawing.Size(34, 20);
            this.transportIdTb.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Pick a seat:";
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(12, 367);
            this.addBt.Margin = new System.Windows.Forms.Padding(2);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(423, 33);
            this.addBt.TabIndex = 77;
            this.addBt.Text = "Book";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // trasnportTb
            // 
            this.trasnportTb.Enabled = false;
            this.trasnportTb.Location = new System.Drawing.Point(50, 343);
            this.trasnportTb.Margin = new System.Windows.Forms.Padding(2);
            this.trasnportTb.Name = "trasnportTb";
            this.trasnportTb.Size = new System.Drawing.Size(385, 20);
            this.trasnportTb.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Search by:";
            // 
            // transportDV
            // 
            this.transportDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportDV.Location = new System.Drawing.Point(12, 53);
            this.transportDV.Name = "transportDV";
            this.transportDV.RowHeadersWidth = 51;
            this.transportDV.Size = new System.Drawing.Size(423, 285);
            this.transportDV.TabIndex = 73;
            this.transportDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transportDV_RowHeaderMouseClick_1);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(100, 28);
            this.searchTb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(226, 20);
            this.searchTb.TabIndex = 80;
            // 
            // searchBt
            // 
            this.searchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBt.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.searchBt.Location = new System.Drawing.Point(330, 27);
            this.searchBt.Margin = new System.Windows.Forms.Padding(2);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(44, 21);
            this.searchBt.TabIndex = 81;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = false;
            this.searchBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchByCb
            // 
            this.searchByCb.FormattingEnabled = true;
            this.searchByCb.Location = new System.Drawing.Point(14, 27);
            this.searchByCb.Name = "searchByCb";
            this.searchByCb.Size = new System.Drawing.Size(81, 21);
            this.searchByCb.TabIndex = 82;
            // 
            // showAllBt
            // 
            this.showAllBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showAllBt.Font = new System.Drawing.Font("Modern No. 20", 8F);
            this.showAllBt.Location = new System.Drawing.Point(378, 27);
            this.showAllBt.Margin = new System.Windows.Forms.Padding(2);
            this.showAllBt.Name = "showAllBt";
            this.showAllBt.Size = new System.Drawing.Size(58, 21);
            this.showAllBt.TabIndex = 83;
            this.showAllBt.Text = "Show all";
            this.showAllBt.UseVisualStyleBackColor = false;
            this.showAllBt.Click += new System.EventHandler(this.showAllBt_Click);
            // 
            // UserTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 405);
            this.Controls.Add(this.showAllBt);
            this.Controls.Add(this.searchByCb);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.transportIdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.trasnportTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transportDV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserTicketForm";
            this.Text = "UserTicketForm";
            this.Load += new System.EventHandler(this.UserTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox transportIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.TextBox trasnportTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transportDV;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.ComboBox searchByCb;
        private System.Windows.Forms.Button showAllBt;
    }
}