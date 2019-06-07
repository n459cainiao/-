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
    public partial class frmAdmin : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter ad;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public string userId
        {
            get;
            set;
        }
        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
        
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(DBHelper.connString);
            ds = new DataSet();
            conn.Open();
            ini();
            

        }
        private void ini()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            string sqlstr = "select * from staff where userId='" + userId + "'";
            ad = new SqlDataAdapter();
            ad.SelectCommand = new SqlCommand(sqlstr, conn);
            ad.Fill(ds,"message");
            tsslName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
            lblName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
            lblAge.Text = ds.Tables["message"].Rows[0]["age"].ToString();
            lblSex.Text = ds.Tables["message"].Rows[0]["sex"].ToString();
            lblDuty.Text = ds.Tables["message"].Rows[0]["duty"].ToString();
            lblIdNum.Text = ds.Tables["message"].Rows[0]["idNum"].ToString();
            lblTel.Text = ds.Tables["message"].Rows[0]["tel"].ToString();
            lblAddress.Text = ds.Tables["message"].Rows[0]["address"].ToString();
            try
            {
                string s = ds.Tables["message"].Rows[0]["userPhoto"].ToString();
                string path = s.Substring(s.LastIndexOf(@"\餐饮管理系统图片"));
                pictureBox1.Image = Image.FromFile(Application.StartupPath + path);
                photoPass = Application.StartupPath + path;
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[0]["userPhoto"].ToString());
                photoPass = ds.Tables[0].Rows[0]["userPhoto"].ToString();
            }
            btnPhoto.Enabled = false;
            btnPhoto.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            txtAddress.Visible = false;
            txtTel.Visible = false;
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick1;
        }
        private void Timer1_Tick1(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString();
        }

        private string photoPass;

        private void BtnChange_Click(object sender, EventArgs e)
        {
            btnPhoto.Enabled = true;
            btnPhoto.Visible = true;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            btnChange.Enabled = false;
            btnChange.Visible = false;

            txtTel.Visible = true;
            txtTel.Text = lblTel.Text;
            lblTel.Visible = false;
            txtTel.Focus();

            txtAddress.Visible = true;
            txtAddress.Text = lblAddress.Text;
            lblAddress.Visible = false;
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.InitialDirectory = Application.StartupPath + @"\餐饮管理系统图片\照片";
            photo.Filter = "jpg文件(*.jpg)|*.jpg|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
           if(photo.ShowDialog()==DialogResult.OK)
            {
                string path = photo.FileName;
                pictureBox1.Image = Image.FromFile(path);
                photoPass = path;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Visible = false;
            txtTel.Visible = false;
            lblAddress.Visible = true;
            lblTel.Visible = true;
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnChange.Enabled = true;
            btnChange.Visible = true;
            btnPhoto.Enabled = false;
            btnPhoto.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
            pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[0]["userPhoto"].ToString());
            photoPass = ds.Tables[0].Rows[0]["userPhoto"].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            txtAddress.Visible = false;
            txtTel.Visible = false;
            lblAddress.Visible = true;
            lblTel.Visible = true;
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnChange.Enabled = true;
            btnChange.Visible = true;
            btnPhoto.Enabled = false;
            btnPhoto.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;

            ds.Tables[0].Rows[0]["userPhoto"] = photoPass;

            lblTel.Text = txtTel.Text.Trim();
            txtTel.Visible = false;
            lblTel.Visible = true;
            ds.Tables[0].Rows[0]["tel"] = lblTel.Text.Trim();
            lblAddress.Text = txtAddress.Text.Trim();
            txtAddress.Visible = false;
            lblAddress.Visible = true;
            ds.Tables["message"].Rows[0]["address"] = lblAddress.Text.Trim();

            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            ad.Update(ds,"message");
        }

    }
}
