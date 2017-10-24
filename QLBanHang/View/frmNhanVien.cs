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
    public partial class frmNhanVien : Form
    {
        NhanVienCtrlcs nvctr = new NhanVienCtrlcs();
        private int flag = 0;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new System.Data.DataTable();
            dtNhanVien = nvctr.getData();
            dgvDanhSachNV.DataSource = dtNhanVien;
            bingding();
            DisEnl(false);
        }

        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MaNV");
            txtho.DataBindings.Clear();
            txtho.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "HoNV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Ten");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Diachi");
            txtdienthoai.DataBindings.Clear();
            txtdienthoai.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Dienthoai");
        }

        private void clearData()
        {
            txtma.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
        }

        private void addData(NhanVienObj nv)
        {
            nv.Ma = txtma.Text.Trim();
            nv.Ho = txtho.Text.Trim();
            nv.Ten = txtten.Text.Trim();
            nv.DiaChi = txtdiachi.Text.Trim();
            nv.DienThoai = txtdienthoai.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtma.Enabled = e;
            txtho.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtdienthoai.Enabled = e;
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
            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa?", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Xóa
                if (nvctr.delData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xòa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nvObj = new NhanVienObj();
            addData(nvObj);
            if (flag == 0)
            {   // them moi
                if (nvctr.addData(nvObj))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                // sua
                if (nvctr.updData(nvObj))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhanVien_Load(sender, e);
            else
                return;
        }

        

       
    }
}
