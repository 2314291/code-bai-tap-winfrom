using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bài_4
{
    internal class ChaoHoi
    {
        public void Chao(string hoten, bool gioitinh)
        {
            if (gioitinh)
                MessageBox.Show("Chào ông" + hoten);
            else
                MessageBox.Show("Chào Bà" + hoten);
        }
        public int USCLN(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                    m -= n;
                else
                    n -= m;
            }
            return m;
        }
    }
}
