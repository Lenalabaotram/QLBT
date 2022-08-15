namespace QuanLyBanThuoc
{
    partial class frmNHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNHH));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdNHH = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.bttPre = new System.Windows.Forms.Button();
            this.bttNext = new System.Windows.Forms.Button();
            this.bttLast = new System.Windows.Forms.Button();
            this.bttFix = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttFirst = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttRe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdNHH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(631, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(631, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm ";
            // 
            // grdNHH
            // 
            this.grdNHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.grdNHH.Enabled = false;
            this.grdNHH.Location = new System.Drawing.Point(26, 103);
            this.grdNHH.Name = "grdNHH";
            this.grdNHH.RowTemplate.Height = 24;
            this.grdNHH.Size = new System.Drawing.Size(577, 221);
            this.grdNHH.TabIndex = 4;
            this.grdNHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNHH_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 106;
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên Nhóm ";
            this.TenNhom.Name = "TenNhom";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhom.Location = new System.Drawing.Point(729, 246);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(180, 30);
            this.txtMaNhom.TabIndex = 5;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhom.Location = new System.Drawing.Point(729, 294);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(180, 30);
            this.txtTenNhom.TabIndex = 6;
            // 
            // bttPre
            // 
            this.bttPre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttPre.Image = global::QuanLyBanThuoc.Properties.Resources._1486348816_arrow_back_backwards_repeat_previous_blue_80479;
            this.bttPre.Location = new System.Drawing.Point(188, 369);
            this.bttPre.Name = "bttPre";
            this.bttPre.Size = new System.Drawing.Size(99, 37);
            this.bttPre.TabIndex = 1;
            this.bttPre.UseVisualStyleBackColor = false;
            this.bttPre.Click += new System.EventHandler(this.bttPre_Click);
            // 
            // bttNext
            // 
            this.bttNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttNext.Image = global::QuanLyBanThuoc.Properties.Resources._1486348813_music_forward_front_next_arrow_blue_80474;
            this.bttNext.Location = new System.Drawing.Point(339, 369);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(99, 37);
            this.bttNext.TabIndex = 2;
            this.bttNext.UseVisualStyleBackColor = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // bttLast
            // 
            this.bttLast.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttLast.Image = global::QuanLyBanThuoc.Properties.Resources._1486348818_forward_arrows_arrow_front_go_blue_80478;
            this.bttLast.Location = new System.Drawing.Point(490, 369);
            this.bttLast.Name = "bttLast";
            this.bttLast.Size = new System.Drawing.Size(99, 37);
            this.bttLast.TabIndex = 3;
            this.bttLast.UseVisualStyleBackColor = false;
            this.bttLast.Click += new System.EventHandler(this.bttLast_Click);
            // 
            // bttFix
            // 
            this.bttFix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttFix.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFix.Location = new System.Drawing.Point(188, 439);
            this.bttFix.Name = "bttFix";
            this.bttFix.Size = new System.Drawing.Size(99, 45);
            this.bttFix.TabIndex = 4;
            this.bttFix.Text = "Sửa";
            this.bttFix.UseVisualStyleBackColor = false;
            this.bttFix.Click += new System.EventHandler(this.button5_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttAdd.Location = new System.Drawing.Point(37, 439);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(99, 45);
            this.bttAdd.TabIndex = 5;
            this.bttAdd.Text = "Thêm";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttDel.Location = new System.Drawing.Point(339, 439);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(99, 45);
            this.bttDel.TabIndex = 6;
            this.bttDel.Text = "Xóa";
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSave.Enabled = false;
            this.bttSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttSave.Location = new System.Drawing.Point(490, 439);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(99, 45);
            this.bttSave.TabIndex = 7;
            this.bttSave.Text = "Cập nhật";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttExit.Location = new System.Drawing.Point(876, 439);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(99, 45);
            this.bttExit.TabIndex = 8;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(146, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "DANH MỤC NHÓM HÀNG HÓA";
            // 
            // bttFirst
            // 
            this.bttFirst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFirst.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttFirst.Image = global::QuanLyBanThuoc.Properties.Resources._1486348819_back_backwards_repeat_arrows_arrow_blue_80473;
            this.bttFirst.Location = new System.Drawing.Point(37, 369);
            this.bttFirst.Name = "bttFirst";
            this.bttFirst.Size = new System.Drawing.Size(99, 37);
            this.bttFirst.TabIndex = 0;
            this.bttFirst.UseVisualStyleBackColor = false;
            this.bttFirst.Click += new System.EventHandler(this.bttFirst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(723, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập thông tin cần tìm";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(699, 118);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(231, 27);
            this.txtFind.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(699, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lọc dữ liệu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttRe
            // 
            this.bttRe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttRe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bttRe.Location = new System.Drawing.Point(837, 161);
            this.bttRe.Name = "bttRe";
            this.bttRe.Size = new System.Drawing.Size(84, 37);
            this.bttRe.TabIndex = 12;
            this.bttRe.Text = "Làm Mới";
            this.bttRe.UseVisualStyleBackColor = false;
            this.bttRe.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(771, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "In Tổng hợp";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // frmNHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttRe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.grdNHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttDel);
            this.Controls.Add(this.bttFix);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttFirst);
            this.Controls.Add(this.bttNext);
            this.Controls.Add(this.bttPre);
            this.Controls.Add(this.bttLast);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm hàng hóa ";
            this.Load += new System.EventHandler(this.frmNHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdNHH;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttFix;
        private System.Windows.Forms.Button bttLast;
        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Button bttPre;
        private System.Windows.Forms.Button bttFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttRe;
        private System.Windows.Forms.Button button2;
    }
}