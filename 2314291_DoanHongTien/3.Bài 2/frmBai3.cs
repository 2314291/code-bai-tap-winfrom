using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bài_2
{
    public partial class frmBai3 : Form
    {
        XuLy xl = new XuLy();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoi_Click(object sender, EventArgs e)
        {
            string k;
            xl.NoiChuoi(txtHo.Text, txtTen.Text, out k);
            label4.Text = k.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapsoN.Text);
            long kq = xl.GiaiThua(n);
            lblKq.Text = n + "! = " + kq.ToString();
        }
    }
}
