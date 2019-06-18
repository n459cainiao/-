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
    public partial class staffMessage : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        SqlConnection conn = new SqlConnection(DBHelper.connString);
        public staffMessage()
        {
            InitializeComponent();
        }
        public string userId
        {
            get;
            set;
        }
        private string photoPass;
        private void StaffMessage_Load(object sender, EventArgs e)
        {

                conn.Open();
                ds = new DataSet();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                string sqlstr = "select * from staff where userId='" + userId + "'";
                ad = new SqlDataAdapter();
                ad.SelectCommand = new SqlCommand(sqlstr, conn);
                ad.Fill(ds, "message");
                if (ds.Tables["message"].Rows[0]["duty"].ToString() == "管理员")
                {
                    btnChange.Visible = false;
                }
                lblName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
                lblAge.Text = ds.Tables["message"].Rows[0]["age"].ToString();
                lblSex.Text = ds.Tables["message"].Rows[0]["sex"].ToString();
                lblDuty.Text = ds.Tables["message"].Rows[0]["duty"].ToString();
                lblIdNum.Text = ds.Tables["message"].Rows[0]["idNum"].ToString();
                lblTel.Text = ds.Tables["message"].Rows[0]["tel"].ToString();
                lblAddress.Text = ds.Tables["message"].Rows[0]["address"].ToString();
                    string s = ds.Tables["message"].Rows[0]["userPhoto"].ToString();
  
                    pictureBox1.Image = Image.FromFile(Path.photoPath(s));
                    photoPass = Path.photoPath(s);
                btnPhoto.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                txtAddress.Visible = false;
                txtTel.Visible = false;
            

        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.InitialDirectory = Application.StartupPath.Remove(Application.StartupPath.LastIndexOf(@"\bin"))+@"\images\照片";
            photo.Filter = "jpg文件(*.jpg)|*.jpg|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
            if (photo.ShowDialog() == DialogResult.OK)
            {
                string path = photo.FileName;
                pictureBox1.Image = Image.FromFile(path);
                ds.Tables["message"].Rows[0]["userPhoto"] = path;
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            btnPhoto.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnChange.Visible = false;

            txtTel.Visible = true;
            txtTel.Text = lblTel.Text;
            lblTel.Visible = false;
            txtTel.Focus();

            txtAddress.Visible = true;
            txtAddress.Text = lblAddress.Text;
            lblAddress.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult se = MessageBox.Show("是否保存？", "确认信息", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(se==DialogResult.OK)
            {
                txtAddress.Visible = false;
                txtTel.Visible = false;
                lblAddress.Visible = true;
                lblTel.Visible = true;
                btnCancel.Visible = false;
                btnChange.Visible = true;
                btnPhoto.Visible = false;
                btnSave.Visible = false;

                photoPass = ds.Tables["message"].Rows[0]["userPhoto"].ToString();

                lblTel.Text = txtTel.Text.Trim();
                txtTel.Visible = false;
                lblTel.Visible = true;
                ds.Tables[0].Rows[0]["tel"] = lblTel.Text.Trim();
                lblAddress.Text = txtAddress.Text.Trim();
                txtAddress.Visible = false;
                lblAddress.Visible = true;
                ds.Tables["message"].Rows[0]["address"] = lblAddress.Text.Trim();

                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                ad.Update(ds, "message");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Visible = false;
            txtTel.Visible = false;
            lblAddress.Visible = true;
            lblTel.Visible = true;
            btnCancel.Visible = false;
            btnChange.Visible = true;
            btnPhoto.Visible = false;
            btnSave.Visible = false;
            pictureBox1.Image = Image.FromFile(photoPass);
            ds.Tables["message"].Rows[0]["userPhoto"] = photoPass;
        }
    }
}
