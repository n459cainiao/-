using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 餐饮管理系统
{
    public partial class frmWaiter : Form
    {
        public frmWaiter()
        {
            InitializeComponent();
        }

        private void FrmWaiter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
