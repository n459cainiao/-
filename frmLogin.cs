using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 餐饮管理系统
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {








            if (txtUserId.Text==""||txtPassword.Text=="")
            {
                MessageBox.Show("输入禁止为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sqlstr = "select count(*) from Login where userId='"+txtUserId.Text.Trim()+"' and password='"+txtPassword.Text.Trim()+"'";
                using (SqlConnection conn = new SqlConnection(DBHelper.connString))
                {
                    SqlCommand cmd = new SqlCommand(sqlstr, conn);
                    conn.Open();
                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        DBHelper.userId = txtUserId.Text;
                        sqlstr = "select duty from staff where userId='" + txtUserId.Text.Trim() + "'";
                        cmd = new SqlCommand(sqlstr, conn);
                        string duty = cmd.ExecuteScalar().ToString();
                        if (duty == "管理员")
                        {
                            frmAdmin admin = new frmAdmin();
                            admin.Show();
                            this.Hide();

                        }
                        else
                        if (duty == "服务员")
                        {
                            frmWaiter waiter = new frmWaiter();
                            waiter.userId = txtUserId.Text.Trim();
                            waiter.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("您没有权限登录系统！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserId.Text = "";
                        txtPassword.Text = "";
                        txtUserId.Focus();
                    }
                }
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
    class DBHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}
