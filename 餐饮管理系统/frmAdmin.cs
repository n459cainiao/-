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
        SqlCommand cmd;
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
            string sqlcon = @"Data Source=DESKTOP-MQ5BMMJ\SQLEXPRESS;Initial Catalog=My_Catering;Integrated Security=True";
            conn = new SqlConnection(sqlcon);
            conn.Open();
            ini();
            

        }
        private void ini()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string sqlstr = "select * from staff where userId='" + userId + "'";
            cmd = new SqlCommand(sqlstr, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    tsslName.Text = reader["userName"].ToString();
                    lblName.Text = reader["userName"].ToString();
                    lblAge.Text = reader["age"].ToString();
                    lblSex.Text = reader["sex"].ToString();
                    lblDuty.Text = reader["duty"].ToString();
                    lblIdNum.Text = reader["idNum"].ToString();
                    lblTel.Text = reader["tel"].ToString();
                    lblAddress.Text = reader["address"].ToString();
                    pictureBox1.Image = Image.FromFile(reader["userPhoto"].ToString());
                    
                }
            }
            btnPhoto.Enabled = false;
            btnPhoto.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick1;
        }
        private void Timer1_Tick1(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            btnPhoto.Enabled = true;
            btnPhoto.Visible = true;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnChange.Enabled = false;
            btnChange.Visible = false;

            TextBox txtTel = new TextBox();
            txtTel.Size = new Size(100, 10);
            txtTel.Text = lblTel.Text;
            
            txtTel.Location = lblTel.Location;
            lblTel.Visible = false;
            tabPage1.Controls.Add(txtTel);
            txtTel.Focus();

            TextBox txAddress = new TextBox();
            txAddress.Size = new Size(100, 10);
            txAddress.Text = lblAddress.Text;
            txAddress.Location = lblAddress.Location;
            lblAddress.Visible = false;
            tabPage1.Controls.Add(txAddress);
        }
    }
}
