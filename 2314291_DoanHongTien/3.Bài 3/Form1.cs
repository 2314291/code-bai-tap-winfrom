using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmbt1_Click(object sender, EventArgs e)
        {
            var f = new frmBai1();
            f.ShowDialog();
        }

        private void frm2_Click(object sender, EventArgs e)
        {
            var f = new frmBai2();
            f.ShowDialog();
        }

        private void frm3_Click(object sender, EventArgs e)
        {
            var f = new frmBai3();
            f.ShowDialog();
        }
    }
}
