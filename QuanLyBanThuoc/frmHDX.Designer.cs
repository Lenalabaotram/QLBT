namespace QuanLyBanThuoc
{
    partial class frmHDX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHDX));
            this.label1 = new System.Windows.Forms.Label();
            this.grbttbh = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grdHDX = new System.Windows.Forms.DataGridView();
            this.MaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttLast = new System.Windows.Forms.Button();
            this.bttNext = new System.Windows.Forms.Button();
            this.bttPre = new System.Windows.Forms.Button();
            this.bttFirst = new System.Windows.Forms.Button();
            this.bttAddct = new System.Windows.Forms.Button();
            this.bttUpd = new System.Windows.Forms.Button();
            this.bttFixct = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.cbGtri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bttFind = new System.Windows.Forms.Button();
            this.grdCTX = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttDelct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.ComboBox();
            this.txtDGxuat = new System.Windows.Forms.TextBox();
            this.txtSlg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTtien = new System.Windows.Forms.TextBox();
            this.bttIn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grbttbh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(635, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // grbttbh
            // 
            this.grbttbh.Controls.Add(this.button3);
            this.grbttbh.Controls.Add(this.txtMaNV);
            this.grbttbh.Controls.Add(this.txtDate);
            this.grbttbh.Controls.Add(this.label8);
            this.grbttbh.Controls.Add(this.txtMaXuat);
            this.grbttbh.Controls.Add(this.label7);
            this.grbttbh.Controls.Add(this.label4);
            this.grbttbh.Controls.Add(this.label2);
            this.grbttbh.Controls.Add(this.txtTenKH);
            this.grbttbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbttbh.Location = new System.Drawing.Point(12, 141);
            this.grbttbh.Name = "grbttbh";
            this.grbttbh.Size = new System.Drawing.Size(624, 155);
            this.grbttbh.TabIndex = 3;
            this.grbttbh.TabStop = false;
            this.grbttbh.Text = "THÔNG TIN BÁN HÀNG ";
            this.grbttbh.Enter += new System.EventHandler(this.grbttbh_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(589, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 27;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(110, 97);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(114, 28);
            this.txtMaNV.TabIndex = 16;
            // 
            // txtDate
            // 
            this.txtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(357, 97);
            this.txtDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(226, 27);
            this.txtDate.TabIndex = 15;
            this.txtDate.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã nhân viên";
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Enabled = false;
            this.txtMaXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXuat.Location = new System.Drawing.Point(110, 42);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(114, 27);
            this.txtMaXuat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên khách hàng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày bán ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Hóa đơn";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.FormattingEnabled = true;
            this.txtTenKH.Location = new System.Drawing.Point(357, 43);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(226, 33);
            this.txtTenKH.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.grdHDX);
            this.groupBox2.Controls.Add(this.bttLast);
            this.groupBox2.Controls.Add(this.bttNext);
            this.groupBox2.Controls.Add(this.bttPre);
            this.groupBox2.Controls.Add(this.bttFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 327);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN HÓA ĐƠN";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(15, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 21;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grdHDX
            // 
            this.grdHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXuat,
            this.MaNV,
            this.TenKH,
            this.NgayCT});
            this.grdHDX.Location = new System.Drawing.Point(15, 57);
            this.grdHDX.Name = "grdHDX";
            this.grdHDX.RowTemplate.Height = 24;
            this.grdHDX.Size = new System.Drawing.Size(602, 279);
            this.grdHDX.TabIndex = 20;
            this.grdHDX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHDX_CellContentClick_1);
            // 
            // MaXuat
            // 
            this.MaXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaXuat.DataPropertyName = "MaXuat";
            this.MaXuat.HeaderText = "Mã hóa đơn";
            this.MaXuat.Name = "MaXuat";
            this.MaXuat.Width = 107;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 114;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // NgayCT
            // 
            this.NgayCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayCT.DataPropertyName = "NgayCT";
            this.NgayCT.HeaderText = "Ngày bán";
            this.NgayCT.Name = "NgayCT";
            this.NgayCT.Width = 91;
            // 
            // bttLast
            // 
            this.bttLast.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttLast.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttLast.Location = new System.Drawing.Point(457, 21);
            this.bttLast.Name = "bttLast";
            this.bttLast.Size = new System.Drawing.Size(90, 30);
            this.bttLast.TabIndex = 8;
            this.bttLast.Text = "Cuối";
            this.bttLast.UseVisualStyleBackColor = false;
            this.bttLast.Click += new System.EventHandler(this.bttLast_Click);
            // 
            // bttNext
            // 
            this.bttNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttNext.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttNext.Location = new System.Drawing.Point(357, 21);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(90, 31);
            this.bttNext.TabIndex = 7;
            this.bttNext.Text = "Sau";
            this.bttNext.UseVisualStyleBackColor = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // bttPre
            // 
            this.bttPre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttPre.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttPre.Location = new System.Drawing.Point(253, 21);
            this.bttPre.Name = "bttPre";
            this.bttPre.Size = new System.Drawing.Size(90, 30);
            this.bttPre.TabIndex = 6;
            this.bttPre.Text = "Trước";
            this.bttPre.UseVisualStyleBackColor = false;
            this.bttPre.Click += new System.EventHandler(this.bttPre_Click);
            // 
            // bttFirst
            // 
            this.bttFirst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFirst.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFirst.Location = new System.Drawing.Point(155, 21);
            this.bttFirst.Name = "bttFirst";
            this.bttFirst.Size = new System.Drawing.Size(90, 31);
            this.bttFirst.TabIndex = 5;
            this.bttFirst.Text = "Đầu";
            this.bttFirst.UseVisualStyleBackColor = false;
            this.bttFirst.Click += new System.EventHandler(this.bttFirst_Click);
            // 
            // bttAddct
            // 
            this.bttAddct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttAddct.Enabled = false;
            this.bttAddct.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttAddct.Location = new System.Drawing.Point(180, 13);
            this.bttAddct.Name = "bttAddct";
            this.bttAddct.Size = new System.Drawing.Size(88, 34);
            this.bttAddct.TabIndex = 9;
            this.bttAddct.Text = "Thêm";
            this.bttAddct.UseVisualStyleBackColor = false;
            this.bttAddct.Click += new System.EventHandler(this.bttAddct_Click);
            // 
            // bttUpd
            // 
            this.bttUpd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttUpd.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttUpd.Location = new System.Drawing.Point(346, 639);
            this.bttUpd.Name = "bttUpd";
            this.bttUpd.Size = new System.Drawing.Size(90, 39);
            this.bttUpd.TabIndex = 10;
            this.bttUpd.Text = "Cập nhật";
            this.bttUpd.UseVisualStyleBackColor = false;
            this.bttUpd.Click += new System.EventHandler(this.bttUpd_Click);
            // 
            // bttFixct
            // 
            this.bttFixct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFixct.Enabled = false;
            this.bttFixct.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFixct.Location = new System.Drawing.Point(294, 13);
            this.bttFixct.Name = "bttFixct";
            this.bttFixct.Size = new System.Drawing.Size(88, 34);
            this.bttFixct.TabIndex = 11;
            this.bttFixct.Text = "Sửa";
            this.bttFixct.UseVisualStyleBackColor = false;
            this.bttFixct.Click += new System.EventHandler(this.bttFixct_Click);
            // 
            // bttDel
            // 
            this.bttDel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttDel.Location = new System.Drawing.Point(442, 639);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(90, 39);
            this.bttDel.TabIndex = 12;
            this.bttDel.Text = "Xóa";
            this.bttDel.UseVisualStyleBackColor = false;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Items.AddRange(new object[] {
            "MaXuat",
            "MaNV",
            "TenKH",
            "NgayCT"});
            this.cbTruong.Location = new System.Drawing.Point(136, 79);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(161, 24);
            this.cbTruong.TabIndex = 13;
            this.cbTruong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbGtri
            // 
            this.cbGtri.FormattingEnabled = true;
            this.cbGtri.Location = new System.Drawing.Point(398, 83);
            this.cbGtri.Name = "cbGtri";
            this.cbGtri.Size = new System.Drawing.Size(171, 24);
            this.cbGtri.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên trường";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giá trị";
            // 
            // bttFind
            // 
            this.bttFind.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttFind.Location = new System.Drawing.Point(301, 107);
            this.bttFind.Name = "bttFind";
            this.bttFind.Size = new System.Drawing.Size(90, 28);
            this.bttFind.TabIndex = 18;
            this.bttFind.Text = "Tìm kiếm";
            this.bttFind.UseVisualStyleBackColor = false;
            this.bttFind.Click += new System.EventHandler(this.bttFind_Click);
            // 
            // grdCTX
            // 
            this.grdCTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCTX.Location = new System.Drawing.Point(6, 53);
            this.grdCTX.Name = "grdCTX";
            this.grdCTX.RowTemplate.Height = 24;
            this.grdCTX.Size = new System.Drawing.Size(842, 270);
            this.grdCTX.TabIndex = 19;
            this.grdCTX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCT_CellClick);
            this.grdCTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCT_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttDelct);
            this.groupBox1.Controls.Add(this.grdCTX);
            this.groupBox1.Controls.Add(this.bttAddct);
            this.groupBox1.Controls.Add(this.bttFixct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(641, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 336);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // bttDelct
            // 
            this.bttDelct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttDelct.Enabled = false;
            this.bttDelct.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttDelct.Location = new System.Drawing.Point(411, 13);
            this.bttDelct.Name = "bttDelct";
            this.bttDelct.Size = new System.Drawing.Size(88, 34);
            this.bttDelct.TabIndex = 24;
            this.bttDelct.Text = "Xóa";
            this.bttDelct.UseVisualStyleBackColor = false;
            this.bttDelct.Click += new System.EventHandler(this.bttDelct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtDvt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTenHH);
            this.groupBox3.Controls.Add(this.txtDGxuat);
            this.groupBox3.Controls.Add(this.txtSlg);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(641, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 155);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN HÓA ĐƠN ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(381, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDvt
            // 
            this.txtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Location = new System.Drawing.Point(140, 100);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(142, 27);
            this.txtDvt.TabIndex = 8;
            this.txtDvt.TextChanged += new System.EventHandler(this.txtDvt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Đơn vị";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.FormattingEnabled = true;
            this.txtTenHH.Location = new System.Drawing.Point(139, 45);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(236, 28);
            this.txtTenHH.TabIndex = 6;
            this.txtTenHH.SelectedIndexChanged += new System.EventHandler(this.txtTenHH_SelectedIndexChanged);
            // 
            // txtDGxuat
            // 
            this.txtDGxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGxuat.Location = new System.Drawing.Point(544, 98);
            this.txtDGxuat.Name = "txtDGxuat";
            this.txtDGxuat.Size = new System.Drawing.Size(166, 27);
            this.txtDGxuat.TabIndex = 5;
            // 
            // txtSlg
            // 
            this.txtSlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlg.Location = new System.Drawing.Point(544, 45);
            this.txtSlg.Name = "txtSlg";
            this.txtSlg.Size = new System.Drawing.Size(166, 27);
            this.txtSlg.TabIndex = 4;
            this.txtSlg.TextChanged += new System.EventHandler(this.txtSlg_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Thuốc";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(27, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thêm hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttSave.Enabled = false;
            this.bttSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttSave.Location = new System.Drawing.Point(250, 639);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(90, 39);
            this.bttSave.TabIndex = 23;
            this.bttSave.Text = "Lưu ";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1083, 658);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tổng tiền ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtTtien
            // 
            this.txtTtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtien.Location = new System.Drawing.Point(1191, 651);
            this.txtTtien.Name = "txtTtien";
            this.txtTtien.Size = new System.Drawing.Size(160, 27);
            this.txtTtien.TabIndex = 25;
            this.txtTtien.TextChanged += new System.EventHandler(this.txtTtien_TextChanged);
            // 
            // bttIn
            // 
            this.bttIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttIn.ForeColor = System.Drawing.Color.DarkBlue;
            this.bttIn.Location = new System.Drawing.Point(538, 639);
            this.bttIn.Name = "bttIn";
            this.bttIn.Size = new System.Drawing.Size(90, 39);
            this.bttIn.TabIndex = 26;
            this.bttIn.Text = "In HĐ";
            this.bttIn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(1390, 644);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 40);
            this.button5.TabIndex = 63;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1516, 688);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bttIn);
            this.Controls.Add(this.txtTtien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bttDel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttFind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGtri);
            this.Controls.Add(this.cbTruong);
            this.Controls.Add(this.bttUpd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbttbh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán lẻ ";
            this.Load += new System.EventHandler(this.frmHDBL_Load);
            this.grbttbh.ResumeLayout(false);
            this.grbttbh.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbttbh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttFirst;
        private System.Windows.Forms.Button bttPre;
        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Button bttLast;
        private System.Windows.Forms.Button bttAddct;
        private System.Windows.Forms.Button bttUpd;
        private System.Windows.Forms.Button bttFixct;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cbTruong;
        private System.Windows.Forms.ComboBox cbGtri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdCTX;
        private System.Windows.Forms.DataGridView grdHDX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtTenHH;
        private System.Windows.Forms.TextBox txtDGxuat;
        private System.Windows.Forms.TextBox txtSlg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.Button bttDelct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTtien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttFind;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCT;
        private System.Windows.Forms.Button button5;
    }
}