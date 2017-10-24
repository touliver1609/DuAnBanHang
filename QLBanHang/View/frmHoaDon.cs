using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLBanHang.Control;
using QLBanHang.Object;


namespace QLBanHang.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonCtrl hdCtrl = new HoaDonCtrl();
        ChiTietCtrl ctCtrl = new ChiTietCtrl();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = hdCtrl.getData();
            dgvDSHD.DataSource = dt;
            bingding();
        }

        private void bingding()
        {
            txtmahd.DataBindings.Clear();
            txtmahd.DataBindings.Add("Text",dgvDSHD.DataSource,"MaHD");
            txtngaylap.DataBindings.Clear();
            txtngaylap.DataBindings.Add("Text", dgvDSHD.DataSource, "NgayLapHD");
            txtnv.DataBindings.Clear();
            txtnv.DataBindings.Add("Text", dgvDSHD.DataSource, "Ten");
            cmbKH.DataBindings.Clear();
            cmbKH.DataBindings.Add("Text", dgvDSHD.DataSource, "TenKH");
        }

        private void Dis_Enl(bool e)
        {
            txtmahd.Enabled = e;
            txtnv.Enabled = e;
            cmbKH.Enabled = e;
            btnTao.Enabled = !e;
            btnXoa.Enabled = !e;
            btnIn.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbSP.Enabled = e;
            txtSL.Enabled = e;
        }

        private void txtmahd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtrl.getData(txtmahd.Text.Trim());
                dgvDSSP.DataSource = dt;

            }
            catch
            {
                dgvDSSP.DataSource = null;
            }
        }

        
    }
}
