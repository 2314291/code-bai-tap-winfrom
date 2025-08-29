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
    public partial class frmBai3 : Form
    {
        ChaoHoi ch = new ChaoHoi();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            string hoten = txtTen.Text;
            bool gioitinh = rdNam.Checked;
            ch.Chao(hoten, gioitinh);
        }

        private void btnUC_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = ch.USCLN(m, n);
            lblkq.Text = kq.ToString();
        }
    }
}
