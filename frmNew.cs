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
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void FrmNew_Load(object sender, EventArgs e)
        {
            label17.Visible = false;
            txtPassword.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string name;
        string id;
        string duty;
        int age;
        string address;
        string path="";
        string tel;
        string idNum;
        string password;
        string sex;
        bool isWaiter = false;

        private void BtnChose_Click(object sender, EventArgs e)
        {
            ofdlgPhoto.InitialDirectory = Application.StartupPath.Remove(Application.StartupPath.LastIndexOf(@"\bin")) + @"\images\照片";
            ofdlgPhoto.Filter = "jpg文件(*.jpg)|*.jpg|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
            if (ofdlgPhoto.ShowDialog() == DialogResult.OK)
            {
                path = ofdlgPhoto.FileName;
                pictureBox2.Image = Image.FromFile(path);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            id = txtId.Text;
            address = txtAddress.Text;
            tel = txtTel.Text;
            idNum = txtIdNum.Text;
            if (name == "" || id == "" || address == "" || tel == "" || duty == "" || path == "" || idNum == "" || txtAge.Text == ""||sex=="")
            {
                MessageBox.Show("请填写完整信息!");
                return;
            }
            try
            {
                age = int.Parse(txtAge.Text);
            }
            catch
            {
                MessageBox.Show("年龄格式错误！");
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBHelper.connString))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("确认添加职员？", "信息确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        string sqlstr = string.Format("insert into staff values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}')", id, name, duty, sex, age, idNum, address, tel, path, "空闲");
                        SqlCommand cmd = new SqlCommand(sqlstr, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (isWaiter)
                        {
                            password = txtPassword.Text;
                            if (password == "")
                            {
                                MessageBox.Show("请填写密码！");
                                return;
                            }
                            else
                            {
                                try
                                {
                                    string str = "insert into Login values('" + id + "','" + password + "')";
                                    SqlCommand comd = new SqlCommand(str, conn);
                                    comd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                        }
                        MessageBox.Show("添加成功！");
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void CbxDuty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDuty.SelectedItem.ToString() == "服务员")
            {
                label17.Visible = true;
                txtPassword.Visible = true;
                isWaiter = true;
            }
            else
            {
                label17.Visible =false;
                txtPassword.Visible =false;
            }
            duty = cbxDuty.SelectedItem.ToString();
        }

        private void RbtnMan_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            sex = radio.Text;
        }
    }
}
