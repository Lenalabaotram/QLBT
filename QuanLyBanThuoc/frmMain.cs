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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void frmQL_Load(object sender, EventArgs e)
        {
            /*stt1.Text = "Đăng nhập";
            frmLogin f = new frmLogin();
            f.ShowDialog();
            stt1.Text = "Ready";*/

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDMHH_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục hàng hóa";
            frmDMHH f = new frmDMHH();
            f.ShowDialog();
            stt1.Text = "Ready";

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            
        }

        private void mnuDMKH_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục khách hàng ";
            frmDMKH f = new frmDMKH();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void mnuHDBL_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý hóa đơn bán ";
            frmHDX f = new frmHDX();
            f.Show();

        }

        private void mnuHDNM_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý hóa đơn nhập ";
            HDN1 f = new HDN1();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void mnuNCC_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục nhà cung cấp ";
            frmDMNCC f = new frmDMNCC();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void mnuNhomhh_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục nhóm hàng hóa ";
            frmNHH f = new frmNHH();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void toolKH_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục khách hàng ";
            frmDMKH f = new frmDMKH();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void bttLog_Click(object sender, EventArgs e)
        {
            
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý hóa đơn bán ";
            frmHDX f = new frmHDX();
            f.Show();
            stt1.Text = "Ready";
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            stt1.Text = "Quản lý danh mục nhà cung cấp ";
            frmDMNCC f = new frmDMNCC();
            f.ShowDialog();
            stt1.Text = "Ready";
        }

        private void mnuTK_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InRPtonghop f = new InRPtonghop();
            f.ShowDialog();
        }
    }
}
