using System;
using System.ComponentModel;

namespace 餐饮管理系统
{
    partial class frmWaiter
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
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
            this.Dispose();
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaiter));
            this.lblroom1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点加菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.lblroom2 = new System.Windows.Forms.Label();
            this.lblroom3 = new System.Windows.Forms.Label();
            this.lblroom4 = new System.Windows.Forms.Label();
            this.lblroom5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picWaiter = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.餐台1号 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lvdesk = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaiter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.餐台1号.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblroom1
            // 
            this.lblroom1.AutoSize = true;
            this.lblroom1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroom1.Location = new System.Drawing.Point(11, 85);
            this.lblroom1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroom1.Name = "lblroom1";
            this.lblroom1.Size = new System.Drawing.Size(48, 16);
            this.lblroom1.TabIndex = 1;
            this.lblroom1.Text = "餐台1";
            this.lblroom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开台ToolStripMenuItem,
            this.取消开台ToolStripMenuItem,
            this.点加菜ToolStripMenuItem,
            this.消费查询ToolStripMenuItem,
            this.结账ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 114);
            // 
            // 开台ToolStripMenuItem
            // 
            this.开台ToolStripMenuItem.Name = "开台ToolStripMenuItem";
            this.开台ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开台ToolStripMenuItem.Text = "开台";
            this.开台ToolStripMenuItem.Click += new System.EventHandler(this.开台ToolStripMenuItem_Click);
            // 
            // 取消开台ToolStripMenuItem
            // 
            this.取消开台ToolStripMenuItem.Name = "取消开台ToolStripMenuItem";
            this.取消开台ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消开台ToolStripMenuItem.Text = "取消开台";
            this.取消开台ToolStripMenuItem.Click += new System.EventHandler(this.取消开台ToolStripMenuItem_Click);
            // 
            // 点加菜ToolStripMenuItem
            // 
            this.点加菜ToolStripMenuItem.Name = "点加菜ToolStripMenuItem";
            this.点加菜ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.点加菜ToolStripMenuItem.Text = "点/加菜";
            this.点加菜ToolStripMenuItem.Click += new System.EventHandler(this.点加菜ToolStripMenuItem_Click);
            // 
            // 消费查询ToolStripMenuItem
            // 
            this.消费查询ToolStripMenuItem.Name = "消费查询ToolStripMenuItem";
            this.消费查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.消费查询ToolStripMenuItem.Text = "消费查询";
            // 
            // 结账ToolStripMenuItem
            // 
            this.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem";
            this.结账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结账ToolStripMenuItem.Text = "结账";
            this.结账ToolStripMenuItem.Click += new System.EventHandler(this.结账ToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 83);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 83);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 83);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox5.Location = new System.Drawing.Point(2, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 83);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox6.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 75);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox7.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 75);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox8.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 75);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox9.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox9.Location = new System.Drawing.Point(1, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(70, 75);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox10.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox10.Location = new System.Drawing.Point(1, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(70, 75);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox11.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(70, 75);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox12.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox12.Location = new System.Drawing.Point(1, 0);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(70, 75);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox13.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox13.Location = new System.Drawing.Point(0, 0);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(70, 75);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox14.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox14.Location = new System.Drawing.Point(1, 0);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(70, 75);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox15.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox15.Location = new System.Drawing.Point(1, 0);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(70, 75);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox16.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox16.Location = new System.Drawing.Point(0, 0);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(70, 75);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox17.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox17.Location = new System.Drawing.Point(0, 0);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(70, 75);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox18.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox18.Location = new System.Drawing.Point(0, 0);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(70, 75);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox19.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox19.Location = new System.Drawing.Point(0, 0);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(70, 75);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            // 
            // lblroom2
            // 
            this.lblroom2.AutoSize = true;
            this.lblroom2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroom2.Location = new System.Drawing.Point(12, 85);
            this.lblroom2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroom2.Name = "lblroom2";
            this.lblroom2.Size = new System.Drawing.Size(48, 16);
            this.lblroom2.TabIndex = 1;
            this.lblroom2.Text = "餐台2";
            this.lblroom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblroom3
            // 
            this.lblroom3.AutoSize = true;
            this.lblroom3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroom3.Location = new System.Drawing.Point(11, 84);
            this.lblroom3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroom3.Name = "lblroom3";
            this.lblroom3.Size = new System.Drawing.Size(48, 16);
            this.lblroom3.TabIndex = 1;
            this.lblroom3.Text = "餐台3";
            this.lblroom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblroom4
            // 
            this.lblroom4.AutoSize = true;
            this.lblroom4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroom4.Location = new System.Drawing.Point(11, 85);
            this.lblroom4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroom4.Name = "lblroom4";
            this.lblroom4.Size = new System.Drawing.Size(48, 16);
            this.lblroom4.TabIndex = 1;
            this.lblroom4.Text = "餐台4";
            this.lblroom4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblroom5
            // 
            this.lblroom5.AutoSize = true;
            this.lblroom5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblroom5.Location = new System.Drawing.Point(11, 84);
            this.lblroom5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroom5.Name = "lblroom5";
            this.lblroom5.Size = new System.Drawing.Size(48, 16);
            this.lblroom5.TabIndex = 1;
            this.lblroom5.Text = "餐台5";
            this.lblroom5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ContextMenuStrip = this.contextMenuStrip1;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "餐台10";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ContextMenuStrip = this.contextMenuStrip1;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(11, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "餐台9";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ContextMenuStrip = this.contextMenuStrip1;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "餐台8";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ContextMenuStrip = this.contextMenuStrip1;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(13, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "餐台7";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ContextMenuStrip = this.contextMenuStrip1;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(12, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "餐台6";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ContextMenuStrip = this.contextMenuStrip1;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(12, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "餐台11";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ContextMenuStrip = this.contextMenuStrip1;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(13, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "餐台12";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ContextMenuStrip = this.contextMenuStrip1;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(12, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "餐台13";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ContextMenuStrip = this.contextMenuStrip1;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(11, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "餐台14";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ContextMenuStrip = this.contextMenuStrip1;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(12, 79);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "餐台15";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ContextMenuStrip = this.contextMenuStrip1;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(12, 82);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "餐台16";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ContextMenuStrip = this.contextMenuStrip1;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(12, 82);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "餐台17";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ContextMenuStrip = this.contextMenuStrip1;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(12, 82);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "餐台18";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ContextMenuStrip = this.contextMenuStrip1;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(11, 82);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "餐台19";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ContextMenuStrip = this.contextMenuStrip1;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(11, 82);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "餐台20";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox20.Image = global::餐饮管理系统.Properties.Resources.餐桌__2_;
            this.pictureBox20.Location = new System.Drawing.Point(0, 0);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(70, 75);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "职位：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 285);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label4";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(79, 332);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(41, 12);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "label5";
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(79, 385);
            this.lblDuty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(41, 12);
            this.lblDuty.TabIndex = 7;
            this.lblDuty.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // picWaiter
            // 
            this.picWaiter.Location = new System.Drawing.Point(24, 97);
            this.picWaiter.Margin = new System.Windows.Forms.Padding(2);
            this.picWaiter.Name = "picWaiter";
            this.picWaiter.Size = new System.Drawing.Size(93, 156);
            this.picWaiter.TabIndex = 1;
            this.picWaiter.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.餐台1号, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel20, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(215, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // 餐台1号
            // 
            this.餐台1号.BackColor = System.Drawing.SystemColors.Control;
            this.餐台1号.ContextMenuStrip = this.contextMenuStrip1;
            this.餐台1号.Controls.Add(this.pictureBox1);
            this.餐台1号.Controls.Add(this.lblroom1);
            this.餐台1号.Dock = System.Windows.Forms.DockStyle.Fill;
            this.餐台1号.Location = new System.Drawing.Point(3, 3);
            this.餐台1号.Name = "餐台1号";
            this.餐台1号.Size = new System.Drawing.Size(71, 104);
            this.餐台1号.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.ContextMenuStrip = this.contextMenuStrip1;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblroom2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(80, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 104);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblroom3);
            this.panel3.Location = new System.Drawing.Point(157, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 104);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.ContextMenuStrip = this.contextMenuStrip1;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblroom4);
            this.panel4.Location = new System.Drawing.Point(234, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(71, 104);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.ContextMenuStrip = this.contextMenuStrip1;
            this.panel5.Controls.Add(this.lblroom5);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Location = new System.Drawing.Point(311, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 104);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.ContextMenuStrip = this.contextMenuStrip1;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(3, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(71, 104);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.ContextMenuStrip = this.contextMenuStrip1;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(80, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(71, 104);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.ContextMenuStrip = this.contextMenuStrip1;
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(157, 113);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(71, 104);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.ContextMenuStrip = this.contextMenuStrip1;
            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(234, 113);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(71, 104);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.ContextMenuStrip = this.contextMenuStrip1;
            this.panel10.Controls.Add(this.pictureBox10);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(311, 113);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(71, 104);
            this.panel10.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.ContextMenuStrip = this.contextMenuStrip1;
            this.panel15.Controls.Add(this.pictureBox11);
            this.panel15.Controls.Add(this.label18);
            this.panel15.Location = new System.Drawing.Point(311, 223);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(71, 104);
            this.panel15.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.ContextMenuStrip = this.contextMenuStrip1;
            this.panel14.Controls.Add(this.pictureBox14);
            this.panel14.Controls.Add(this.label17);
            this.panel14.Location = new System.Drawing.Point(234, 223);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(71, 104);
            this.panel14.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.ContextMenuStrip = this.contextMenuStrip1;
            this.panel13.Controls.Add(this.pictureBox15);
            this.panel13.Controls.Add(this.label16);
            this.panel13.Location = new System.Drawing.Point(157, 223);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(71, 104);
            this.panel13.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.ContextMenuStrip = this.contextMenuStrip1;
            this.panel12.Controls.Add(this.pictureBox18);
            this.panel12.Controls.Add(this.label15);
            this.panel12.Location = new System.Drawing.Point(80, 223);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(71, 104);
            this.panel12.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.ContextMenuStrip = this.contextMenuStrip1;
            this.panel11.Controls.Add(this.pictureBox19);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Location = new System.Drawing.Point(3, 223);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(71, 104);
            this.panel11.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.ContextMenuStrip = this.contextMenuStrip1;
            this.panel16.Controls.Add(this.pictureBox20);
            this.panel16.Controls.Add(this.label19);
            this.panel16.Location = new System.Drawing.Point(3, 333);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(71, 104);
            this.panel16.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.ContextMenuStrip = this.contextMenuStrip1;
            this.panel17.Controls.Add(this.pictureBox17);
            this.panel17.Controls.Add(this.label20);
            this.panel17.Location = new System.Drawing.Point(80, 333);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(71, 104);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.ContextMenuStrip = this.contextMenuStrip1;
            this.panel18.Controls.Add(this.pictureBox16);
            this.panel18.Controls.Add(this.label21);
            this.panel18.Location = new System.Drawing.Point(157, 333);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(71, 104);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.ContextMenuStrip = this.contextMenuStrip1;
            this.panel19.Controls.Add(this.pictureBox13);
            this.panel19.Controls.Add(this.label22);
            this.panel19.Location = new System.Drawing.Point(234, 333);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(71, 104);
            this.panel19.TabIndex = 2;
            // 
            // panel20
            // 
            this.panel20.ContextMenuStrip = this.contextMenuStrip1;
            this.panel20.Controls.Add(this.pictureBox12);
            this.panel20.Controls.Add(this.label23);
            this.panel20.Location = new System.Drawing.Point(311, 333);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(71, 104);
            this.panel20.TabIndex = 2;
            // 
            // lvdesk
            // 
            this.lvdesk.ContextMenuStrip = this.contextMenuStrip1;
            this.lvdesk.HideSelection = false;
            this.lvdesk.LargeImageList = this.imageList1;
            this.lvdesk.Location = new System.Drawing.Point(12, 531);
            this.lvdesk.MultiSelect = false;
            this.lvdesk.Name = "lvdesk";
            this.lvdesk.Size = new System.Drawing.Size(603, 234);
            this.lvdesk.TabIndex = 9;
            this.lvdesk.UseCompatibleStateImageBehavior = false;
            this.lvdesk.Click += new System.EventHandler(this.Lvdesk_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a_1.jpg");
            this.imageList1.Images.SetKeyName(1, "a_2.jpg");
            // 
            // frmWaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 777);
            this.Controls.Add(this.lvdesk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDuty);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWaiter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWaiter";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FrmWaiter_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaiter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.餐台1号.ResumeLayout(false);
            this.餐台1号.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        /* private void SourceControl_ContextMenuStripChanged(object sender, CancelEventArgs e)
{
    contextMenuStrip1.SourceControl.ContextMenuStrip = contextMenuStrip2;
}        
private void SourceControl_ContextMenuStripChanged(object sender, CancelEventArgs e)
{
    contextMenuStrip1.SourceControl  contextMenuStrip1.SourceControl.ContextMenuStripChanged += SourceControl_ContextMenuStripChanged; ;.ContextMenuStrip = contextMenuStrip2;
}*/



        #endregion
        private System.Windows.Forms.PictureBox picWaiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.PictureBox pictureBox1;
       /* private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点加菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;*/
        private System.Windows.Forms.Label lblroom1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label lblroom2;
        private System.Windows.Forms.Label lblroom3;
        private System.Windows.Forms.Label lblroom4;
        private System.Windows.Forms.Label lblroom5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点加菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel 餐台1号;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ToolStripMenuItem 消费查询ToolStripMenuItem;
        public System.Windows.Forms.ListView lvdesk;
        private System.Windows.Forms.ImageList imageList1;
        /* private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem 取消开台ToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem 消费查询ToolStripMenuItem;*/
    }
}