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
    public partial class frmCheckout : Form
    {
        SqlConnection conn;
        SqlCommand cmmd;
     
        SqlDataAdapter adap;
        DataSet ds;
        public frmCheckout()
        {
             InitializeComponent();
        }

        String roomnum;
        int c;
     
        private void FrmCheckout_Load(object sender, EventArgs e)
        {
           roomnum=System.Text.RegularExpressions.Regex.Replace(lblroom.Text, @"[^0-9]+", "");
            c = Convert.ToInt32(roomnum.Trim());
            string cid = frmWaiter.OrderNum.conid[c];
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
          conn =  new SqlConnection(DBHelper.connString);
            conn.Open();
            try { 
                String sqlstr = "select con_foodName,con_foodPrice,foodsum,con_foodTprice from con_food where con_id='" + cid + "'";
                adap = new SqlDataAdapter(sqlstr, conn);
                ds = new DataSet();
                adap.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                String strsql = "select con_num,con_time,waiterId from consumption where con_id='" + cid.Trim() + "'";
                cmmd = new SqlCommand(strsql, conn);
                SqlDataReader sqldr = cmmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                       sqldr.Read();
                       rtxtxf.Text += "消费人数："+"" + sqldr["con_num"] + "\n" +
                           "消费时间："+ "" + sqldr["con_time"] + "\n" +
                            "服务员ID："+"" + sqldr["waiterId"] + "\n";
                    double sum = 0;
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {
                   
                sum = sum+Convert.ToDouble(ds.Tables[0].Rows[i]["con_foodTprice"].ToString());
            }
            lblSum.Text = sum.ToString();
            this.AcceptButton = button3;

                }

            }
            catch
            {
                MessageBox.Show("当前桌未开台");
                this.Dispose();
            }
           
            dgv.Columns[0].HeaderCell.Value = "食物名称";
            dgv.Columns[1].HeaderCell.Value = "食物单价";
            dgv.Columns[2].HeaderCell.Value = "食物数量";
            dgv.Columns[3].HeaderCell.Value = "食物总价";
           
            /*rtxtxf.AppendText("消费人数：\n");
            rtxtxf.AppendText("消费时间：\n");
            rtxtxf.AppendText("服务员ID：\n");*/
            
                
            
            
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          //  lblChange.Text = (Convert.ToInt32(Txtshouyin.Text.Trim()) -Convert.ToInt32(lblSum.Text)).ToString();
            frmWaiter.OrderNum.conid[c] = null;
            SqlCommand cmd = new SqlCommand("update [table] set tableState='空闲' where tableId='" +roomnum+ "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       public void Button3_Click(object sender, EventArgs e)
        {
          lblChange.Text=(Convert.ToInt32(Txtshouyin.Text.Trim()) - Convert.ToInt32(lblSum.Text)).ToString();
        }
    }
}
