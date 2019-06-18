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
    public partial class frmWaiter : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sda;
        private string photoPass;
        public SqlDataReader sdr;

      
        public frmWaiter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < OrderNum.conid.Length; i++)
            {
                OrderNum.conid[i] = null;
            }
            conn = new SqlConnection(DBHelper.connString);
             ds = new DataSet();
             conn.Open();
            SqlCommand cmd = new SqlCommand("update staff set userState ='忙碌' where userId='"+userId+"'", conn);
            cmd.ExecuteNonQuery();
             Ini();
    }
    private void FrmWaiter_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
         
    }
    public string userId
    {
        get;
        set;
    }
        public void Ini()
        {
            picWaiter.SizeMode = PictureBoxSizeMode.StretchImage;
            picWaiter.BorderStyle = BorderStyle.FixedSingle;
            string sqlstr = "select * from staff where userId='"+ userId + "'";
            sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(sqlstr, conn);
            sda.Fill(ds, "message");
           lblName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
           lblDuty.Text = ds.Tables["message"].Rows[0]["duty"].ToString();
           lblNum.Text = ds.Tables["message"].Rows[0]["idNum"].ToString();
            try
            {
                string s = ds.Tables["message"].Rows[0]["userPhoto"].ToString();
                string path = s.Substring(s.LastIndexOf(@"\餐饮管理系统图片"));
                picWaiter.Image = Image.FromFile(Application.StartupPath + path);
                photoPass = Application.StartupPath + path;
            }
            catch
            {
                picWaiter.Image = Image.FromFile(ds.Tables[0].Rows[0]["userPhoto"].ToString());
                photoPass = ds.Tables[0].Rows[0]["userPhoto"].ToString();
            }

        }

         private void 开台ToolStripMenuItem_Click(object sender, EventArgs e)
          {
            if (lvdesk.SelectedItems.Count != 0)
            {
                name = lvdesk.SelectedItems[0].SubItems[0].Text;
                frmOpen open = new frmOpen();
                open.Text = name + open.Text;
                open.Show();
            }
        }

         /* private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
          {
              frmRoom room=new frmRoom();
              room.Show();
              string roomnum = (sender as ContextMenuStrip).SourceControl.Name;
              room.Text = roomnum+"桌台信息";
          }*/
     string name;

        private void 点加菜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvdesk.SelectedItems.Count != 0)//判断是否有选中项
            {
                 name = lvdesk.SelectedItems[0].SubItems[0].Text;
                frmOrder order = new frmOrder();
                order.Text = name;
                order.Show();
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
          
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlCommand cmd = new SqlCommand("update staff set userState ='空闲' where userId='" + userId + "'", conn);
            cmd.ExecuteNonQuery();
            frmLogin log = new frmLogin();
            log.Show();
            this.Dispose();
       

        }

       
      
           
        
       // public event Action MyEvent = MessageBox.Show("!
        private void 取消开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvdesk.SelectedItems.Count != 0)
            {
                name= lvdesk.SelectedItems[0].SubItems[0].Text;
                conn = new SqlConnection(DBHelper.connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update [table] set tableState='空闲' where tableName='" + name + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                FrmWaiter_Activated(sender, e);
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }



        private void 结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvdesk.SelectedItems.Count != 0)
            {
                name = lvdesk.SelectedItems[0].SubItems[0].Text;       
                frmCheckout checkout = new frmCheckout();
                checkout.lblroom.Text = checkout.lblroom.Text + name;
                checkout.Show();
             
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        
        
        }
       public class OrderNum
        {
            public static string[] conid = new string[20];

        

           
        }

        private void FrmWaiter_Activated(object sender, EventArgs e)
        {
            conn = new SqlConnection(DBHelper.connString);
            conn.Open();
            lvdesk.Items.Clear();
            String str = "select* from [table]";
            SqlCommand cmd = new SqlCommand(str, conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string roomstate = sdr["tableState"].ToString().Trim();
                AddItems(roomstate);
            }
            conn.Close();
        }
        private void AddItems(string rzt)
        {
            if (rzt == "占用")//如果状态是“使用”则添加索引为1的图片
            {
                lvdesk.Items.Add(sdr["tableName"].ToString(), 1);
            }
            else//否则添加索引为0的图片
            {
                lvdesk.Items.Add(sdr["tableName"].ToString(), 0);
            }
        }

        private void Lvdesk_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DBHelper.connString);
            conn.Open();
            string names = lvdesk.SelectedItems[0].SubItems[0].Text;//获取选中桌台的名称
            SqlCommand cmd = new SqlCommand("Select * from [table] where tableName = '"+names+"'", conn);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string zt = sdr["tableState"].ToString().Trim();
            sdr.Close();
            if (zt == "占用")
            {
                this.contextMenuStrip1.Items[0].Enabled = false;
                this.contextMenuStrip1.Items[1].Enabled = true;
                this.contextMenuStrip1.Items[2].Enabled = true;
                this.contextMenuStrip1.Items[3].Enabled = true;
                this.contextMenuStrip1.Items[4].Enabled = true;
            }
            //如果桌台为“待用”状态，则屏蔽除“开台”命令以外的所有命令
            if (zt == "空闲")
            {
                this.contextMenuStrip1.Items[0].Enabled = true;
                this.contextMenuStrip1.Items[1].Enabled = false;
                this.contextMenuStrip1.Items[2].Enabled = false;
                this.contextMenuStrip1.Items[3].Enabled = false;
                this.contextMenuStrip1.Items[4].Enabled = false;
            }
            conn.Close();//关闭数据库连接
        }

        /* private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
         {
             string whichone = (sender as ContextMenuStrip).SourceControl.Name;
             String N = System.Text.RegularExpressions.Regex.Replace(whichone, @"[^0-9]+", "");
              int c = Convert.ToInt32(N.Trim());
              if (frmWaiter.OrderNum.conid[c] == null)
              {
                 // 取消开台ToolStripMenuItem.Enabled = false;
              }
              else
              {
                 MessageBox.Show(frmWaiter.OrderNum.conid[c]);

                 //(sender as ContextMenuStrip).SourceControl.ContextMenuStrip.Items[0].Enabled = false;
              }

         }*/
    }


}
