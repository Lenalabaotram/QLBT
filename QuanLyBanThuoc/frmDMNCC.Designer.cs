namespace QuanLyBanThuoc
{
    partial class frmDMNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMNCC));
            this.grdNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttFirst = new System.Windows.Forms.Button();
            this.bttPre = new System.Windows.Forms.Button();
            this.bttNext = new System.Windows.Forms.Button();
            this.bttLast = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttFix = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttRe = new System.Windows.Forms.Button();
            this.bttFind = new System.Windows.Forms.Button();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNCC
            // 
            this.grdNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.Sdt,
            this.Email});
            this.grdNCC.Location = new System.Drawing.Point(49, 97);
            this.grdNCC.Name = "grdNCC";
            this.grdNCC.RowTemplate.Height = 24;
            this.grdNCC.Size = new System.Drawing.Size(635, 399);
            this.grdNCC.TabIndex = 0;
            this.grdNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNCC_CellContentClick);
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 98;
            // 
            // TenNCC
            // 
            this.TenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // bttFirst
            // 
            this.bttFirst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFirst.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFirst.Location = new System.Drawing.Point(49, 558);
            this.bttFirst.Name = "bttFirst";
            this.bttFirst.Size = new System.Drawing.Size(92, 45);
            this.bttFirst.TabIndex = 1;
            this.bttFirst.Text = "Đầu";
            this.bttFirst.UseVisualStyleBackColor = false;
            this.bttFirst.Click += new System.EventHandler(this.bttFirst_Click);
            // 
            // bttPre
            // 
            this.bttPre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttPre.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttPre.Location = new System.Drawing.Point(158, 558);
            this.bttPre.Name = "bttPre";
            this.bttPre.Size = new System.Drawing.Size(92, 45);
            this.bttPre.TabIndex = 2;
            this.bttPre.Text = "Trước";
            this.bttPre.UseVisualStyleBackColor = false;
            this.bttPre.Click += new System.EventHandler(this.bttPre_Click);
            // 
            // bttNext
            // 
            this.bttNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttNext.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttNext.Location = new System.Drawing.Point(268, 558);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(92, 45);
            this.bttNext.TabIndex = 3;
            this.bttNext.Text = "Sau";
            this.bttNext.UseVisualStyleBackColor = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // bttLast
            // 
            this.bttLast.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttLast.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttLast.Location = new System.Drawing.Point(376, 558);
            this.bttLast.Name = "bttLast";
            this.bttLast.Size = new System.Drawing.Size(92, 45);
            this.bttLast.TabIndex = 4;
            this.bttLast.Text = "Cuối";
            this.bttLast.UseVisualStyleBackColor = false;
            this.bttLast.Click += new System.EventHandler(this.bttLast_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttAdd.Location = new System.Drawing.Point(592, 558);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(92, 45);
            this.bttAdd.TabIndex = 5;
            this.bttAdd.Text = "Thêm";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttFix
            // 
            this.bttFix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFix.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFix.Location = new System.Drawing.Point(698, 558);
            this.bttFix.Name = "bttFix";
            this.bttFix.Size = new System.Drawing.Size(92, 45);
            this.bttFix.TabIndex = 6;
            this.bttFix.Text = "Sửa";
            this.bttFix.UseVisualStyleBackColor = false;
            this.bttFix.Click += new System.EventHandler(this.bttFix_Click);
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttDel.Location = new System.Drawing.Point(807, 558);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(92, 45);
            this.bttDel.TabIndex = 7;
            this.bttDel.Text = "Xóa";
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttSave.Enabled = false;
            this.bttSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttSave.Location = new System.Drawing.Point(905, 558);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(92, 45);
            this.bttSave.TabIndex = 8;
            this.bttSave.Text = "Cập Nhật";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttExit.Location = new System.Drawing.Point(1102, 558);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(92, 45);
            this.bttExit.TabIndex = 9;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(733, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNCC.Location = new System.Drawing.Point(865, 199);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(248, 30);
            this.txtMaNCC.TabIndex = 15;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(865, 261);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(248, 30);
            this.txtTenNCC.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(865, 316);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(248, 30);
            this.txtDiaChi.TabIndex = 17;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.Location = new System.Drawing.Point(865, 372);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(248, 30);
            this.txtSdt.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(865, 433);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 30);
            this.txtEmail.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(733, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(733, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(733, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số điện thoại ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(733, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // bttRe
            // 
            this.bttRe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttRe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttRe.Location = new System.Drawing.Point(948, 485);
            this.bttRe.Name = "bttRe";
            this.bttRe.Size = new System.Drawing.Size(95, 29);
            this.bttRe.TabIndex = 24;
            this.bttRe.Text = "Làm mới";
            this.bttRe.UseVisualStyleBackColor = false;
            this.bttRe.Click += new System.EventHandler(this.bttRe_Click);
            // 
            // bttFind
            // 
            this.bttFind.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bttFind.Location = new System.Drawing.Point(922, 129);
            this.bttFind.Name = "bttFind";
            this.bttFind.Size = new System.Drawing.Size(95, 29);
            this.bttFind.TabIndex = 25;
            this.bttFind.Text = "Lọc dữ liệu ";
            this.bttFind.UseVisualStyleBackColor = false;
            this.bttFind.Click += new System.EventHandler(this.bttFind_Click);
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Items.AddRange(new object[] {
            "Mã nhà cung cấp",
            "Tên nhà cung cấp ",
            "Số điện thoại "});
            this.cbTruong.Location = new System.Drawing.Point(797, 85);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(141, 27);
            this.cbTruong.TabIndex = 26;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(990, 85);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(173, 27);
            this.txtFind.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(946, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(229, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 33);
            this.label7.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(181, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(425, 35);
            this.label11.TabIndex = 36;
            this.label11.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // frmDMNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1218, 619);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cbTruong);
            this.Controls.Add(this.bttFind);
            this.Controls.Add(this.bttRe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttDel);
            this.Controls.Add(this.bttFix);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttLast);
            this.Controls.Add(this.bttNext);
            this.Controls.Add(this.bttPre);
            this.Controls.Add(this.bttFirst);
            this.Controls.Add(this.grdNCC);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDMNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.frmDMNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNCC;
        private System.Windows.Forms.Button bttFirst;
        private System.Windows.Forms.Button bttPre;
        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Button bttLast;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttFix;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttRe;
        private System.Windows.Forms.Button bttFind;
        private System.Windows.Forms.ComboBox cbTruong;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label11;
    }
}