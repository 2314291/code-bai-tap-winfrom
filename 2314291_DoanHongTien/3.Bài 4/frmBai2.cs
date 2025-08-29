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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            int s = int.Parse(txtDiemLT.Text);
            int s1 = int.Parse(txtDiemTH.Text);
            string kq;
            if (s < 5 || s1 < 5)
                kq = "yếu";
            else
            {
                double diemtb = (s + s1) / 2;
                if (diemtb < 7)
                    kq = "trung bình";
                else if (diemtb < 8)
                    kq = "khá";
                else if (diemtb < 9)
                    kq = "giỏi";
                else
                    kq = "Xuất sắc";
            }
            lblkq.Text = kq;
        }
    }
}
