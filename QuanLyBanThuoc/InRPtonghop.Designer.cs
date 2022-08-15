namespace QuanLyBanThuoc
{
    partial class InRPtonghop
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
            this.Tungay = new System.Windows.Forms.DateTimePicker();
            this.Denngay = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tungay
            // 
            this.Tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tungay.Location = new System.Drawing.Point(80, 95);
            this.Tungay.Name = "Tungay";
            this.Tungay.Size = new System.Drawing.Size(155, 22);
            this.Tungay.TabIndex = 0;
            // 
            // Denngay
            // 
            this.Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Denngay.Location = new System.Drawing.Point(270, 95);
            this.Denngay.Name = "Denngay";
            this.Denngay.Size = new System.Drawing.Size(200, 22);
            this.Denngay.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "In Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InRPtonghop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Denngay);
            this.Controls.Add(this.Tungay);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "InRPtonghop";
            this.Text = "InRPtonghop";
            this.Load += new System.EventHandler(this.InRPtonghop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Tungay;
        private System.Windows.Forms.DateTimePicker Denngay;
        private System.Windows.Forms.Button button1;
    }
}