

namespace 餐饮管理系统
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxWname = new System.Windows.Forms.ComboBox();
            this.TxtSum = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtFnum = new System.Windows.Forms.TextBox();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flpyFood = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvFt = new System.Windows.Forms.DataGridView();
            this.btnBg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(130, 589);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "清空";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 402);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(331, 181);
            this.textBox3.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "菜单编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "服务员：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "菜品名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "*数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "=总价：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "备注：";
            // 
            // cbxWname
            // 
            this.cbxWname.FormattingEnabled = true;
            this.cbxWname.Location = new System.Drawing.Point(59, 506);
            this.cbxWname.Name = "cbxWname";
            this.cbxWname.Size = new System.Drawing.Size(121, 20);
            this.cbxWname.TabIndex = 15;
            // 
            // TxtSum
            // 
            this.TxtSum.Location = new System.Drawing.Point(272, 459);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.ReadOnly = true;
            this.TxtSum.Size = new System.Drawing.Size(56, 21);
            this.TxtSum.TabIndex = 16;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(234, 509);
            this.TxtAdd.Multiline = true;
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(100, 59);
            this.TxtAdd.TabIndex = 17;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(45, 459);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(63, 21);
            this.TxtPrice.TabIndex = 18;
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(166, 459);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(49, 21);
            this.TxtNum.TabIndex = 19;
            // 
            // TxtFnum
            // 
            this.TxtFnum.Location = new System.Drawing.Point(70, 411);
            this.TxtFnum.Name = "TxtFnum";
            this.TxtFnum.ReadOnly = true;
            this.TxtFnum.Size = new System.Drawing.Size(51, 21);
            this.TxtFnum.TabIndex = 20;
            // 
            // TxtFname
            // 
            this.TxtFname.Location = new System.Drawing.Point(200, 411);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.ReadOnly = true;
            this.TxtFname.Size = new System.Drawing.Size(128, 21);
            this.TxtFname.TabIndex = 21;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "餐桌 (2).jpg");
            // 
            // flpyFood
            // 
            this.flpyFood.Location = new System.Drawing.Point(5, 12);
            this.flpyFood.Name = "flpyFood";
            this.flpyFood.Size = new System.Drawing.Size(1039, 384);
            this.flpyFood.TabIndex = 22;
            // 
            // dgvFt
            // 
            this.dgvFt.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFt.Location = new System.Drawing.Point(347, 402);
            this.dgvFt.Name = "dgvFt";
            this.dgvFt.RowHeadersWidth = 51;
            this.dgvFt.RowTemplate.Height = 23;
            this.dgvFt.Size = new System.Drawing.Size(697, 259);
            this.dgvFt.TabIndex = 23;
            // 
            // btnBg
            // 
            this.btnBg.Location = new System.Drawing.Point(130, 628);
            this.btnBg.Name = "btnBg";
            this.btnBg.Size = new System.Drawing.Size(75, 43);
            this.btnBg.TabIndex = 24;
            this.btnBg.Text = "下单";
            this.btnBg.UseVisualStyleBackColor = true;
            this.btnBg.Click += new System.EventHandler(this.BtnBg_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1058, 674);
            this.Controls.Add(this.btnBg);
            this.Controls.Add(this.dgvFt);
            this.Controls.Add(this.flpyFood);
            this.Controls.Add(this.TxtFname);
            this.Controls.Add(this.TxtFnum);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.cbxWname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrder";
            this.Text = "点/加菜";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.Click += new System.EventHandler(this.BtnBg_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvManage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxWname;
        private System.Windows.Forms.TextBox TxtSum;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtFnum;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpyFood;
        private System.Windows.Forms.DataGridView dgvFt;
        private System.Windows.Forms.Button btnBg;
    }
}