using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2314291_DoanHongTien_De1
{
    internal class QuanLyKhachHang
    {
        public List<KhachHang> ds {  get; set; } = new List<KhachHang>();
        public void Luu(KhachHang kh)
        {
            var tt = ds.FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            if (tt != null)
            {
                tt.TenKhachHang = kh.TenKhachHang;
                tt.SDT = kh.SDT;
                tt.DiaChi = kh.DiaChi;
            }
            else
            {
                ds.Add(kh);
            }
        }
    }
}
