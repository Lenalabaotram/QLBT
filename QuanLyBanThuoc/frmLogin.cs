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

    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        SqlCommand cmd;
        string sql, connstr;
        int i;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
            i = 0;
        }
        
        private void bttLog_Click(object sender, EventArgs e)
        {
            if (i <= 3)
            {
                sql = "select Username,Password from Account where Username='" + txtUser.Text + "' and Password='" + txtPass.Text + "'";
                da = new SqlDataAdapter(sql, conn);// thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    
                    frmMain f = new frmMain();
                    f.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    i++;
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            else
            { Application.Exit(); }
            
            
            

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
