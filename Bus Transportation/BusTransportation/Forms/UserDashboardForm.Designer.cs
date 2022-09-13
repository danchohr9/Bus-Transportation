namespace BusTransportation.Forms
{
    partial class UserDashboardForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showAllBt = new System.Windows.Forms.Button();
            this.showActiveBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(65, 133);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(761, 356);
            this.listBox1.TabIndex = 0;
            // 
            // showAllBt
            // 
            this.showAllBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showAllBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBt.Location = new System.Drawing.Point(663, 87);
            this.showAllBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllBt.Name = "showAllBt";
            this.showAllBt.Size = new System.Drawing.Size(165, 41);
            this.showAllBt.TabIndex = 48;
            this.showAllBt.Text = "Show All";
            this.showAllBt.UseVisualStyleBackColor = false;
            this.showAllBt.Click += new System.EventHandler(this.showAllBt_Click);
            // 
            // showActiveBt
            // 
            this.showActiveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showActiveBt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showActiveBt.Location = new System.Drawing.Point(492, 87);
            this.showActiveBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showActiveBt.Name = "showActiveBt";
            this.showActiveBt.Size = new System.Drawing.Size(165, 41);
            this.showActiveBt.TabIndex = 49;
            this.showActiveBt.Text = "Show active";
            this.showActiveBt.UseVisualStyleBackColor = false;
            this.showActiveBt.Click += new System.EventHandler(this.showActiveBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 35);
            this.label2.TabIndex = 47;
            this.label2.Text = "Your tickets:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.showActiveBt);
            this.Controls.Add(this.showAllBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDashboardForm";
            this.Text = "UserDashboardForm";
            this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showAllBt;
        private System.Windows.Forms.Button showActiveBt;
        private System.Windows.Forms.Label label2;
    }
}