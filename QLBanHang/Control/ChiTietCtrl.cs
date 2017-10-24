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
    class ChiTietCtrl
    {
        ChiTietMod ctMod = new ChiTietMod();
        public DataTable getData(string ma)
        {
            return ctMod.GetData(ma);
        }

        public bool addData(ChiTietObj ctObj)
        {
            return ctMod.AddData(ctObj);
        }

        public bool delData(string ma)
        {
            return ctMod.DelData(ma);
        }
    }
}
