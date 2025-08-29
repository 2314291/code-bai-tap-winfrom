using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bài_2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi() { }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4} ", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
