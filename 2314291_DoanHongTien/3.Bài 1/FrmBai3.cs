using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bài_1
{
    public partial class FrmBai3 : Form
    {
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;
            if (rdTinhtong.Checked)
                Tinhtoan.CongHaiSo(a, b, ref kq);
            else
                Tinhtoan.TongDaySo(n);
            lblKq.Text = kq.ToString();
        }
    }
}
