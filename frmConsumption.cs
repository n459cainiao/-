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
    public partial class frmConsumption : Form
    {
        public frmConsumption()
        {
            InitializeComponent();
        }
        public string con_id
        {
            get;
            set;
        }

        private void FrmConsumption_Load(object sender, EventArgs e)
        {
            lblId.Text = con_id ;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = listView1.Width / 3;
            }
            using (SqlConnection conn=new SqlConnection(DBHelper.connString))
            {
                conn.Open();
                string sqlstr1 = "select * from consumption where con_id='"+con_id+"'";
                SqlCommand cmd=new SqlCommand(sqlstr1,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    lblNum.Text= reader["con_num"].ToString();
                    lblstate.Text= reader["con_state"].ToString();
                    lblTime.Text= reader["con_time"].ToString();
                    lblWaiter.Text= reader["waiterId"].ToString();
                    lblTable.Text= reader["con_table"].ToString();
                }
                reader.Close();
                string sqlstr2 = "select * from con_food where con_id='" + con_id + "'";
                cmd = new SqlCommand(sqlstr2, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = reader["con_foodName"].ToString();
                    items.SubItems.Add(reader["foodSum"].ToString());
                    items.SubItems.Add(reader["con_foodPrice"].ToString());
                    listView1.Items.Add(items);

                }
            }
        }
    }
    
}
