using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Object
{
    class NhanVienObj
    {
        string ma;
        string ho, ten, diachi, dienthoai;

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
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

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }

        public NhanVienObj() { }
        public NhanVienObj(string ma, string ho, string ten, string diachi, string dienthoai)
        {
            this.ma = ma;
            this.ho = ho;
            this.ten = ten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
        }
    }
}
