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
    public partial class frmBai3 : Form
    {
        XuLy xl = new XuLy();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btntach_Click(object sender, EventArgs e)
        {
            string ho, ten;
            xl.TachChuoi(txtHoten.Text, out ho, out ten);
            lblHo.Text = ho;
            lblTen.Text = ten;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            if (xl.ThuTu(n1, n2))
                lblKq.Text = " là 2 số liên tiếp.";
            else
                lblKq.Text = " Không liên tiếp";
        }
    }
}
