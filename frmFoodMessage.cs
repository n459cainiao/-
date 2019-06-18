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
    public partial class frmFoodMessage : Form
    {
        public frmFoodMessage()
        {
            InitializeComponent();
        }
        public string foodName
        {
            get;
            set;
        }
        private void FrmFoodMessage_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            txtPrice.Visible = false;
            using(SqlConnection conn=new SqlConnection(DBHelper.connString))
            {
                string sqlstr = "select * from food where foodName='" + foodName + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    lblFoodid.Text = reader["foodId"].ToString();
                    lblFoodName.Text = foodName;
                    lblFoodPrice.Text = reader["foodPrice"].ToString()+"元";
                    pictureBox1.Image = Image.FromFile(Path.photoPath(reader["foodPicture"].ToString()));
                }

            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            txtPrice.Visible = true;
            btnChange.Visible = false;
            btnSave.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否保存？","信息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                decimal price;
                try
                {
                    price = decimal.Parse(txtPrice.Text);
                }
                catch
                {
                    MessageBox.Show("请输入正确的价格!");
                    return;
                }
                using (SqlConnection conn = new SqlConnection(DBHelper.connString))
                {
                    conn.Open();
                    string sqlstr = "update food set foodPrice =" + price + "";
                    SqlCommand cmd = new SqlCommand(sqlstr, conn);
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("修改成功!");
                    }
                    txtPrice.Visible = false;
                    lblFoodPrice.Text = txtPrice.Text + "元";
                    btnSave.Visible = false;
                    btnChange.Visible = true;
                }
            }
        }
    }
}
