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
    public partial class frmNHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        DataTable dtrp = new DataTable();
        SqlCommand cmd;
        string sql, connstr;
        string tMaNhom, tTenNhom;
        Boolean AddNewFlag = false;
        int i;
        public frmNHH()
        {
            InitializeComponent();
        }

        private void frmNHH_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();// mở kết nối với csdl
            sql = "Select * from NhomHangHoa";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdNHH.DataSource = dt;// khai báo nguông  dữ liệu
            grdNHH.Refresh();
            NapCT();
        }
        public void NapCT()
        {
            i = grdNHH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
            txtMaNhom.Text = grdNHH[0, i].Value.ToString();
            txtTenNhom.Text = grdNHH[1, i].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMaNhom.Focus();// khi bấm sửa trỏ đến tên hàng hóa trong các dãy ô bên phải
            AddNewFlag = false;
            bttSave.Enabled = true;

            grdNHH.Enabled = true;
            grdNHH.Focus();//khi bấm sửa mới trỏ được vào trong các dòng của cột 
        }

        private void bttFirst_Click(object sender, EventArgs e)
        {
            grdNHH.CurrentCell = grdNHH[0, 0];//ô hiện thời chuyển về cột o dòng o 
            NapCT();
        }

        private void bttPre_Click(object sender, EventArgs e)
        {
            i = grdNHH.CurrentRow.Index;
            if (i > 0)
            {
                grdNHH.CurrentCell = grdNHH[0, i - 1];
                NapCT();

            }
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            i = grdNHH.CurrentRow.Index;
            if (i < grdNHH.RowCount - 1)
            {
                grdNHH.CurrentCell = grdNHH[0, i + 1];//ô hiện thời chuyển về vị trí cột 0 dòng i+1
                NapCT();

            }
        }

        private void bttLast_Click(object sender, EventArgs e)
        {
            grdNHH.CurrentCell = grdNHH[0, grdNHH.RowCount - 1];//ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời ?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from NhomHangHoa where MaNhom='" + txtMaNhom.Text + "'";
                grdNHH.Rows.RemoveAt(grdNHH.CurrentRow.Index);//xóa dòng hiện thời của ô lưới
                SqlCommand cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery(); // thực hiện câu lệnh không phải select

            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            grdNHH.CurrentCell = grdNHH[0, grdNHH.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaNhom.Focus();
            bttSave.Enabled = true;
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
                sql = "Select * from NhomHangHoa where MaNhom like N'%" + txtFind.Text + "%' or TenNhom like N'%" + txtFind.Text + "%'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                grdNHH.DataSource = dt;// khai báo nguông  dữ liệu
                grdNHH.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "Select * from NhomHangHoa";
            da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
            dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
            grdNHH.DataSource = dt;// khai báo nguông  dữ liệu
            grdNHH.Refresh();
            NapCT();
        }

        public bool check()
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text))
            {
                
                return false;
            }
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {
               
                return false;
            }
            return true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            sql = "select MaNhom,TenHH,DGxuat,SanXuat From HangHoa ";
            da = new SqlDataAdapter(sql, conn);
            dtrp.Clear();
            da.Fill(dtrp);
            rptTongHopNHH rpt = new rptTongHopNHH();
            rpt.SetDataSource(dtrp);
            rptTongHopNHHpre f = new rptTongHopNHHpre(rpt);
            f.Show();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if(AddNewFlag)
            {
                //thêm mới
                if (check())
                { sql = "insert into NhomHangHoa (MaNhom,TenNhom) Values('" + txtMaNhom.Text + "',N'" + txtTenNhom.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm mới thành công!", "Thông báo");
                    AddNewFlag = false;
                    bttSave.Enabled = false;
                    i = grdNHH.CurrentRow.Index;//lấy số thứ tự dòng hỉện thời trong ô lưới
                    grdNHH[0, i].Value = txtMaNhom.Text;
                    grdNHH[1, i].Value = txtTenNhom.Text;


                    sql = "Select * from NhomHangHoa";
                    da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                    dt.Clear(); // thêm clear dể tránh dữ liệu bị iin ra hai lần 
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt 
                    grdNHH.DataSource = dt;// khai báo nguông  dữ liệu
                    grdNHH.Refresh();
                    NapCT();
                }
                else
                {
                    MessageBox.Show("Bạn đang nhập thiếu thông tin!", "Thông báo");
                }
                
            }
            else
            {
                //cập nhật 
                for (i = 0; i < grdNHH.RowCount - 1; i++)
                    {
                        tMaNhom = grdNHH[0, i].Value.ToString();
                        tTenNhom = grdNHH[1, i].Value.ToString();

                        sql = "Update NhomHangHoa set MaNhom=N'" + tMaNhom + "', TenNhom=N'" + tTenNhom + "'where MaNhom='" + grdNHH[0, i].Value.ToString() + "'";
                        cmd = new SqlCommand(sql, conn);//khai báo một câu lệnh sql chuẩn bị thực hiện 
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                    bttSave.Enabled = false;
                    grdNHH.Enabled = false;//sau khi cập nhật thì khó bảng để không trỏ vào được nữa
             }
        }

        private void grdNHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        
    }
}
