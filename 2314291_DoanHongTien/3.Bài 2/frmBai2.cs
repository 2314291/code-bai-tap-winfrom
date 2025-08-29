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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtSoThuNhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhKq_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtSoThuNhat.Text);
            double so2 = double.Parse(txtSoThuHai.Text);
            double kq = 0;
            if (rdCong.Checked)
                kq = so1 + so2;
            else if (rdTru.Checked)
                kq = so1 - so2;
            else if (rdNhan.Checked)
                kq = so1 * so2;
            else if (rdChia.Checked)
            {
                if (so2 != 0)
                    kq = so1 / so2;
                else
                    MessageBox.Show("Khong the chia 0");
            }
            lblXemKq.Text = kq.ToString();
        }
    }
}
