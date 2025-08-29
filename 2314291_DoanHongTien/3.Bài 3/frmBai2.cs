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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtNhapN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhKq_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapN.Text);
            long kq = 0;
            if (rdTong.Checked)
            {
                for (int i = 1; i <= n; i++)
                {
                    kq += i;
                }
            }
            else if (rdTinhN.Checked)
            {
                kq = 1;
                for (int i = 1; i <= n; i++)
                {
                    kq *= i;
                }
            }
            lblKq.Text = kq.ToString();
        }
    }
}
