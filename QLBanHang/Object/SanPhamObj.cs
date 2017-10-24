using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class SanPhamObj
    {
        string ma, ten, donvi;
        double dongia;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

         public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Donvi
        {
             get { return donvi; }
             set { donvi = value; }
        }

        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public SanPhamObj() { }
        public SanPhamObj(string ma, string ten, string donvi, double dongia)
        {
            this.ma = ma;
            this.ten = ten;
            this.donvi = donvi;
            this.dongia = dongia;
        }
    }
}
