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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            string ma = "SP009";
            string ten = "Sữa Vinamilk";
            string loai = "To";
            DateTime nxs = new DateTime(2024, 8, 19);
            SanPham sp = new SanPham(ma, ten, loai, nxs);
            lblSanPham.Text = sp.HienThi();
        }
    }
}
