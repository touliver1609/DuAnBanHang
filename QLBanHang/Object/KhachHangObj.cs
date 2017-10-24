using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class KhachHangObj
    {
        string ma, ten, diachi, dienthoai,fax;


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
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Fax
        {
          get { return fax; }
          set { fax = value; }
        }
        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string diachi, string dienthoai, string fax)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.fax = fax;
        }
    }
}
