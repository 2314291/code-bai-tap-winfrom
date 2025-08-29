using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bài_3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime Ngaysinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }
        public NhanVien(string ma, string hoten, DateTime ngaysinh, double hsl, double hspc)
        {
            MaNV = ma;
            HoTen = hoten;
            Ngaysinh = ngaysinh;
            HeSoLuong = hsl;
            HeSoPhuCap = hspc;
        }
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {

            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", MaNV, HoTen, Ngaysinh, HeSoLuong, HeSoPhuCap, TongLuong());
        }
    }
}
