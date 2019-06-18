namespace 餐饮管理系统
{
    partial class frmNew
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxDuty = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIdNum = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ofdlgPhoto = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(50, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(292, 133);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(63, 23);
            this.btnChoose.TabIndex = 40;
            this.btnChoose.Text = "选择照片";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.BtnChose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(279, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(264, 312);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "确认添加";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(279, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "设置密码：";
            // 
            // cbxDuty
            // 
            this.cbxDuty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDuty.FormattingEnabled = true;
            this.cbxDuty.Items.AddRange(new object[] {
            "服务员",
            "厨师",
            "清洁"});
            this.cbxDuty.Location = new System.Drawing.Point(90, 188);
            this.cbxDuty.Name = "cbxDuty";
            this.cbxDuty.Size = new System.Drawing.Size(109, 20);
            this.cbxDuty.TabIndex = 35;
            this.cbxDuty.SelectedIndexChanged += new System.EventHandler(this.CbxDuty_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 257);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(123, 45);
            this.txtAddress.TabIndex = 34;
            // 
            // txtIdNum
            // 
            this.txtIdNum.Location = new System.Drawing.Point(90, 217);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Size = new System.Drawing.Size(157, 21);
            this.txtIdNum.TabIndex = 33;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(90, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(109, 21);
            this.txtTel.TabIndex = 32;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 21);
            this.txtAge.TabIndex = 31;
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Location = new System.Drawing.Point(131, 90);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(35, 16);
            this.rbtnWoman.TabIndex = 30;
            this.rbtnWoman.TabStop = true;
            this.rbtnWoman.Text = "女";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            this.rbtnWoman.Click += new System.EventHandler(this.RbtnMan_CheckedChanged);
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(90, 90);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(35, 16);
            this.rbtnMan.TabIndex = 29;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            this.rbtnMan.Click += new System.EventHandler(this.RbtnMan_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(63, 21);
            this.txtName.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "电话：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "性别：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "职务：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "家庭住址：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "身份证号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "年龄：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "姓名：";
            // 
            // ofdlgPhoto
            // 
            this.ofdlgPhoto.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "工号：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(84, 21);
            this.txtId.TabIndex = 43;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 354);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxDuty);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdNum);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.rbtnWoman);
            this.Controls.Add(this.rbtnMan);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加职员";
            this.Load += new System.EventHandler(this.FrmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxDuty;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIdNum;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog ofdlgPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}