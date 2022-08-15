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
    public partial class frmDMNCC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        SqlCommand cmd;
        SqlCommand cmd1;
        string  tTenNCC, tDiaChi, tSdt, tEmail;
        string sql, connstr;
        Boolean AddNewFlag = false;
        int i;

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttFirst_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            i = grdNCC.CurrentRow.Index;
            if (i > 0)
            {
                grdNCC.CurrentCell = grdNCC[0, i - 1];
                NapCT();

            }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            i = grdNCC.CurrentRow.Index;
            if (i < grdNCC.RowCount - 1)
            {
                grdNCC.CurrentCell = grdNCC[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

            }
        }

        private void bttLast_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, grdNCC.RowCount - 1];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
        }

        private void bttFix_Click(object sender, EventArgs e)
        {
            txtMaNCC.Focus();// khi bấm sửa trỏ đến tên hàng hóa trong các dãy ô bên phải
            AddNewFlag = false;
            bttSave.Enabled = true;

            grdNCC.Enabled = true;
            grdNCC.Focus();
        }
        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {

                return false;
            }
            if (string.IsNullOrEmpty(txtTenNCC.Text))
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
            if(AddNewFlag)
            {
                // thêm mới
                if (check())
                {
                    sql = "insert into NhaCungCap (MaNCC,TenNCC,DiaChi,Sdt,Email) Values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "','" + txtSdt.Text + "','"
                     + txtEmail.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm mới thành công!", "Thông báo");
                    AddNewFlag = false;
                    bttSave.Enabled = false;
                    i = grdNCC.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
                    grdNCC[0, i].Value = txtMaNCC.Text;
                    grdNCC[1, i].Value = txtTenNCC.Text;
                    grdNCC[2, i].Value = txtDiaChi.Text;
                    grdNCC[3, i].Value = txtSdt.Text;
                    grdNCC[4, i].Value = txtEmail.Text;

                    sql = "Select * from NhaCungCap order by MaNCC";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdNCC.DataSource = dt;// khai báo nguông  dữ liệu
                    grdNCC.Refresh();
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
                for (i = 0; i < grdNCC.RowCount - 1; i++)
                {
                    
                    tTenNCC = grdNCC[1, i].Value.ToString();
                    tDiaChi = grdNCC[2, i].Value.ToString();
                    tSdt = grdNCC[3, i].Value.ToString();
                    tEmail = grdNCC[4, i].Value.ToString();
                    sql = "Update nhacungcap set TenNCC=N'" + tTenNCC + "',DiaChi=N'" + tDiaChi + "',Sdt='"
                        + tSdt + "', Email=N'" + tEmail + "'where MaNCC='" + grdNCC[0, i].Value.ToString() + "'";
                    cmd1 = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                    cmd1.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                bttSave.Enabled = false;
                grdNCC.Enabled = false;
            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, grdNCC.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaNCC.Focus();
            bttSave.Enabled = true;
        }

        private void bttFind_Click(object sender, EventArgs e)
        {
            string value = txtFind.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo");
            }
            else
            {
                sql = "Select * from NhaCungCap where MaNCC like N'%" + txtFind.Text + "%' or Sdt like N'%" + txtFind.Text + "%' or TenNCC like N'%" + txtFind.Text + "%'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdNCC.DataSource = dt;// khai báo nguông  dữ liệu
                grdNCC.Refresh();
            }
        }

        private void bttRe_Click(object sender, EventArgs e)
        {
            sql = "Select * from NhaCungCap order by MaNCC";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdNCC.DataSource = dt;// khai báo nguông  dữ liệu
            grdNCC.Refresh();
            NapCT();
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời ?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from NhaCungCap where MaNCC='" + txtMaNCC.Text + "'";
                grdNCC.Rows.RemoveAt(grdNCC.CurrentRow.Index);//xóa dòng hiện thời của ô lưới
                SqlCommand cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

            }
        }

        

        private void frmDMNCC_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "Select * from NhaCungCap";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdNCC.DataSource = dt;// khai báo nguồn  dữ liệu
            grdNCC.Refresh();
            NapCT();
        }
        public void NapCT()
        {
            i = grdNCC.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaNCC.Text = grdNCC[0, i].Value.ToString();
            txtTenNCC.Text = grdNCC[1, i].Value.ToString();
            txtDiaChi.Text = grdNCC[2, i].Value.ToString();
            txtSdt.Text = grdNCC[3, i].Value.ToString();
            txtEmail.Text = grdNCC[4, i].Value.ToString();

        }

        
        public frmDMNCC()
        {
            InitializeComponent();
        }

        private void grdNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
    }
}
