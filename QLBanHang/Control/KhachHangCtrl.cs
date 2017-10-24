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
    class KhachHangCtrl
    {
        KhachHangMod khMod = new KhachHangMod();
        public DataTable getData()
        {
            return khMod.GetData();
        }

        public bool addData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }

        public bool updData(KhachHangObj khObj)
        {
            return khMod.UpdData(khObj);
        }

        public bool delData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
