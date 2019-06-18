using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 餐饮管理系统
{
    public partial class frmInquire : Form
    {
        SqlDataAdapter adapter;
        DataSet dst;
        SqlConnection conn;
        public frmInquire()
        {
            InitializeComponent();
        }

        private void FrmInquire_Load(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(this.Text.Trim());
            string cid = frmWaiter.OrderNum.conid[c];
            conn = new SqlConnection(DBHelper.connString);
            conn.Open();
            String sqlstr = "select* from consumption where con_id='" + cid.Trim() + "'";
            adapter = new SqlDataAdapter(sqlstr, conn);
            dst = new DataSet();
            adapter.Fill(dst);
            dataGridView1.DataSource = dst.Tables[0];

            }
            catch
            {
                MessageBox.Show("当前桌未开台");
                this.Dispose();
            }
           
        }
    }
}
