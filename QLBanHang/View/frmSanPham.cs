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
    public partial class frmSanPham : Form
    {
        SanPhamCtrl spctr = new SanPhamCtrl();
        private int flag = 0;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable dtSanPham = new System.Data.DataTable();
            dtSanPham = spctr.getData();
            dgvDanhSachSP.DataSource = dtSanPham;
            bingding();
            DisEnl(false);
        }

        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "MaSP");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "TenSP");
            txtdonvi.DataBindings.Clear();
            txtdonvi.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "Donvitinh");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "Dongia");
            
        }

        private void clearData()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdonvi.Text = "";
            txtdongia.Text = "";
            
        }

        private void addData(SanPhamObj sp)
        {
            sp.Ma = txtma.Text.Trim();
            sp.Ten = txtten.Text.Trim();
            sp.Donvi = txtdonvi.Text.Trim();
            sp.Dongia = double.Parse(txtdongia.Text.Trim());
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
            txtdonvi.Enabled = e;
            txtdongia.Enabled = e;
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
                if (spctr.delData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xòa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmSanPham_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPhamObj spObj = new SanPhamObj();
            addData(spObj);
            if (flag == 0)
            {   // them moi
                if (spctr.addData(spObj))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                if (flag == 1)
                {
                    // sua
                    if (spctr.updData(spObj))
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            frmSanPham_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmSanPham_Load(sender, e);
            else
                return;
        }

        
    }
}
