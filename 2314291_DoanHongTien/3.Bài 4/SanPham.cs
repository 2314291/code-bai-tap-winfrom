using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bài_4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham()
        {

        }
        public SanPham(string ma, string ten, string loai, DateTime nsx)
        {
            MaSanPham = ma;
            TenSanPham = ten;
            LoaiSanPham = loai;
            NgaySanXuat = nsx;
        }
        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaSanPham, TenSanPham, LoaiSanPham, NgaySanXuat, NamHetHan());
        }
    }
}
