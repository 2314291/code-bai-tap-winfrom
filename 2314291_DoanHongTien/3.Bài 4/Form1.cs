using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bài_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmBai1();
            f.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmBai2();
            f.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmBai3();
            f.ShowDialog();
        }
    }
}
