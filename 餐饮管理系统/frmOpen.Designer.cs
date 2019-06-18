namespace 餐饮管理系统
{
    partial class frmOpen
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblWname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnum = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TxtRnum = new System.Windows.Forms.TextBox();
            this.TxtCname = new System.Windows.Forms.TextBox();
            this.TxtWname = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtUnum = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(34, 46);
            this.lblnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(71, 12);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = " 桌台编号：";
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(34, 98);
            this.lblCname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(71, 12);
            this.lblCname.TabIndex = 0;
            this.lblCname.Text = " 顾客名称：";
            // 
            // lblWname
            // 
            this.lblWname.AutoSize = true;
            this.lblWname.Location = new System.Drawing.Point(28, 163);
            this.lblWname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWname.Name = "lblWname";
            this.lblWname.Size = new System.Drawing.Size(77, 12);
            this.lblWname.TabIndex = 0;
            this.lblWname.Text = "服务员姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = " 备注：";
            // 
            // lblUnum
            // 
            this.lblUnum.AutoSize = true;
            this.lblUnum.Location = new System.Drawing.Point(317, 98);
            this.lblUnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnum.Name = "lblUnum";
            this.lblUnum.Size = new System.Drawing.Size(71, 12);
            this.lblUnum.TabIndex = 0;
            this.lblUnum.Text = " 用餐人数：";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(317, 46);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(71, 12);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = " 账单日期：";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(104, 56);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(202, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // TxtRnum
            // 
            this.TxtRnum.Location = new System.Drawing.Point(117, 44);
            this.TxtRnum.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRnum.Name = "TxtRnum";
            this.TxtRnum.ReadOnly = true;
            this.TxtRnum.Size = new System.Drawing.Size(126, 21);
            this.TxtRnum.TabIndex = 2;
            // 
            // TxtCname
            // 
            this.TxtCname.Location = new System.Drawing.Point(117, 96);
            this.TxtCname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCname.Name = "TxtCname";
            this.TxtCname.Size = new System.Drawing.Size(126, 21);
            this.TxtCname.TabIndex = 2;
            // 
            // TxtWname
            // 
            this.TxtWname.Location = new System.Drawing.Point(117, 161);
            this.TxtWname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtWname.Name = "TxtWname";
            this.TxtWname.Size = new System.Drawing.Size(126, 21);
            this.TxtWname.TabIndex = 2;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(399, 161);
            this.TxtAdd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdd.Multiline = true;
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(126, 21);
            this.TxtAdd.TabIndex = 2;
            // 
            // TxtUnum
            // 
            this.TxtUnum.Location = new System.Drawing.Point(399, 96);
            this.TxtUnum.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnum.Name = "TxtUnum";
            this.TxtUnum.Size = new System.Drawing.Size(126, 21);
            this.TxtUnum.TabIndex = 2;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(399, 44);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(126, 21);
            this.TxtDate.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 227);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = " 保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 227);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = " 退出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtCname);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtUnum);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.TxtWname);
            this.Controls.Add(this.TxtRnum);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblUnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWname);
            this.Controls.Add(this.lblCname);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOpen";
            this.Text = "开台单";
            this.Load += new System.EventHandler(this.FrmOpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblWname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnum;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox TxtRnum;
        private System.Windows.Forms.TextBox TxtCname;
        private System.Windows.Forms.TextBox TxtWname;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.TextBox TxtUnum;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}