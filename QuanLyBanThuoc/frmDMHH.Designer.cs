namespace QuanLyBanThuoc
{
    partial class frmDMHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMHH));
            this.grdDMHH = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttFix = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttLast = new System.Windows.Forms.Button();
            this.bttNext = new System.Windows.Forms.Button();
            this.bttPre = new System.Windows.Forms.Button();
            this.bttFist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttExit = new System.Windows.Forms.Button();
            this.txtMaNhom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSanXuat = new System.Windows.Forms.TextBox();
            this.txtGxuat = new System.Windows.Forms.TextBox();
            this.txtGnhap = new System.Windows.Forms.TextBox();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.cbGtri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bttFil = new System.Windows.Forms.Button();
            this.bttRe = new System.Windows.Forms.Button();
            this.btnInnhom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLTon = new System.Windows.Forms.TextBox();
            this.Tồn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMHH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDMHH
            // 
            this.grdDMHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDMHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.DGnhap,
            this.DGxuat,
            this.SanXuat,
            this.LuongTon});
            this.grdDMHH.Enabled = false;
            this.grdDMHH.Location = new System.Drawing.Point(12, 71);
            this.grdDMHH.Name = "grdDMHH";
            this.grdDMHH.RowTemplate.Height = 24;
            this.grdDMHH.Size = new System.Drawing.Size(935, 506);
            this.grdDMHH.TabIndex = 0;
            this.grdDMHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDMHH_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 117;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã HH";
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 98;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên HH";
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 102;
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đơn vị tính";
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 128;
            // 
            // DGnhap
            // 
            this.DGnhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGnhap.DataPropertyName = "DGnhap";
            this.DGnhap.HeaderText = "Giá nhập";
            this.DGnhap.Name = "DGnhap";
            this.DGnhap.Width = 110;
            // 
            // DGxuat
            // 
            this.DGxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGxuat.DataPropertyName = "DGxuat";
            this.DGxuat.HeaderText = "Giá xuất";
            this.DGxuat.Name = "DGxuat";
            this.DGxuat.Width = 105;
            // 
            // SanXuat
            // 
            this.SanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SanXuat.DataPropertyName = "SanXuat";
            this.SanXuat.HeaderText = "Sản Xuất";
            this.SanXuat.Name = "SanXuat";
            this.SanXuat.Width = 110;
            // 
            // LuongTon
            // 
            this.LuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LuongTon.DataPropertyName = "LuongTon";
            this.LuongTon.HeaderText = "Lượng Tồn";
            this.LuongTon.Name = "LuongTon";
            this.LuongTon.Width = 126;
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttAdd.Location = new System.Drawing.Point(491, 31);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(83, 37);
            this.bttAdd.TabIndex = 0;
            this.bttAdd.Text = "Thêm ";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttDel.Location = new System.Drawing.Point(580, 31);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(83, 37);
            this.bttDel.TabIndex = 1;
            this.bttDel.Text = "Xóa ";
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bttFix
            // 
            this.bttFix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttFix.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFix.Location = new System.Drawing.Point(669, 31);
            this.bttFix.Name = "bttFix";
            this.bttFix.Size = new System.Drawing.Size(83, 37);
            this.bttFix.TabIndex = 2;
            this.bttFix.Text = "Sửa";
            this.bttFix.UseVisualStyleBackColor = false;
            this.bttFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSave.Enabled = false;
            this.bttSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttSave.Location = new System.Drawing.Point(758, 31);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(97, 37);
            this.bttSave.TabIndex = 3;
            this.bttSave.Text = "Cập nhật ";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(1100, 330);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(217, 30);
            this.txtDvt.TabIndex = 12;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(1100, 278);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(217, 30);
            this.txtTenHH.TabIndex = 11;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(1100, 226);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(217, 30);
            this.txtMaHH.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(973, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(973, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(973, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(973, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm ";
            // 
            // bttLast
            // 
            this.bttLast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLast.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttLast.Location = new System.Drawing.Point(282, 31);
            this.bttLast.Name = "bttLast";
            this.bttLast.Size = new System.Drawing.Size(83, 37);
            this.bttLast.TabIndex = 15;
            this.bttLast.Text = "Cuối";
            this.bttLast.UseVisualStyleBackColor = false;
            this.bttLast.Click += new System.EventHandler(this.bttLast_Click);
            // 
            // bttNext
            // 
            this.bttNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttNext.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttNext.Location = new System.Drawing.Point(193, 31);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(83, 37);
            this.bttNext.TabIndex = 16;
            this.bttNext.Text = "Sau";
            this.bttNext.UseVisualStyleBackColor = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // bttPre
            // 
            this.bttPre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttPre.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttPre.Location = new System.Drawing.Point(104, 31);
            this.bttPre.Name = "bttPre";
            this.bttPre.Size = new System.Drawing.Size(83, 37);
            this.bttPre.TabIndex = 17;
            this.bttPre.Text = "Trước";
            this.bttPre.UseVisualStyleBackColor = false;
            this.bttPre.Click += new System.EventHandler(this.bttPre_Click);
            // 
            // bttFist
            // 
            this.bttFist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttFist.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFist.Location = new System.Drawing.Point(15, 31);
            this.bttFist.Name = "bttFist";
            this.bttFist.Size = new System.Drawing.Size(83, 37);
            this.bttFist.TabIndex = 18;
            this.bttFist.Text = "Đầu";
            this.bttFist.UseVisualStyleBackColor = false;
            this.bttFist.Click += new System.EventHandler(this.bttFist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttExit);
            this.groupBox1.Controls.Add(this.bttFist);
            this.groupBox1.Controls.Add(this.bttPre);
            this.groupBox1.Controls.Add(this.bttNext);
            this.groupBox1.Controls.Add(this.bttLast);
            this.groupBox1.Controls.Add(this.bttSave);
            this.groupBox1.Controls.Add(this.bttFix);
            this.groupBox1.Controls.Add(this.bttDel);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Location = new System.Drawing.Point(3, 607);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttExit.ForeColor = System.Drawing.Color.Firebrick;
            this.bttExit.Location = new System.Drawing.Point(1142, 29);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(120, 37);
            this.bttExit.TabIndex = 19;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.FormattingEnabled = true;
            this.txtMaNhom.Location = new System.Drawing.Point(1100, 174);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(217, 30);
            this.txtMaNhom.TabIndex = 9;
            this.txtMaNhom.SelectedIndexChanged += new System.EventHandler(this.txtMaNhom_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(974, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sản xuất";
            // 
            // txtSanXuat
            // 
            this.txtSanXuat.Location = new System.Drawing.Point(1100, 488);
            this.txtSanXuat.Multiline = true;
            this.txtSanXuat.Name = "txtSanXuat";
            this.txtSanXuat.Size = new System.Drawing.Size(217, 30);
            this.txtSanXuat.TabIndex = 15;
            // 
            // txtGxuat
            // 
            this.txtGxuat.Location = new System.Drawing.Point(1101, 437);
            this.txtGxuat.Multiline = true;
            this.txtGxuat.Name = "txtGxuat";
            this.txtGxuat.Size = new System.Drawing.Size(217, 30);
            this.txtGxuat.TabIndex = 14;
            // 
            // txtGnhap
            // 
            this.txtGnhap.Location = new System.Drawing.Point(1100, 385);
            this.txtGnhap.Multiline = true;
            this.txtGnhap.Name = "txtGnhap";
            this.txtGnhap.Size = new System.Drawing.Size(217, 30);
            this.txtGnhap.TabIndex = 13;
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Items.AddRange(new object[] {
            "MaNhom",
            "TenHH",
            "SanXuat"});
            this.cbTruong.Location = new System.Drawing.Point(993, 90);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(143, 30);
            this.cbTruong.TabIndex = 22;
            this.cbTruong.SelectedIndexChanged += new System.EventHandler(this.cbTruong_SelectedIndexChanged);
            // 
            // cbGtri
            // 
            this.cbGtri.FormattingEnabled = true;
            this.cbGtri.Location = new System.Drawing.Point(1213, 90);
            this.cbGtri.Name = "cbGtri";
            this.cbGtri.Size = new System.Drawing.Size(143, 30);
            this.cbGtri.TabIndex = 23;
            this.cbGtri.SelectedIndexChanged += new System.EventHandler(this.cbGtri_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(1161, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 33);
            this.label8.TabIndex = 24;
            this.label8.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1023, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tên trường";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1252, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Giá trị";
            // 
            // bttFil
            // 
            this.bttFil.Location = new System.Drawing.Point(1111, 126);
            this.bttFil.Name = "bttFil";
            this.bttFil.Size = new System.Drawing.Size(130, 30);
            this.bttFil.TabIndex = 27;
            this.bttFil.Text = "Lọc dữ liệu";
            this.bttFil.UseVisualStyleBackColor = true;
            this.bttFil.Click += new System.EventHandler(this.bttFil_Click);
            // 
            // bttRe
            // 
            this.bttRe.Location = new System.Drawing.Point(1214, 581);
            this.bttRe.Name = "bttRe";
            this.bttRe.Size = new System.Drawing.Size(100, 30);
            this.bttRe.TabIndex = 28;
            this.bttRe.Text = "Làm Mới";
            this.bttRe.UseVisualStyleBackColor = true;
            this.bttRe.Click += new System.EventHandler(this.bttRe_Click);
            // 
            // btnInnhom
            // 
            this.btnInnhom.Location = new System.Drawing.Point(1058, 581);
            this.btnInnhom.Name = "btnInnhom";
            this.btnInnhom.Size = new System.Drawing.Size(111, 30);
            this.btnInnhom.TabIndex = 31;
            this.btnInnhom.Text = "In Báo Cáo Theo Nhóm Hàng";
            this.btnInnhom.UseVisualStyleBackColor = true;
            this.btnInnhom.Click += new System.EventHandler(this.btnInnhom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(273, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(356, 35);
            this.label11.TabIndex = 32;
            this.label11.Text = "DANH MỤC HÀNG HÓA";
            // 
            // txtLTon
            // 
            this.txtLTon.Location = new System.Drawing.Point(1099, 534);
            this.txtLTon.Multiline = true;
            this.txtLTon.Name = "txtLTon";
            this.txtLTon.Size = new System.Drawing.Size(217, 30);
            this.txtLTon.TabIndex = 33;
            // 
            // Tồn
            // 
            this.Tồn.AutoSize = true;
            this.Tồn.Location = new System.Drawing.Point(978, 537);
            this.Tồn.Name = "Tồn";
            this.Tồn.Size = new System.Drawing.Size(90, 22);
            this.Tồn.TabIndex = 34;
            this.Tồn.Text = "Lượng tồn";
            this.Tồn.Click += new System.EventHandler(this.label12_Click);
            // 
            // frmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 692);
            this.Controls.Add(this.txtLTon);
            this.Controls.Add(this.Tồn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnInnhom);
            this.Controls.Add(this.bttRe);
            this.Controls.Add(this.bttFil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGtri);
            this.Controls.Add(this.cbTruong);
            this.Controls.Add(this.txtGnhap);
            this.Controls.Add(this.txtGxuat);
            this.Controls.Add(this.txtSanXuat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.grdDMHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDMHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa ";
            this.Load += new System.EventHandler(this.frmDMHH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMHH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdDMHH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDMHH;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttFix;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttLast;
        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Button bttPre;
        private System.Windows.Forms.Button bttFist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.ComboBox txtMaNhom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSanXuat;
        private System.Windows.Forms.TextBox txtGxuat;
        private System.Windows.Forms.TextBox txtGnhap;
        private System.Windows.Forms.ComboBox cbTruong;
        private System.Windows.Forms.ComboBox cbGtri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttFil;
        private System.Windows.Forms.Button bttRe;
        private System.Windows.Forms.Button btnInnhom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLTon;
        private System.Windows.Forms.Label Tồn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTon;
    }
}