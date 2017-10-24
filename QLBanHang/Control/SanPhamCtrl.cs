using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanHang.Object;
using QLBanHang.Model;

namespace QLBanHang.Control
{
    class SanPhamCtrl
    {
        SanPhamMod spMod = new SanPhamMod();
        public DataTable getData()
        {
            return spMod.GetData();
        }

        public bool addData(SanPhamObj spObj)
        {
            return spMod.AddData(spObj);
        }

        public bool updData(SanPhamObj spObj)
        {
            return spMod.UpdData(spObj);
        }

        public bool delData(string ma)
        {
            return spMod.DelData(ma);
        }
    }
}
