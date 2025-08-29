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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "tb01";
            tb.TenThietBi = "May cua";
            tb.NuocSanXuat = "japan";
            tb.DonGia = 130000;
            tb.SoLuong = 4;
            lblThongbao.Text = tb.HienThi();
        }
    }
}
