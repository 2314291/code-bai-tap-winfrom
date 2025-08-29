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
    public partial class FrmBai1cs : Form
    {
        public FrmBai1cs()
        {
            InitializeComponent();
        }

        private void lblThongbao_Click(object sender, EventArgs e)
        {

        }

        private void FrmBai1cs_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.TDV = "Cái";
            hh.soLuong = 4;
            hh.DonGia = 200000;
            lblThongbao.Text = hh.HienThi();
        }
    }
}
