using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class HoaDonObj
    {
        string mahd, ngaylap, makh, manv;

        public string Manv      
        {
            get { return manv; }
            set { manv = value; }
        }

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        public string Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }

        public HoaDonObj() { }
        public HoaDonObj(string mahd,string ngaylap, string makh, string manv)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.makh = makh;
            this.manv = manv;
        }

    }
}
