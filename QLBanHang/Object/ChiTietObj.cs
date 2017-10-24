using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class ChiTietObj
    {
        string mahd, masp;
        int sl;
        double gg;

        public string Masp
        {
          get { return masp; }
          set { masp = value; }
        }

        public string Mahd
        {
          get { return mahd; }
          set { mahd = value; }
        }
         
        public int Sl
        {
          get { return sl; }
          set { sl = value; }
        }
         
        public double Gg
        {
          get { return gg; }
          set { gg = value; }
        }
         
        public ChiTietObj() { }
        public ChiTietObj(string mahd,string masp, int sl, double gg)
        {
            this.mahd = mahd;
            this.masp = masp;
            this.sl = sl;
            this.gg = gg;
        }
    }
}
