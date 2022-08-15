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
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        DataTable dtrp = new DataTable();
        SqlCommand cmd;
        string tTenHH, tDvt, tDGnhap, tDGxuat, tSanXuat,tLTon;
        string sql, connstr;
        Boolean AddNewFlag = false;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void grbThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời ?","Xác nhận yêu cầu",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                sql = "delete from HangHoa where HangHoa.MaHH = '" + txtMaHH.Text + "'";
                grdDMHH.Rows.RemoveAt(grdDMHH.CurrentRow.Index);//xóa dòng hiện thời của ô lưới
                SqlCommand cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtTenHH.Focus();// khi bấm sửa trỏ đến tên hàng hóa trong các dãy ô bên phải
            AddNewFlag = false;
            bttSave.Enabled = true;

            grdDMHH.Enabled = true;
            grdDMHH.Focus();//khi bấm sửa mới trỏ được vào trong các dòng của cột 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblhh_Click(object sender, EventArgs e)
        {

        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "Select * from HangHoa order by MaHH";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdDMHH.DataSource = dt;// khai báo nguông  dữ liệu
            grdDMHH.Refresh();


            sql = "select * from NhomHangHoa";
            da = new SqlDataAdapter(sql, conn);
            dtcom.Clear();
            da.Fill(dtcom);
            txtMaNhom.DataSource = dtcom;
            txtMaNhom.DisplayMember = "MaNhom";// chỉ ra tên trường muốn hiện thị 
            NapCT();

        }
        public void NapCT()
        {
            i = grdDMHH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaNhom.Text = grdDMHH[0, i].Value.ToString();
            txtMaHH.Text = grdDMHH[1, i].Value.ToString();
            txtTenHH.Text = grdDMHH[2, i].Value.ToString();
            txtDvt.Text = grdDMHH[3, i].Value.ToString();
            txtGnhap.Text = grdDMHH[4, i].Value.ToString();
            txtGxuat.Text = grdDMHH[5, i].Value.ToString();
            txtSanXuat.Text = grdDMHH[6, i].Value.ToString();
            txtLTon.Text = grdDMHH[7, i].Value.ToString();

        }

        private void grdDMHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void bttFist_Click(object sender, EventArgs e)
        {
            grdDMHH.CurrentCell = grdDMHH[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            
            grdDMHH.CurrentCell = grdDMHH[0, grdDMHH.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaNhom.Focus();
            bttSave.Enabled = true;


        }

        private void frmDMHH_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select distinct " + cbTruong.Text+ " From HangHoa";
            da = new SqlDataAdapter(sql, conn);
            dtcom.Clear();
            da.Fill(dtcom);
            cbGtri.DataSource = dtcom;
            cbGtri.DisplayMember = cbTruong.Text;

        }

        private void bttFil_Click(object sender, EventArgs e)
        {
            sql = "Select * from HangHoa where " + cbTruong.Text + "=N'" + cbGtri.Text + "' order by MaHH";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdDMHH.DataSource = dt;// khai báo nguông  dữ liệu
            grdDMHH.Refresh();
            NapCT();
        }

        private void txtMaNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttRe_Click(object sender, EventArgs e)
        {
            sql = "Select * from HangHoa order by MaHH";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdDMHH.DataSource = dt;// khai báo nguông  dữ liệu
            grdDMHH.Refresh();
            NapCT();
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            i = grdDMHH.CurrentRow.Index;
            if(i>0)
            {
                grdDMHH.CurrentCell= grdDMHH[0, i - 1];
                NapCT();

            }

        }

        private void cbGtri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnInnhom_Click(object sender, EventArgs e)
        {
            if (cbTruong.Text == "MaNhom")
            {
                sql = "select MaHH,TenHH,Dvt,DGnhap,DGxuat,SanXuat From HangHoa Where MaNhom='" + cbGtri.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dtrp.Clear();
                da.Fill(dtrp);
                rpNHH rpt = new rpNHH();
                rpt.SetDataSource(dtrp);
                rpt.DataDefinition.FormulaFields["NhomHang"].Text = "'" + cbGtri.Text + "'";
                rprInNHHpre f = new rprInNHHpre(rpt);
                f.Show();
            }
            else
                MessageBox.Show("Bạn cần thực hiện lọc hàng hóa theo nhóm trước khi in báo cáo");
        }

        private void InNHH_Click(object sender, EventArgs e)
        {
          
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            i = grdDMHH.CurrentRow.Index;
            if (i < grdDMHH.RowCount-1)
            {
                grdDMHH.CurrentCell = grdDMHH[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

            }
        }


        private void bttLast_Click(object sender, EventArgs e)
        {
            grdDMHH.CurrentCell = grdDMHH[0, grdDMHH.RowCount-1];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text))
            {
            
                return false;
            }
            if (string.IsNullOrEmpty(txtMaHH.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtTenHH.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtDvt.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtGnhap.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtGxuat.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtSanXuat.Text))
            {

                return false;
            }
            return true;
        }
        private void bttSave_Click(object sender, EventArgs e)
        {
            if(AddNewFlag)
            {
                //thêm mới 
                if (check())
                {
                    sql = "insert into HangHoa (MaNhom,MaHH,TenHH,Dvt,DGnhap,DGxuat,SanXuat,LuongTon) Values('" + txtMaNhom.Text + "','" + txtMaHH.Text + "',N'" + txtTenHH.Text + "',N'" + txtDvt.Text + "','"
                      + txtGnhap.Text + "','" + txtGxuat.Text + "',N'" + txtSanXuat.Text + "','" + txtLTon.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm mới thành công!", "Thông báo");
                    AddNewFlag = false;
                    bttSave.Enabled = false;
                    i = grdDMHH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
                    grdDMHH[0, i].Value = txtMaNhom.Text;
                    grdDMHH[1, i].Value = txtMaHH.Text;
                    grdDMHH[2, i].Value = txtTenHH.Text;
                    grdDMHH[3, i].Value = txtDvt.Text;
                    grdDMHH[4, i].Value = txtGnhap.Text;
                    grdDMHH[5, i].Value = txtGxuat.Text;
                    grdDMHH[6, i].Value = txtSanXuat.Text;
                    grdDMHH[7, i].Value = txtLTon.Text;


                    sql = "Select * from HangHoa order by MaHH";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdDMHH.DataSource = dt;// khai báo nguông  dữ liệu
                    grdDMHH.Refresh();
                    NapCT();
                }
                else
                {
                    MessageBox.Show("Bạn đang nhập thiếu thông tin!", "Thông báo");
                }

            }
            else
            {
                //cập nhật sửa chữa
                /*sql="Update HangHoa set TenHH=N'" + txtTenHH.Text + "', Dvt=N'"+txtDvt.Text+"',DGnhap='"+txtGnhap.Text+"',DGxuat='"
                    +txtGxuat.Text+ "', SanXuat=N'" + txtSanXuat.Text + "'where MaHH='" + txtMaHH.Text + "'";
                cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttSave.Enabled = false;
                sql = "Select * from HangHoa order by MaHH";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdDMHH.DataSource = dt;// khai báo nguông  dữ liệu
                grdDMHH.Refresh();
                NapCT();*/
                for (i=0;i<grdDMHH.RowCount-1;i++)
                {
                    tTenHH = grdDMHH[2,i].Value.ToString();
                    tDvt = grdDMHH[3, i].Value.ToString();
                    tDGnhap = grdDMHH[4, i].Value.ToString();
                    tDGxuat = grdDMHH[5, i].Value.ToString();
                    tSanXuat = grdDMHH[6, i].Value.ToString();
                    tLTon = grdDMHH[7, i].Value.ToString();

                    sql = "Update HangHoa set TenHH=N'" + tTenHH + "', Dvt=N'" + tDvt + "',DGnhap='" + tDGnhap + "',DGxuat='"
                        + tDGxuat + "', SanXuat=N'" + tSanXuat + "',LuongTon='" + tLTon + "'where MaHH='" + grdDMHH[1, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttSave.Enabled = false;
                grdDMHH.Enabled = false;//sau khi cập nhật thì khó bảng để không trỏ vào được nữa

            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
