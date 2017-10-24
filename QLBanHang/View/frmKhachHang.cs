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
using QLBanHang.Model;
namespace QLBanHang.View
{
    public partial class frmKhachHang : Form
    {
        KhachHangCtrl khctr = new KhachHangCtrl();
        private int flag = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = new System.Data.DataTable();
            dtKhachHang = khctr.getData();
            dgvDanhSachKH.DataSource = dtKhachHang;
            bingding();
            DisEnl(false);
        }

        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "MaKH");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "TenKH");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "Diachi");
            txtdt.DataBindings.Clear();
            txtdt.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "Dienthoai");
            txtfax.DataBindings.Clear();
            txtfax.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "Fax");
        }

        private void clearData()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdt.Text = "";
            txtfax.Text = "";
        }

        private void addData(KhachHangObj kh)
        {
            kh.Ma = txtma.Text.Trim();
            kh.Ten = txtten.Text.Trim();
            kh.DiaChi = txtdiachi.Text.Trim();
            kh.DienThoai = txtdt.Text.Trim();
            kh.Fax = txtfax.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtma.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtdt.Enabled = e;
            txtfax.Enabled = e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            DisEnl(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Xóa
                if (khctr.delData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xòa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmKhachHang_Load(sender, e);
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangObj khObj = new KhachHangObj();
            addData(khObj);
            if (flag == 0)
            {   // them moi
                if (khctr.addData(khObj))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // sua
                if (khctr.updData(khObj))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }
        
    }
}
