using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace 餐饮管理系统
{
    public partial class frmAdmin : Form
    {
        DataSet ds;
        SqlDataAdapter ad1;
        SqlConnection conn = new SqlConnection(DBHelper.connString);
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select userState from staff where userId='" + DBHelper.userId + "'",conn);
            if (cmd.ExecuteScalar().ToString().Trim() == "忙碌")
            {
                cmd = new SqlCommand("update staff set userState='空闲' where userId='" + DBHelper.userId + "'",conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            Application.Exit();
        }


        private int iniWidth;
        private int iniHeight;
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            iniWidth = 383;
            iniHeight = 465;
            this.Width = iniWidth;
            this.Height = iniHeight;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select userState from staff where userId='" + DBHelper.userId + "'",conn);
            if (cmd.ExecuteScalar().ToString().Trim()== "空闲")
            {
                cmd = new SqlCommand("update staff set userState='忙碌' where userId='" + DBHelper.userId + "'",conn);
                cmd.ExecuteNonQuery();
            }
            cmd = new SqlCommand("select userPhoto from staff where userId='" + DBHelper.userId + "'", conn);
            Path.photoPath(cmd.ExecuteScalar().ToString());
            ini();
        }
        private void ini()
        {
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                string sqlstr = "select * from staff where userId='" + DBHelper.userId + "'";
                ad1 = new SqlDataAdapter();
                ad1.SelectCommand = new SqlCommand(sqlstr, conn);
                ad1.Fill(ds, "message");
                tsslName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
                lblName.Text = ds.Tables["message"].Rows[0]["userName"].ToString();
                lblAge.Text = ds.Tables["message"].Rows[0]["age"].ToString();
                lblSex.Text = ds.Tables["message"].Rows[0]["sex"].ToString();
                lblDuty.Text = ds.Tables["message"].Rows[0]["duty"].ToString();
                lblIdNum.Text = ds.Tables["message"].Rows[0]["idNum"].ToString();
                lblTel.Text = ds.Tables["message"].Rows[0]["tel"].ToString();
                lblAddress.Text = ds.Tables["message"].Rows[0]["address"].ToString();
                string s = ds.Tables["message"].Rows[0]["userPhoto"].ToString();
                pictureBox1.Image = Image.FromFile(Path.photoPath(s));
                photoPath = Path.photoPath(s);

                btnPhoto.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                txtAddress.Visible = false;
                txtTel.Visible = false;
            }


            {
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    listView1.Columns[i].Width = listView1.Width / 5;
                }
                string sqlStr = "select * from staff ";
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = new SqlCommand(sqlStr, conn);
                ad.Fill(ds, "staff");
                for (int i = 0; i < ds.Tables["staff"].Rows.Count; i++)
                {
                    ListViewItem items = new ListViewItem();
                    if (i % 2 == 0)
                        items.BackColor = Color.AliceBlue;
                    items.Text = ds.Tables["staff"].Rows[i]["userId"].ToString();
                    items.SubItems.Add(ds.Tables["staff"].Rows[i]["userName"].ToString());
                    items.SubItems.Add(ds.Tables["staff"].Rows[i]["duty"].ToString());
                    items.SubItems.Add(ds.Tables["staff"].Rows[i]["sex"].ToString());
                    items.SubItems.Add(ds.Tables["staff"].Rows[i]["userState"].ToString());
                    listView1.Items.Add(items);
                }
            }

            {
                DataSet ds = new DataSet();
                string s = "select * from food";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(s, conn);
                adapter.Fill(ds);
                int foods = ds.Tables[0].Rows.Count;
                for (int i = 0; i < foods; i++)
                {
                    Panel pel = new Panel();
                    pel.Size = new Size(110, 160);
                    PictureBox picture = new PictureBox();
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Size = new Size(102, 120);
                    picture.Location = new Point(pel.Location.X + 3, pel.Location.Y + 3);
                    picture.BorderStyle = BorderStyle.Fixed3D;
                    Label foodName = new Label();
                    Panel txt = new Panel();
                    txt.Size = new Size(picture.Width, 28);
                    txt.Location = new Point(picture.Location.X, picture.Location.Y + 120);
                    foodName.Font = new Font("宋体", 10F);
                    foodName.TextAlign = ContentAlignment.MiddleCenter;

                    foodName.Text = ds.Tables[0].Rows[i]["foodName"].ToString();
                    picture.Image = Image.FromFile(Path.photoPath(ds.Tables[0].Rows[i]["foodPicture"].ToString()));
                    pel.Controls.Add(picture);
                    txt.Controls.Add(foodName);
                    pel.Controls.Add(txt);
                    flpFood.Controls.Add(pel);

                    picture.Tag = foodName.Text;
                    picture.ContextMenuStrip = contextMenuStrip1;


                }
            }

            {
                for (int i = 0; i < listView2.Columns.Count; i++)
                {
                    listView2.Columns[i].Width = listView2.Width / listView2.Columns.Count;
                }
                string sqlStr = "select * from consumption ";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sqlStr, conn);
                adapter.Fill(ds, "consumption");
                for (int i = 0; i < ds.Tables["consumption"].Rows.Count; i++)
                {
                    ListViewItem items = new ListViewItem();
                    if (i % 2 == 0)
                        items.BackColor = Color.AliceBlue;
                    items.Text = ds.Tables["consumption"].Rows[i]["con_id"].ToString();
                    items.SubItems.Add(ds.Tables["consumption"].Rows[i]["con_time"].ToString());
                    items.SubItems.Add(ds.Tables["consumption"].Rows[i]["con_sum"].ToString());
                    items.SubItems.Add(ds.Tables["consumption"].Rows[i]["con_table"].ToString());
                    items.SubItems.Add(ds.Tables["consumption"].Rows[i]["con_state"].ToString());
                    listView2.Items.Add(items);
                }

            }



        }


        private string photoPath;

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
        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.InitialDirectory = Application.StartupPath.Remove(Application.StartupPath.LastIndexOf(@"\bin")) + @"\images\照片";
            photo.Filter = "jpg文件(*.jpg)|*.jpg|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
            if (photo.ShowDialog() == DialogResult.OK)
            {
                string path = photo.FileName;
                pictureBox1.Image = Image.FromFile(path);
                ds.Tables["message"].Rows[0]["userPhoto"] = path;
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
            pictureBox1.Image = Image.FromFile(photoPath);


            ds.Tables["message"].Rows[0]["userPhoto"] = photoPath;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            txtAddress.Visible = false;
            txtTel.Visible = false;
            lblAddress.Visible = true;
            lblTel.Visible = true;
            btnCancel.Visible = false;
            btnChange.Visible = true;
            btnPhoto.Visible = false;
            btnSave.Visible = false;

            photoPath = ds.Tables["message"].Rows[0]["userPhoto"].ToString();

            lblTel.Text = txtTel.Text.Trim();
            txtTel.Visible = false;
            lblTel.Visible = true;
            ds.Tables[0].Rows[0]["tel"] = lblTel.Text.Trim();
            lblAddress.Text = txtAddress.Text.Trim();
            txtAddress.Visible = false;
            lblAddress.Visible = true;
            ds.Tables["message"].Rows[0]["address"] = lblAddress.Text.Trim();

            SqlCommandBuilder builder = new SqlCommandBuilder(ad1);
            ad1.Update(ds, "message");
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabMessage":
                    this.Width = iniWidth;
                    this.Height = iniHeight;
                    break;
                case "tabStaff":
                    this.Width = iniWidth;
                    this.Height = iniHeight;
                    break;
                case "tabSystem":
                    this.Width = 500;
                    this.Height = 403;
                    break;
                case "tabFood":
                    this.Width = iniWidth;
                    this.Height = iniHeight;
                    break;
                case "tabConsume":
                    this.Width = iniWidth;
                    this.Height = iniHeight;
                    break;

            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {

                    staffMessage staffMessage = new staffMessage();
                    staffMessage.userId = listView1.Items[i].Text;
                    staffMessage.Show();
                }
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.connString))
                {
                    DialogResult dl = MessageBox.Show("是否删除选中职员？", "信息确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dl == DialogResult.OK)
                    {
                        foreach (ListViewItem item in listView1.SelectedItems)
                        {

                            for (int i = 0; i < ds.Tables["staff"].Rows.Count; i++)
                            {
                                if (ds.Tables["staff"].Rows[i]["userId"].ToString() == item.Text)
                                {
                                    if (ds.Tables["staff"].Rows[i]["duty"].ToString() == "管理员")
                                    {
                                        MessageBox.Show("无法删除管理员！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    conn.Open();
                                    ds.Tables["staff"].Rows.RemoveAt(i);
                                    string sqlstr = "delete from staff where userId='" + item.Text + "'";
                                    SqlCommand command = new SqlCommand(sqlstr, conn);
                                    string s = "delete from Login where userId='" + item.Text + "'";
                                    SqlCommand cmand = new SqlCommand(s, conn);
                                    cmand.ExecuteNonQuery();
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        listView1.Items.Remove(item);
                                        MessageBox.Show("删除成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("删除失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("请选中职员", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmNew newStaff = new frmNew();
            newStaff.Show();

        }


        private void TsbtnAdd_Click(object sender, EventArgs e)
        {
            frmFood food = new frmFood();
            food.Show();
        }

        private void TsbtnRefresh_Click(object sender, EventArgs e)
        {
            ds.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
            flpFood.Controls.Clear();
            ini();
        }

        private void ListView2_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].Selected)
                {
                    frmConsumption consumption = new frmConsumption();
                    consumption.con_id = listView2.Items[i].Text;
                    consumption.Show();
                }
            }
        }



        private void FrmAdmin_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            string foodName = item.Tag.ToString();
            DialogResult dr = MessageBox.Show("是否删除"+foodName+"？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr==DialogResult.OK)
            {
                string sqlstr = "delete from food where foodName='" + foodName + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("删除成功！");
                }
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip strip = sender as ContextMenuStrip;
            PictureBox box = strip.SourceControl as PictureBox;
            strip.Items[0].Tag = box.Tag;
            strip.Items[1].Tag = box.Tag;
        }

        private void 查看详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            string foodName = item.Tag.ToString();
            frmFoodMessage food = new frmFoodMessage();
            food.foodName = foodName;
            food.Show();
        }
    }
    class Path
    {
        public static string  photoPath(string path)
        {
            string s = Application.StartupPath;
            path = path.Substring(path.LastIndexOf(@"\images"));
            s = s.Remove(s.LastIndexOf(@"\bin"));
            path = s + path;
            return path;
        }
    }
}
