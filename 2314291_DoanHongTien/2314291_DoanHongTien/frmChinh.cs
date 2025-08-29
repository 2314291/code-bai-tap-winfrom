using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2314291_DoanHongTien
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void from_Load(object sender, EventArgs e)
        {

        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmBai1();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thật sự là thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmBai2();
            f.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmBai3();
            f.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmBai4();
            f.ShowDialog();
        }
    }
}
