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
    public partial class InRPtonghop : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtrp = new DataTable();
        string sql, connstr;
        public InRPtonghop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = Tungay.Value;
            DateTime d2 = Denngay.Value;

            sql = "select hoadonxuat.maxuat,hoadonxuat.makh,hoadonxuatchitiet.soluong,hoadonxuatchitiet.dgxuat from hoadonxuat,hoadonxuatchitiet where hoadonxuat.maxuat=hoadonxuatchitiet.maxuat and ngayct between '"+d1+ "'and '" + d2 + "'order by maxuat";
            da = new SqlDataAdapter(sql, conn);
            dtrp.Clear();
            da.Fill(dtrp);
            rptTongHopHDX rpt = new rptTongHopHDX();
            rpt.SetDataSource(dtrp);
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'"+ d1 +"'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + d2 +"'";
            rptTongHopHDXpre f = new rptTongHopHDXpre(rpt);
            f.Show();
        }

        private void InRPtonghop_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=LAPTOP-2O37QBO3\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
        }
    }
}
