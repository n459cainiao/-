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
    public partial class frmOpen : Form
    {
        SqlConnection conn;
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
       public  DataTable dt = new DataTable();
        public String roomnum;
        public String connum;
        public String waitername;
        public String state;
        public frmOpen()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
         
            DataRow rw = dt.NewRow();
            rw["roomnum"] = TxtRnum.Text;
            rw["date"] = TxtDate.Text;
            rw["cname"] = TxtCname.Text;
            rw["unum"] = TxtUnum.Text;
            rw["wname"] = TxtWname.Text;
            rw["add"] = TxtAdd.Text;
            dt.Rows.Add(rw);
            connum = TxtUnum.Text;
            state = "进行中";
            if (TxtUnum.Text.Length ==0)
            {
                MessageBox.Show("请填写用餐人数！");
            }
            else
            {
                if (TxtWname.Text.Length ==0)
                {
                    MessageBox.Show("服务员姓名不能为空！");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update [table] set tableState='占用' where tableId=" +Convert.ToInt32(roomnum.Trim()) + "", conn);
                    cmd.ExecuteNonQuery();
                    waitername = TxtWname.Text;
                    MessageBox.Show("开始选菜");
                    frmOrder order = new frmOrder(this);
                    order.ShowDialog();
                }
               
            }
         
        }
       
        private void FrmOpen_Load(object sender, EventArgs e)
        {
            string num = this.Text;
            string wname = DBHelper.userId;
            conn = new SqlConnection(DBHelper.connString);
            conn.Open();
            string sqlstr = "select userName from staff where userId='" + DBHelper.userId.Trim() + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlstr, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                wname = sqlDataReader["userName"].ToString().Trim();
            }
            TxtWname.Text = wname;
            TxtRnum.Text = System.Text.RegularExpressions.Regex.Replace(num, @"[^0-9]+", "");
            roomnum = TxtRnum.Text;
            TxtDate.Text = System.DateTime.Now.ToString();
            dt.Columns.Add("roomnum", typeof(string));
            dt.Columns.Add("date", typeof(string));
            dt.Columns.Add("cname", typeof(string));
            dt.Columns.Add("unum", typeof(string));
            dt.Columns.Add("wname", typeof(string));
            dt.Columns.Add("add", typeof(string));
        }

    }
}
