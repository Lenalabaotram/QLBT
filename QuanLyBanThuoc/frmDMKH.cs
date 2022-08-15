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
    public partial class frmDMKH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        SqlCommand cmd;
        string tMaKH, tTenKH, tDiaChi, tSdt, tEmail;
        string sql, connstr;
        Boolean AddNewFlag = false;
        int i;
        public frmDMKH()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDMKH_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "Select * from KhachHang order by MaKH";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdKH.DataSource = dt;// khai báo nguồn  dữ liệu
            grdKH.Refresh();
            NapCT();

        }
        public void NapCT()
        {
            i = grdKH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaKH.Text = grdKH[0, i].Value.ToString();
            txtTenKH.Text = grdKH[1, i].Value.ToString();
            txtDiaChi.Text = grdKH[2, i].Value.ToString();
            txtSdt.Text = grdKH[3, i].Value.ToString();
            txtEmail.Text = grdKH[4, i].Value.ToString();

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttFirst_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            i = grdKH.CurrentRow.Index;
            if (i > 0)
            {
                grdKH.CurrentCell = grdKH[0, i - 1];
                NapCT();

            }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            i = grdKH.CurrentRow.Index;
            if (i < grdKH.RowCount - 1)
            {
                grdKH.CurrentCell = grdKH[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, grdKH.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaKH.Focus();
            bttSave.Enabled = true;
        }

        private void cbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo");
            }
            else
            {
                sql = "Select * from KhachHang where TenKH like N'%" + txtFind.Text + "%' or Sdt like N'%" + txtFind.Text + "%'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdKH.DataSource = dt;// khai báo nguông  dữ liệu
                grdKH.Refresh();
            }
        }

        private void bttRe_Click(object sender, EventArgs e)
        {
            sql = "Select * from KhachHang order by MaKH";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdKH.DataSource = dt;// khai báo nguông  dữ liệu
            grdKH.Refresh();
            NapCT();
        }

        private void bttLast_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, grdKH.RowCount - 1];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời ?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from KhachHang where MaKH='" + txtMaKH.Text + "'";
                grdKH.Rows.RemoveAt(grdKH.CurrentRow.Index);//xóa dòng hiện thời của ô lưới
                SqlCommand cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

            }
        }

        private void bttFix_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();// khi bấm sửa trỏ đến tên hàng hóa trong các dãy ô bên phải
            AddNewFlag = false;
            bttSave.Enabled = true;

            grdKH.Enabled = true;
            grdKH.Focus();
        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtSdt.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {

                return false;
            }
            return true;
        }
        private void bttSave_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                //thêm mới
                if (check())
                {
                    sql = "insert into KhachHang (MaKH,TenKH,DiaChi,Sdt,Email) Values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "','" + txtSdt.Text + "','"
                        + txtEmail.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm mới thành công!", "Thông báo");
                    AddNewFlag = false;
                    bttSave.Enabled = false;
                    i = grdKH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
                    grdKH[0, i].Value = txtMaKH.Text;
                    grdKH[1, i].Value = txtTenKH.Text;
                    grdKH[2, i].Value = txtDiaChi.Text;
                    grdKH[3, i].Value = txtSdt.Text;
                    grdKH[4, i].Value = txtEmail.Text;

                    sql = "Select * from KhachHang order by MaKH";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdKH.DataSource = dt;// khai báo nguông  dữ liệu
                    grdKH.Refresh();
                    NapCT();
                }
                else
                {
                    MessageBox.Show("Bạn đang nhập thiếu thông tin !", "Thông báo");
                }

            }
            else
            {
                // sửa 
                for (i = 0; i < grdKH.RowCount - 1; i++)
                {
                    tMaKH = grdKH[0, i].Value.ToString();
                    tTenKH = grdKH[1, i].Value.ToString();
                    tDiaChi = grdKH[2, i].Value.ToString();
                    tSdt = grdKH[3, i].Value.ToString();
                    tEmail = grdKH[4, i].Value.ToString();
                    sql = "Update KhachHang set MaKH=N'" + tMaKH + "', TenKH=N'" + tTenKH + "',DiaChi=N'" + tDiaChi + "',Sdt='"
                        + tSdt + "', Email=N'" + tEmail + "'where MaKH='" + grdKH[0, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttSave.Enabled = false;
                grdKH.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
    }
}
