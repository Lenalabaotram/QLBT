using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc
{
    public partial class frmHDX : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        DataTable dtcom1 = new DataTable();
        DataTable dtcom2 = new DataTable();
        DataTable dtcom3 = new DataTable();
        DataTable dtcom4 = new DataTable();
        DataTable dtcom5 = new DataTable();
        DataTable CTHD = new DataTable();
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        string sql,sql3, connstr;
        Boolean AddNewFlag = false;
        int i,dong;
        double tongtien = 0;
        public frmHDX()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void grdHDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void frmHDBL_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "SELECT hoadonxuat.maXuat, hoadonxuat.manv, khachhang.tenkh, hoadonxuat.ngayct FROM hoadonxuat INNER JOIN khachhang ON hoadonxuat.makh = khachhang.makh order by maxuat";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDX.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDX.Refresh();

            sql = "select * from NhanVien ";
            da = new SqlDataAdapter(sql, conn);
            dtcom2.Clear();
            da.Fill(dtcom2);
            txtMaNV.DataSource = dtcom2;
            txtMaNV.DisplayMember = "MaNV";// chỉ ra tên trường muốn hiện thị 8
            

            sql = "select * from khachhang ";
            da = new SqlDataAdapter(sql, conn);
            dtcom3.Clear();
            da.Fill(dtcom3);
            txtTenKH.DataSource = dtcom3;
            txtTenKH.DisplayMember = "TenKH";// chỉ ra tên trường muốn hiện thị 8
            txtTenKH.ValueMember = "MaKH";

            sql = "select * from hanghoa";
            da = new SqlDataAdapter(sql, conn);
            dtcom4.Clear();
            da.Fill(dtcom4);
            txtTenHH.DataSource = dtcom4;
            txtTenHH.DisplayMember = "TenHH";// chỉ ra tên trường muốn hiện thị 8
            txtTenHH.ValueMember = "MaHH";

            CTHD.Columns.Add("Mã hàng", typeof(string));
            CTHD.Columns.Add("Tên hàng", typeof(string));
            CTHD.Columns.Add("Đơn vị", typeof(string));
            CTHD.Columns.Add("Số lượng", typeof(int));
            CTHD.Columns.Add("Đơn giá", typeof(float));
            CTHD.Columns.Add("Thành tiền", typeof(double));
            grdCTX.DataSource = CTHD;

            NapCT();

           
            txtTtien.Text = "0";
        }

        private void bttFirst_Click(object sender, EventArgs e)
        {
            grdHDX.CurrentCell = grdHDX[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            i = grdHDX.CurrentRow.Index;
            if (i > 0)
            {
                grdHDX.CurrentCell = grdHDX[0, i - 1];
                NapCT();

            }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            i = grdHDX.CurrentRow.Index;
            if (i < grdHDX.RowCount - 1)
            {
                grdHDX.CurrentCell = grdHDX[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

            }
        }

        private void bttLast_Click(object sender, EventArgs e)
        {
            grdHDX.CurrentCell = grdHDX[0, grdHDX.RowCount - 1];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "Delete from HoaDonXuatChiTiet where MaXuat='" + txtMaXuat.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd1.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

                sql = "Delete from HoaDonXuat where MaXuat='" + txtMaXuat.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd2.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

                grdHDX.Rows.RemoveAt(grdHDX.CurrentRow.Index);// xóa bản ghi hiện thời 
            }
            else
            {
                MessageBox.Show("Không xóa bản ghi", "Xác nhận yêu cầu",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select distinct " + cbTruong.Text + " FROM hoadonxuat,khachhang where hoadonxuat.makh=khachhang.makh";
            da = new SqlDataAdapter(sql, conn);
            dtcom1.Clear();
            da.Fill(dtcom1);
            cbGtri.DataSource = dtcom1;
            cbGtri.DisplayMember = cbTruong.Text;
        }

        private void bttFind_Click(object sender, EventArgs e)
        {
            sql = "SELECT hoadonxuat.maxuat, hoadonxuat.manv, khachhang.tenkh, hoadonxuat.ngayct FROM hoadonxuat INNER JOIN khachhang ON hoadonxuat.makh = khachhang.makh where " + cbTruong.Text + "=N'" + cbGtri.Text + "' order by Maxuat";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDX.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDX.Refresh();
            NapCT();

            i = grdHDX.CurrentRow.Index;
            sql = "select HoaDonXuatChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonXuatChiTiet.Dvt as 'Đơn vị tính',HoaDonXuatChiTiet.SoLuong as 'Số Lượng',HoaDonXuatChiTiet.DGxuat as 'Đơn giá',HoaDonXuatChiTiet.soluong*HoaDonXuatChiTiet.dgxuat as 'Thành Tiền' from HoaDonxuatchitiet,HangHoa where HoaDonXuatChiTiet.MaHH=HangHoa.MaHH and MaXuat='" + grdHDX[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTX.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTX.Refresh();
            NapCTHD();

            sql = "select HoaDonXuatChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonXuatChiTiet.Dvt as 'Đơn vị tính',HoaDonXuatChiTiet.SoLuong as 'Số Lượng',HoaDonXuatChiTiet.DGxuat as 'Đơn giá',HoaDonXuatChiTiet.soluong*HoaDonXuatChiTiet.dgxuat as 'Thành Tiền' from HoaDonXuatchitiet,HangHoa,NhanVien,HoaDonXuat where HoaDonXuatChiTiet.MaHH=HangHoa.MaHH and HoaDonXuatChiTiet.MaXuat=HoaDonXuat.MaXuat and HoaDonXuat.MaNV=NhanVien.MaNV and HoaDonXuat.MaNV='" + grdHDX[1, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTX.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTX.Refresh();
            NapCTHD();
        }

        private void grdHDX_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
            i = grdHDX.CurrentRow.Index;
            sql = "select HoaDonXuatChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonXuatChiTiet.Dvt as 'Đơn vị tính',HoaDonXuatChiTiet.SoLuong as 'Số Lượng',HoaDonXuatChiTiet.DGxuat as 'Đơn giá',HoaDonXuatChiTiet.soluong*HoaDonXuatChiTiet.dgxuat as 'Thành Tiền' from HoaDonxuatchitiet,HangHoa where HoaDonXuatChiTiet.MaHH=HangHoa.MaHH and MaXuat='" + grdHDX[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTX.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTX.Refresh();
            NapCTHD();
        }

       

        private void bttAddct_Click(object sender, EventArgs e)
        {
           
            double ThanhTien = float.Parse(txtDGxuat.Text) * int.Parse(txtSlg.Text);
            tongtien = tongtien + ThanhTien;
            txtTtien.Text = tongtien.ToString();
            CTHD.Rows.Add(txtTenHH.SelectedValue.ToString(),txtTenHH.Text,txtDvt.Text,int.Parse(txtSlg.Text),float.Parse(txtDGxuat.Text),ThanhTien);
            grdCTX.DataSource = CTHD;


        }

        private void txtTenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True");
            sql = "Select*from hanghoa where tenHH=N'" + txtTenHH.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string dv = rd.GetString(3);
                    txtDvt.Text = dv;
                    float dg = rd.GetFloat(5);
                    txtDGxuat.Text = dg.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCTHD();
        }

        private void bttFixct_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow newRow = grdCTX.Rows[dong];
            newRow.Cells[0].Value = txtTenHH.SelectedValue.ToString();
            newRow.Cells[1].Value = txtTenHH.Text;
            newRow.Cells[2].Value = txtDvt.Text;
            newRow.Cells[3].Value = txtSlg.Text;
            newRow.Cells[4].Value = txtDGxuat.Text;
            newRow.Cells[5].Value = int.Parse(txtSlg.Text) * float.Parse(txtDGxuat.Text);

            int g = 0;
            double tt = 0;
            for (g = 0; g < grdCTX.RowCount - 1; g++)
            {
                tt = tt + Convert.ToDouble(grdCTX[5, g].Value.ToString());
            }
            txtTtien.Text = Convert.ToString(tt);

            sql3 = "update hoadonxuatchitiet set SoLuong='" + txtSlg.Text
                    + "',ThanhTien='" + (int.Parse(txtSlg.Text) * float.Parse(txtDGxuat.Text))
                    + "'where maxuat='" + txtMaXuat.Text + "' and MaHH='" + txtTenHH.SelectedValue.ToString() + "'";
            cmd = new SqlCommand(sql3, conn);
            cmd.ExecuteNonQuery();
        }

        private void bttDelct_Click(object sender, EventArgs e)
        {

            double tt;
            tt = Convert.ToDouble(txtTtien.Text) - Convert.ToDouble(grdCTX[5, dong].Value.ToString());
            txtTtien.Text = Convert.ToString(tt);

            grdCTX.Rows.RemoveAt(dong);

            sql = "Delete from HoaDonXuatChiTiet where MaXuat='" + txtMaXuat.Text + "' and MaHH='" + txtTenHH.SelectedValue.ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
            cmd2.ExecuteNonQuery();
        }

        private void txtTong_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bttAddct.Enabled = true;
            bttFixct.Enabled = true;
            bttDelct.Enabled = true;
            txtMaXuat.Enabled = true;
            bttSave.Enabled = true;
            bttSave.Enabled = true;
            grdHDX.CurrentCell = grdHDX[0, grdHDX.RowCount - 1];
            CTHD.Clear();
            NapCT();
            txtMaXuat.Focus();
            AddNewFlag = true;
            
            
        }

        private void bttUpd_Click(object sender, EventArgs e)
        {
            bttAddct.Enabled = true;
            bttFixct.Enabled = true;
            bttDelct.Enabled = true;
            
            bttSave.Enabled = true;
            txtMaXuat.Enabled = false;
            NapCT();
            txtMaNV.Focus();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void grbttbh_Enter(object sender, EventArgs e)
        {

        }

        private void grdCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaXuat.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtSlg.Text))
            {

                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDMKH f = new frmDMKH();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmDMHH f = new frmDMHH();
            f.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = "SELECT hoadonxuat.maXuat, hoadonxuat.manv, khachhang.tenkh, hoadonxuat.ngayct FROM hoadonxuat INNER JOIN khachhang ON hoadonxuat.makh = khachhang.makh order by maxuat";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDX.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDX.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSlg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDvt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                if (check())
                {
                    sql = "insert into hoadonxuat values('" + txtMaXuat.Text
                         + "',N'" + txtTenKH.SelectedValue.ToString()
                         + "',N'" + txtMaNV.Text
                         + "','" + txtDate.Value.ToShortDateString()
                         + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();




                    foreach (DataRow dr in CTHD.Rows)
                    {
                        sql3 = "insert into hoadonxuatchitiet values(N'" + txtMaXuat.Text
                            + "',N'" + dr[0].ToString()
                            + "',N'" + dr[2].ToString()
                            + "','"
                            + "','" + dr[3].ToString()
                            + "','" + dr[4].ToString()
                            + "','" + dr[5].ToString() + "')";
                        cmd1 = new SqlCommand(sql3, conn);
                        cmd1.ExecuteNonQuery();
                    }

                    CTHD.Clear();
                    sql = "SELECT hoadonxuat.maXuat, hoadonxuat.manv, khachhang.tenkh, hoadonxuat.ngayct FROM hoadonxuat INNER JOIN khachhang ON hoadonxuat.makh = khachhang.makh order by maxuat";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear();
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdHDX.DataSource = dt;// khai báo nguông  dữ liệu
                    grdHDX.Refresh();
                    bttSave.Enabled = false;
                    bttAddct.Enabled = false;
                    bttFixct.Enabled = false;
                    bttDelct.Enabled = false;
                    AddNewFlag = false;
                    MessageBox.Show("Đã thêm mới Hóa đơn thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn đang nhập thiếu thông tin!", "Thông báo");
                }
            }
            else
            {
                sql3 = "update hoadonxuat set ngayct='" + txtDate.Value.ToShortDateString()
                    + "',MaKH=N'" + txtTenKH.SelectedValue.ToString()
                    + "',MaNV=N'" + txtMaNV.Text
                    + "'where maxuat=N'" + txtMaXuat.Text + "' ";
                cmd = new SqlCommand(sql3, conn);
                cmd.ExecuteNonQuery();

                foreach (DataRow dr in CTHD.Rows)
                {
                    sql3 = "insert into hoadonxuatchitiet values(N'" + txtMaXuat.Text
                            + "',N'" + dr[0].ToString()
                            + "',N'" + dr[2].ToString()
                            + "','"
                            + "','" + dr[3].ToString()
                            + "','" + dr[4].ToString()
                            + "','" + dr[5].ToString() + "')";
                    cmd1 = new SqlCommand(sql3, conn);
                    cmd1.ExecuteNonQuery();
                }

                CTHD.Clear();
                sql = "SELECT hoadonxuat.maXuat, hoadonxuat.manv, khachhang.tenkh, hoadonxuat.ngayct FROM hoadonxuat INNER JOIN khachhang ON hoadonxuat.makh = khachhang.makh order by maxuat";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdHDX.DataSource = dt;// khai báo nguông  dữ liệu
                grdHDX.Refresh();
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttAddct.Enabled = false;
                bttFixct.Enabled = false;
                bttDelct.Enabled = false;
                bttSave.Enabled = false;
            }
           




        }

       public void NapCT()
        {
           i = grdHDX.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaXuat.Text = grdHDX[0, i].Value.ToString();
            txtMaNV.Text = grdHDX[1, i].Value.ToString();
            txtTenKH.Text = grdHDX[2, i].Value.ToString();
            txtDate.Text = grdHDX[3, i].Value.ToString();
           


        }
        public void NapCTHD()
        {
            dong = grdCTX.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtTenHH.Text = grdCTX[1, dong].Value.ToString();
            txtDvt.Text = grdCTX[2, dong].Value.ToString();
            txtSlg.Text = grdCTX[3, dong].Value.ToString();
            txtDGxuat.Text = grdCTX[4, dong].Value.ToString();

            int g = 0;
            double tt = 0;
            for (g = 0; g < grdCTX.RowCount - 1; g++)
            {
                tt = tt + Convert.ToDouble(grdCTX[5, g].Value.ToString());
            }
            txtTtien.Text = Convert.ToString(tt);

        }

    }
}
