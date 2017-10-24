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
    class HoaDonCtrl
    {
        HoaDonMod hdMod = new HoaDonMod();
        public DataTable getData()
        {
            return hdMod.GetData();
        }

        public bool addData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }

        public bool delData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}
