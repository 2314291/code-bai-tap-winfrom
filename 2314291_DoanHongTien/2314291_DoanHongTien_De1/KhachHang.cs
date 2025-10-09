using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2314291_DoanHongTien_De1
{
    internal class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT {  get; set; }
        public string DiaChi { get; set; }
        public KhachHang() { }
        public KhachHang (string maHk,string tenKH, string sdt, string diachi)
        {
            MaKhachHang = maHk;
            TenKhachHang =tenKH;
            SDT = sdt;
            DiaChi = diachi;
        }
    }
}
