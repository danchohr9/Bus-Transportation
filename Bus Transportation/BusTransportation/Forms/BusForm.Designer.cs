namespace BusTransportation
{
    partial class BusForm
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
            this.idTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editBt = new System.Windows.Forms.Button();
            this.busesDV = new System.Windows.Forms.DataGridView();
            this.busTypeCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.plateTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandTb = new System.Windows.Forms.TextBox();
            this.addBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.busesDV)).BeginInit();
            this.SuspendLayout();
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(387, 67);
            this.idTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(93, 20);
            this.idTb.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Selected car:";
            // 
            // editBt
            // 
            this.editBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(28, 331);
            this.editBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(253, 31);
            this.editBt.TabIndex = 41;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // busesDV
            // 
            this.busesDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesDV.Location = new System.Drawing.Point(303, 89);
            this.busesDV.Name = "busesDV";
            this.busesDV.RowHeadersWidth = 51;
            this.busesDV.Size = new System.Drawing.Size(353, 307);
            this.busesDV.TabIndex = 40;
            this.busesDV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersDV_RowHeaderMouseClick);
            // 
            // busTypeCb
            // 
            this.busTypeCb.FormattingEnabled = true;
            this.busTypeCb.Location = new System.Drawing.Point(28, 262);
            this.busTypeCb.Name = "busTypeCb";
            this.busTypeCb.Size = new System.Drawing.Size(253, 21);
            this.busTypeCb.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Number plate:";
            // 
            // plateTb
            // 
            this.plateTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateTb.Location = new System.Drawing.Point(29, 132);
            this.plateTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plateTb.MaxLength = 60;
            this.plateTb.Name = "plateTb";
            this.plateTb.Size = new System.Drawing.Size(254, 36);
            this.plateTb.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Brand:";
            // 
            // brandTb
            // 
            this.brandTb.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTb.Location = new System.Drawing.Point(29, 196);
            this.brandTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandTb.MaxLength = 60;
            this.brandTb.Name = "brandTb";
            this.brandTb.Size = new System.Drawing.Size(254, 36);
            this.brandTb.TabIndex = 33;
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(29, 294);
            this.addBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(253, 33);
            this.addBt.TabIndex = 30;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Bus registration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Select bus size:";
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.busesDV);
            this.Controls.Add(this.busTypeCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plateTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brandTb);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BusForm";
            this.Text = "BusForm";
            this.Load += new System.EventHandler(this.BusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busesDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.DataGridView busesDV;
        private System.Windows.Forms.ComboBox busTypeCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox plateTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandTb;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}