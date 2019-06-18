namespace 餐饮管理系统
{
    partial class frmFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFno = new System.Windows.Forms.TextBox();
            this.txtFna = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ofdlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.pcbFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜品编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "价格：";
            // 
            // txtFno
            // 
            this.txtFno.Location = new System.Drawing.Point(83, 17);
            this.txtFno.Name = "txtFno";
            this.txtFno.Size = new System.Drawing.Size(100, 21);
            this.txtFno.TabIndex = 3;
            // 
            // txtFna
            // 
            this.txtFna.Location = new System.Drawing.Point(83, 63);
            this.txtFna.Name = "txtFna";
            this.txtFna.Size = new System.Drawing.Size(100, 21);
            this.txtFna.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(83, 114);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 21);
            this.txtprice.TabIndex = 5;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(224, 121);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(62, 23);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "选择照片";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(83, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确认添加";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // ofdlgPicture
            // 
            this.ofdlgPicture.FileName = "openFileDialog1";
            // 
            // pcbFood
            // 
            this.pcbFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbFood.Location = new System.Drawing.Point(212, 17);
            this.pcbFood.Name = "pcbFood";
            this.pcbFood.Size = new System.Drawing.Size(85, 98);
            this.pcbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFood.TabIndex = 6;
            this.pcbFood.TabStop = false;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 218);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pcbFood);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtFna);
            this.Controls.Add(this.txtFno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcbFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFno;
        private System.Windows.Forms.TextBox txtFna;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.PictureBox pcbFood;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.OpenFileDialog ofdlgPicture;
    }
}