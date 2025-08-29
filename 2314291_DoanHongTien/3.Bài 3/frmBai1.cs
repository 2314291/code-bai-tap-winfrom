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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            string ma = "NV0012";
            string hoten = "Đoàn Xung Kích";
            DateTime ngaysinh = DateTime.Parse("12/02/1999");
            double hsl = 10;
            double hspc = 1.5;
            NhanVien nv = new NhanVien(ma, hoten, ngaysinh, hsl, hspc);
            lblThongTin.Text = nv.HienThi();
        }
    }
}
