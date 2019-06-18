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
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        string path;
        string foodId;
        string foodName;
        string price;
        private void BtnChoose_Click(object sender, EventArgs e)
        {
            ofdlgPicture.InitialDirectory = Application.StartupPath.Remove(Application.StartupPath.LastIndexOf(@"\bin")) + @"\images\菜品";
            ofdlgPicture.Filter = "jpg文件(*.jpg)|*.jpg|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
            if (ofdlgPicture.ShowDialog() == DialogResult.OK)
            {
                path = ofdlgPicture.FileName;
                pcbFood.Image = Image.FromFile(path);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            foodId = txtFno.Text;
            foodName = txtFna.Text;
            price = txtprice.Text;
            if (foodId == "" || foodName == "" || price == ""||path==null)
            {
                MessageBox.Show("请填写完整信息！");
            }
            else
            {
                double foodPrice;
                try
                {
                    foodPrice = double.Parse(price);
                }
                catch
                {
                    MessageBox.Show("价格格式填写错误！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(DBHelper.connString))
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show("确认添加菜品？", "信息确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            string sqlstr = string.Format("insert into food values('{0}','{1}',{2},'{3}')", foodId, foodName, foodPrice, path);
                            SqlCommand cmd = new SqlCommand(sqlstr, conn);
                            conn.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("添加成功！");
                                this.Close();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
    }
}
