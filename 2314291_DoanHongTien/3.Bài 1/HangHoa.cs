using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bài_1
{
    internal class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string TDV { get; set; }
        public int soLuong { get; set; }
        public int DonGia { get; set; }
        public HangHoa()
        {

        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, TDV, soLuong, DonGia);
        }
    }
}
