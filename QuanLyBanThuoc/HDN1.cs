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
    public partial class HDN1 : Form
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
        DataTable dtrp = new DataTable();
        DataTable CTHD = new DataTable();
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        string sql, sql3, connstr;
        Boolean AddNewFlag = false;
        int i, dong;
        double tongtien = 0;
        public HDN1()
        {
            InitializeComponent();
        }

        private void grdHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
            i = grdHDN.CurrentRow.Index;
            sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTN.Refresh();
            NapCTHD();
        }
        private void grdCTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCTHD();
        }
        private void bttFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
           
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            
        }

        private void bttLast_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select distinct " + cbTruong.Text + " FROM hoadonnhap,nhacungcap where hoadonnhap.mancc=nhacungcap.mancc";
            da = new SqlDataAdapter(sql, conn);
            dtcom1.Clear();
            da.Fill(dtcom1);
            cbGtri.DataSource = dtcom1;
            cbGtri.DisplayMember = cbTruong.Text;
        }

        private void bttFind_Click(object sender, EventArgs e)
        {
            sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc where " + cbTruong.Text + "=N'" + cbGtri.Text + "' order by Manhap";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDN.Refresh();
            NapCT();

            i = grdHDN.CurrentRow.Index;
            sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTN.Refresh();
            NapCTHD();

            sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa,NhanVien,HoaDonNhap where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and HoaDonNhapChiTiet.MaNhap=HoaDonNhap.MaNhap and HoaDonNhap.MaNV=NhanVien.MaNV and HoaDonNhap.MaNV='" + grdHDN[1, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTN.Refresh();
            NapCTHD();
        }

        private void txtTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDMNCC f = new frmDMNCC();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc order by MaNhap";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDN.Refresh();

            
        }

        private void bttFirst_Click_1(object sender, EventArgs e)
        {
            grdHDN.CurrentCell = grdHDN[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
            i = grdHDN.CurrentRow.Index;
            sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTN.Refresh();
            NapCTHD();

        }

        private void bttPre_Click_1(object sender, EventArgs e)
        {
            i = grdHDN.CurrentRow.Index;
            if (i > 0)
            {
                grdHDN.CurrentCell = grdHDN[0, i - 1];
                NapCT();

                sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dtcom.Clear();
                da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
                grdCTN.Refresh();
                NapCTHD();
            }
            
        }

        private void bttNext_Click_1(object sender, EventArgs e)
        {
            i = grdHDN.CurrentRow.Index;
            if (i < grdHDN.RowCount - 2)
            {
                grdHDN.CurrentCell = grdHDN[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

                sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dtcom.Clear();
                da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
                grdCTN.Refresh();
                NapCTHD();

            }
            
        }

        private void bttLast_Click_1(object sender, EventArgs e)
        {
            grdHDN.CurrentCell = grdHDN[0, grdHDN.RowCount - 2];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
            i = grdHDN.CurrentRow.Index;
            sql = "select HoaDonNhapChiTiet.MaHH as 'Mã thuốc',hanghoa.TenHH as 'Tên thuốc', HoaDonNhapChiTiet.Dvt as 'Đơn vị tính',hoadonnhapchitiet.hansd as 'HSD',HoaDonNhapChiTiet.SoLuong as 'Số Lượng',HoaDonNhapChiTiet.DGnhap as 'Đơn giá',HoaDonNhapChiTiet.soluong*HoaDonNhapChiTiet.dgnhap as 'Thành Tiền' from HoaDonnhapchitiet,HangHoa where HoaDonNhapChiTiet.MaHH=HangHoa.MaHH and MaNhap='" + grdHDN[0, i].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dtcom.Clear();
            da.Fill(dtcom); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdCTN.DataSource = dtcom;// khai báo nguông  dữ liệu
            grdCTN.Refresh();
            NapCTHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CTHD.Clear();
            bttAddct.Enabled = true;
            bttFixct.Enabled = true;
            bttDelct.Enabled = true;
            txtMaNhap.Enabled = true;
            bttSave.Enabled = true;
            grdHDN.CurrentCell = grdHDN[0, grdHDN.RowCount - 1];
            

            NapCT();
            txtMaNhap.Focus();
            AddNewFlag = true;
        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaNhap.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtSlg.Text))
            {

                return false;
            }
            return true;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                if (check())
                {
                    sql = "insert into hoadonnhap values('" + txtMaNhap.Text
                         + "',N'" + txtTenNCC.SelectedValue.ToString()
                         + "',N'" + txtMaNV.Text
                         + "','" + txtDate.Value.ToShortDateString()
                         + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();




                    foreach (DataRow dr in CTHD.Rows)
                    {
                        sql3 = "insert into hoadonnhapchitiet values(N'" + txtMaNhap.Text
                            + "',N'" + dr[0].ToString()
                            + "',N'" + dr[2].ToString()
                            + "','"  + dr[3].ToString()
                            + "','" + dr[4].ToString()
                            + "','" + dr[5].ToString()
                            + "','" + dr[6].ToString() + "')";
                        cmd1 = new SqlCommand(sql3, conn);
                        cmd1.ExecuteNonQuery();
                    }

                    CTHD.Clear();
                    sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc order by MaNhap";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear();
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
                    grdHDN.Refresh();
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
                sql3 = "update hoadonnhap set ngayct='" + txtDate.Value.ToShortDateString()
                    + "',MaNCC=N'" + txtTenNCC.SelectedValue.ToString()
                    + "',MaNV=N'" + txtMaNV.Text
                    + "'where manhap=N'" + txtMaNhap.Text + "' ";
                cmd = new SqlCommand(sql3, conn);
                cmd.ExecuteNonQuery();

                

                foreach (DataRow dr in CTHD.Rows)
                {
                    sql3 = "insert into hoadonnhapchitiet values(N'" + txtMaNhap.Text
                            + "',N'" + dr[0].ToString()
                            + "',N'" + dr[2].ToString()
                            + "','" + dr[3].ToString()
                            + "','" + dr[4].ToString()
                            + "','" + dr[5].ToString()
                            + "','" + dr[6].ToString() + "')";
                    cmd1 = new SqlCommand(sql3, conn);
                    cmd1.ExecuteNonQuery();
                }


                /*CTHD.Clear();*/
                sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc order by MaNhap";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
                grdHDN.Refresh();
                grdCTN.Refresh();
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttAddct.Enabled = false;
                bttFixct.Enabled = false;
                bttDelct.Enabled = false;
                bttSave.Enabled = false;
            }
        }

        private void bttUpd_Click(object sender, EventArgs e)
        {
            bttAddct.Enabled = true;
            bttFixct.Enabled = true;
            bttDelct.Enabled = true;
            bttSave.Enabled = true;       
            NapCT();
            txtMaNV.Focus();

 
        }

        private void bttAddct_Click(object sender, EventArgs e)
        {
            double ThanhTien = float.Parse(txtDGnhap.Text) * int.Parse(txtSlg.Text);
            tongtien = tongtien + ThanhTien;
            txtTtien.Text = tongtien.ToString();
            
            CTHD.Rows.Add(txtTenHH.SelectedValue.ToString(), txtTenHH.Text, txtDvt.Text,txtHSD.Text, int.Parse(txtSlg.Text), float.Parse(txtDGnhap.Text), ThanhTien);
            grdCTN.DataSource = CTHD;
            
            


        }

        private void bttFixct_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = grdCTN.Rows[dong];
            newRow.Cells[0].Value = txtTenHH.SelectedValue.ToString();
            newRow.Cells[1].Value = txtTenHH.Text;
            newRow.Cells[2].Value = txtDvt.Text;
            newRow.Cells[3].Value = txtHSD.Text;
            newRow.Cells[4].Value = txtSlg.Text;
            newRow.Cells[5].Value = txtDGnhap.Text;
            newRow.Cells[6].Value = int.Parse(txtSlg.Text) * float.Parse(txtDGnhap.Text);


            int g = 0;
            double tt = 0;
            for (g = 0; g < grdCTN.RowCount - 1; g++)
            {
                tt = tt + Convert.ToDouble(grdCTN[6, g].Value.ToString());
            }
            txtTtien.Text = Convert.ToString(tt);

            sql3 = "update hoadonnhapchitiet set SoLuong='" + txtSlg.Text
                    + "',ThanhTien='" + (int.Parse(txtSlg.Text) * float.Parse(txtDGnhap.Text))
                    + "',HanSD='"+txtHSD.Text+"'where manhap='" + txtMaNhap.Text + "' and MaHH='" + txtTenHH.SelectedValue.ToString() + "'";
            cmd = new SqlCommand(sql3, conn);
            cmd.ExecuteNonQuery();
        }

        private void bttDelct_Click(object sender, EventArgs e)
        {
            double tt;
            tt = Convert.ToDouble(txtTtien.Text) - Convert.ToDouble(grdCTN[6, dong].Value.ToString());
            txtTtien.Text = Convert.ToString(tt);

            grdCTN.Rows.RemoveAt(dong);

            sql = "Delete from HoaDonNhapChiTiet where MaNhap='" + txtMaNhap.Text + "' and MaHH='" + txtTenHH.SelectedValue.ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
            cmd2.ExecuteNonQuery();
        }

        private void txtTenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection("Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True");
             sql = "Select*from hanghoa where tenhh=N'" + txtTenHH.Text + "'";
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
                    float dg = rd.GetFloat(4);
                     txtDGnhap.Text = dg.ToString();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
            

        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "Delete from HoaDonNhapChiTiet where MaNhap='" + txtMaNhap.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd1.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

                sql = "Delete from HoaDonNhap where MaNhap='" + txtMaNhap.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd2.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

                grdHDN.Rows.RemoveAt(grdHDN.CurrentRow.Index);// xóa bản ghi hiện thời 

                CTHD.Clear();
                sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc order by MaNhap";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
                grdHDN.Refresh();
            }
            else
            {
                MessageBox.Show("Không xóa bản ghi", "Xác nhận yêu cầu",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdCTN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCTHD();
        }

        private void cbGtri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtHSD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttIn_Click(object sender, EventArgs e)
        {
            sql = "select HangHoa.TenHH,hoadonnhapchitiet.Dvt,hoadonnhapchitiet.SoLuong,hoadonnhapchitiet.DGnhap From hoadonnhapchitiet,HangHoa Where HoaDonNhapChiTiet.MaHH = HangHoa.MaHH and MaNhap ='" + txtMaNhap.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dtrp.Clear();
            da.Fill(dtrp);
            rptHDN rpt = new rptHDN();
            rpt.SetDataSource(dtrp);
            rpt.DataDefinition.FormulaFields["MaNhap"].Text = "'" + txtMaNhap.Text + "'";
            rpt.DataDefinition.FormulaFields["TenNCC"].Text = "'" + txtTenNCC.Text + "'";
            rpt.DataDefinition.FormulaFields["MaNV"].Text = "'" + txtMaNV.Text + "'";

            rptHDNpre f = new rptHDNpre(rpt);
            f.Show();
        }

        private void HDN1_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "SELECT hoadonnhap.manhap, hoadonnhap.manv, nhacungcap.tenncc, hoadonnhap.ngayct FROM hoadonnhap INNER JOIN nhacungcap ON hoadonnhap.mancc = nhacungcap.mancc order by MaNhap";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdHDN.DataSource = dt;// khai báo nguông  dữ liệu
            grdHDN.Refresh();

            sql = "select * from NhanVien ";
            da = new SqlDataAdapter(sql, conn);
            dtcom2.Clear();
            da.Fill(dtcom2);
            txtMaNV.DataSource = dtcom2;
            txtMaNV.DisplayMember = "MaNV";// chỉ ra tên trường muốn hiện thị 8


            sql = "select * from nhacungcap ";
            da = new SqlDataAdapter(sql, conn);
            dtcom3.Clear();
            da.Fill(dtcom3);
            txtTenNCC.DataSource = dtcom3;
            txtTenNCC.DisplayMember = "TenNCC";// chỉ ra tên trường muốn hiện thị 8
            txtTenNCC.ValueMember = "MaNCC";

            sql = "select * from hanghoa";
            da = new SqlDataAdapter(sql, conn);
            dtcom4.Clear();
            da.Fill(dtcom4);
            txtTenHH.DataSource = dtcom4;
            txtTenHH.DisplayMember = "TenHH";// chỉ ra tên trường muốn hiện thị 8
            txtTenHH.ValueMember = "MaHH";

            CTHD.Columns.Add("Mã Thuốc", typeof(string));
            CTHD.Columns.Add("Tên Thuốc", typeof(string));
            CTHD.Columns.Add("Đơn vị", typeof(string));
            CTHD.Columns.Add("HSD", typeof(string));
            CTHD.Columns.Add("Số lượng", typeof(int));
            CTHD.Columns.Add("Đơn giá", typeof(float));
            CTHD.Columns.Add("Thành tiền", typeof(double));
            grdCTN.DataSource = CTHD;

            NapCT();


            txtTtien.Text = "0";
        }
            public void NapCT()
        {
            i = grdHDN.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaNhap.Text = grdHDN[0, i].Value.ToString();
            txtMaNV.Text = grdHDN[1, i].Value.ToString();
            txtTenNCC.Text = grdHDN[2, i].Value.ToString();
            txtDate.Text = grdHDN[3, i].Value.ToString();

        }
        public void NapCTHD()
        {
            dong = grdCTN.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtTenHH.Text = grdCTN[1, dong].Value.ToString();
            txtDvt.Text = grdCTN[2, dong].Value.ToString();
            txtHSD.Text = grdCTN[3, dong].Value.ToString();
            txtSlg.Text = grdCTN[4, dong].Value.ToString();
            txtDGnhap.Text = grdCTN[5, dong].Value.ToString();

            int g = 0;
            double tt = 0;
            for (g = 0; g < grdCTN.RowCount - 1; g++)
            {
                tt = tt + Convert.ToDouble(grdCTN[6, g].Value.ToString());
            }
            txtTtien.Text = Convert.ToString(tt);

        }
    }
}
