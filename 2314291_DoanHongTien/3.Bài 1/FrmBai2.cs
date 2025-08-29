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
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txbDonGia.Text = "100000";
                    break;
                case 1:
                    txbDonGia.Text = "2000000";
                    break;
                case 2:
                    txbDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txbDonGia.Text);
            int soLuong = int.Parse(txbSoluong.Text);
            double thanhtien = donGia * soLuong;
            if (rdChuyenKhoan.Checked)

                thanhtien = donGia * soLuong * 0.95;

            label5.Text = thanhtien.ToString();
        }
    }
}
