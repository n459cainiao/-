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
    public partial class frmOrder : Form
    {
        SqlConnection conn;
        DataSet ds;
        DataSet dat;
        SqlDataAdapter sda;
        public SqlDataReader sdr;
        public frmOpen open;
        public string photoPass;
        public SqlCommand cmd;
        public string path;
        String strwaiter;
        public String uid;
        public String roomnum;
        public String N;
        public frmOrder()
        {
                
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }

        public frmOrder(frmOpen open)
        {
            InitializeComponent();
            this.open = open;

        }
        public int i;
      public void AddItems()
        {

    
            int c = ds.Tables["fmessage"].Rows.Count;
            for ( i = 0; i < c; i++)
            {

                Panel picpanel = new Panel();
                Panel lblpanel = new Panel();
                PictureBox picture = new PictureBox();
                lblpanel.Dock = DockStyle.Bottom;
                lblpanel.Size = new System.Drawing.Size(picture.Size.Width, 20);
                picpanel.Size = new System.Drawing.Size(picture.Size.Width, picture.Size.Height + lblpanel.Size.Height);
                lblpanel.Location = new Point(picpanel.Location.X, 1000);
                string s = ds.Tables["fmessage"].Rows[i]["foodPictuer"].ToString();
                path = s.Substring(s.LastIndexOf(@"\餐饮管理系统图片"));
                picture.Image = Image.FromFile(Application.StartupPath + path);
                photoPass = Application.StartupPath + path;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.BorderStyle = BorderStyle.FixedSingle;
                Label lbl = new Label();
                lbl.Text = ds.Tables["fmessage"].Rows[i]["foodName"].ToString();
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblpanel.Location = new Point();
                picture.Tag = lbl.Text;
                lblpanel.Controls.Add(lbl);
                picpanel.Controls.Add(picture);
                picpanel.Controls.Add(lblpanel);
                flpyFood.Controls.Add(picpanel);
                picture.DoubleClick += new System.EventHandler(this.double_click);
                
            }

        }
     
        private void double_click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            string fn = pic.Tag.ToString();
          
            DataSet data = new DataSet();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from food where foodName='" + fn + "'", conn);
            sqlData.Fill(data, "food");
            TxtFname.Text = fn;
            TxtNum.Text = "1";
            TxtFnum.Text = data.Tables["food"].Rows[0]["foodId"].ToString();
            TxtPrice.Text = data.Tables["food"].Rows[0]["foodPrice"].ToString();
            TxtSum.Text = (Convert.ToDecimal(TxtPrice.Text) * Convert.ToInt32(TxtNum.Text)).ToString();


        }
       public DataTable dtb = new DataTable();
        private void FrmOrder_Load(object sender, EventArgs e)
        {

            Random rd = new Random();
            N = (System.DateTime.Now.ToShortDateString() + " - " + rd.Next(1, 10000).ToString()); ;
            datetime = System.DateTime.Now.ToString();
            conn = new SqlConnection(DBHelper.connString); 
            ds = new DataSet();
            conn.Open();
           string sqlstr = "select * from food";
           sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(sqlstr, conn);
            sda.Fill(ds, "fmessage");
           
            AddItems();
           
            dtb.Columns.Add("菜名", typeof(string));
            dtb.Columns.Add("单价", typeof(string));
            dtb.Columns.Add("数量", typeof(string));
            dtb.Columns.Add("总价", typeof(string));
            dtb.Columns.Add("服务员名", typeof(string));
            dtb.Columns.Add("备注", typeof(string));
        

          dt.Columns.Add("con_id", typeof(string));
            dt.Columns.Add("con_foodId", typeof(string));
            dt.Columns.Add("con_foodName", typeof(string));
            dt.Columns.Add("foodsum", typeof(string));
            dt.Columns.Add("con_foodPrice", typeof(string));
            dt.Columns.Add("con_foodTprice", typeof(string));
            cbxWname.Text = open.waitername;
            roomnum=open.roomnum;
            


        }
        public DataTable dt = new DataTable();
        String datetime;
        public double Tsum;
        private void BtnSave_Click(object sender, EventArgs e)
        {
           Tsum = Convert.ToInt32(TxtNum.Text) * Convert.ToDouble(TxtPrice.Text);

            TxtSum.Text = Tsum.ToString();
          
            DataRow rw = dtb.NewRow();
            rw["菜名"] = TxtFname.Text;
            rw["单价"] =TxtPrice.Text;
            rw["数量"] = TxtNum.Text;
            rw["总价"] = TxtSum.Text; 
            rw["服务员名"] = cbxWname.Text;
            rw["备注"] = TxtAdd.Text;
            dtb.Rows.Add(rw);
            dgvFt.DataSource = dtb;
          

            dat = new DataSet();         
            DataRow dtr = dt.NewRow();  
            dtr["con_foodName"] = TxtFname.Text;
            dtr["con_foodPrice"] = TxtPrice.Text;
            dtr["foodsum"] =Convert.ToInt32(TxtNum.Text.Trim());
            dtr["con_foodId"] = TxtFnum.Text;
            dtr["con_id"] =N;
            dtr["con_foodTprice"] = Tsum;
            dt.Rows.Add(dtr);

            strwaiter = "select userId from staff where userName='" + cbxWname.Text.Trim() + "'";
            SqlCommand Ucommand = new SqlCommand(strwaiter, conn);
            SqlDataReader uID = Ucommand.ExecuteReader();

            while (uID.Read())
            {
                uid = uID["userId"].ToString().Trim();
            }
            uID.Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            for (i = 0; i < dgvFt.Columns.Count; i++)
                dgvFt.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFt.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            if (this.dgvFt.SelectedRows.Count > 0)
            {
                DataRowView drv =dgvFt.SelectedRows[0].DataBoundItem as DataRowView;
                drv.Delete();
                String delsql = "delete from con_food where con_id='" + N + "'";
                SqlCommand delcommd = new SqlCommand(delsql, conn);
                delcommd.ExecuteNonQuery();
                if (delcommd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("是否退出？");
           // this.Dispose();
        }
      
        private void BtnBg_Click(object sender,EventArgs e)
        {
         
            int c =Convert.ToInt32(roomnum);
            frmWaiter.OrderNum.conid[c] = this.N;
           
            if (dgvFt.DataSource == null)
            {
                MessageBox.Show("请先选菜再下单！");
            }
            else
            {
                if((dgvFt.DataSource as DataTable).Rows.Count == 0)
                {
                    MessageBox.Show("请先选菜再下单！");
                }
                else
                {

             
                    try
                    {
                       

                        String strsql = "insert into consumption(con_id,con_time,con_num,con_state,con_table,waiterId) values('"+N+"','" + datetime + "'," + Convert.ToInt32(open.connum) + ",'"+open.state+"','" + roomnum + "','" + uid + "')";
                        SqlCommand sqlCommand = new SqlCommand(strsql, conn);
                        sqlCommand.ExecuteNonQuery();
                    
                      /*  string cfstr = " insert into con_food (con_id,con_foodId,con_foodName,foodSum,con_foodPrice,con_foodTprice) values('" + N + "','" + TxtFnum.Text + "','" + TxtFname.Text + "' ,'" + TxtNum.Text + "' ," + Convert.ToDecimal(TxtPrice.Text) + "," + Convert.ToDecimal(Tsum) + " ) ";
                        SqlCommand command = new SqlCommand(cfstr, conn);
                        command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("消费食物表插入成功");

                        }
                        else
                        {
                            MessageBox.Show("失败");
                        }*/
                          dat.Tables.Add(dt);
                        SqlBulkCopy sbc = new SqlBulkCopy(conn);
                        sbc.DestinationTableName = "My_Catering.dbo.con_food";
                        sbc.BatchSize = dt.Rows.Count;
                        sbc.ColumnMappings.Add("con_id", "con_id");//映射字段名 DataTable列名 ,数据库 对应的列名   
                        sbc.ColumnMappings.Add("con_foodId", "con_foodId");
                        sbc.ColumnMappings.Add("con_foodName", "con_foodName");
                        sbc.ColumnMappings.Add("foodSum", "foodSum");
                        sbc.ColumnMappings.Add("con_foodPrice", "con_foodPrice");
                        sbc.ColumnMappings.Add("con_foodTprice", "con_foodTprice");
                        sbc.WriteToServer(dat.Tables[0]);
                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    MessageBox.Show("下单成功");
                 
                }
            }
        }
    }
}
