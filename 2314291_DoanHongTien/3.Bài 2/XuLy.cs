using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bài_2
{
    internal class XuLy
    {
        public void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho + " " + ten;
        }
        public long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
    }
}
