namespace 餐饮管理系统
{
    partial class frmCheckout
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblroom = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Txtshouyin = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.rtxtxf = new System.Windows.Forms.RichTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(26, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 331);
            this.textBox1.TabIndex = 0;
            // 
            // lblroom
            // 
            this.lblroom.AutoSize = true;
            this.lblroom.Location = new System.Drawing.Point(39, 38);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(65, 12);
            this.lblroom.TabIndex = 1;
            this.lblroom.Text = "当前桌台—";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(465, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 331);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(503, 77);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(53, 12);
            this.sum.TabIndex = 4;
            this.sum.Text = "总消费：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "收银：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "结账";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Txtshouyin
            // 
            this.Txtshouyin.Location = new System.Drawing.Point(573, 163);
            this.Txtshouyin.Name = "Txtshouyin";
            this.Txtshouyin.Size = new System.Drawing.Size(133, 21);
            this.Txtshouyin.TabIndex = 9;
          
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(606, 77);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 15);
            this.lblSum.TabIndex = 10;
            this.lblSum.UseCompatibleTextRendering = true;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(604, 228);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 12);
            this.lblChange.TabIndex = 11;
            // 
            // rtxtxf
            // 
            this.rtxtxf.Location = new System.Drawing.Point(41, 262);
            this.rtxtxf.Name = "rtxtxf";
            this.rtxtxf.ReadOnly = true;
            this.rtxtxf.Size = new System.Drawing.Size(403, 101);
            this.rtxtxf.TabIndex = 12;
            this.rtxtxf.Text = "";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(41, 56);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(403, 202);
            this.dgv.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "找零";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 395);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.rtxtxf);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.Txtshouyin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.textBox1);
            this.Name = "frmCheckout";
            this.Text = "结账";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txtshouyin;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.RichTextBox rtxtxf;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button3;
    }
}