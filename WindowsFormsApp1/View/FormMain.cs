using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanThuoc.View
{
    public partial class formMain : Form
    {
        static formMain _obj;

        public static formMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new formMain();
                }
                return _obj;
            }
        }

        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //Show
            screenTrangChu.Show();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();

        }

        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            //show
            screenTrangChu.Show();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuBanThuoc_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            //show
            screenBanThuoc.Show();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThongKeHoaDonBan_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            //Show
            screenHoaDonBanThongKe.Show();

            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThongKeKhachHang_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();

            //Show
            screenKhachHangThongKe.Show();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuHoaDonNhapThemMoi_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();

            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            //Show
            screenHoaDonNhapThemMoi.Show();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuHoaDonNhapThongKe_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            //Show
            screenHoaDonNhapThongKe.Show();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuNhaCungCap_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            //Show
            screenNhaCungCap.Show();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThemMoiThuoc_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            //Show
            screemThuocThemMoi.Show();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThongKeThuoc_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            //Show
            screenThuocThongKe.Show();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuCongDung_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            //Show
            screenCauHinhCongDung.Show();
        }

        private void menuDonViTinh_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            //Show
            screenCauHinhDonViTinh.Show();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuDangDieuChe_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            //Show
            screenCauHinhDangDieuChe.Show();
            screenCauHinhCongDung.Hide();
        }

        private void menuNuocSanXuat_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            //Show
            screenCauHinhNuocSanXuat.Show();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThemMoiNhanVien_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            //Show
            screenNhanVienThemMoi.Show();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuThongKeNhanVien_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            //Show
            screenNhanVienThongKe.Show();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuChuyenMon_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            screenTrinhDo.Hide();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            //Show
            screenChuyenMon.Show();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

        private void menuTrinhDo_Click(object sender, EventArgs e)
        {
            screenTrangChu.Hide();

            screenBanThuoc.Hide();
            screenNhaCungCap.Hide();
            screenKhachHangThongKe.Hide();

            //Show
            screenTrinhDo.Show();
            screenNhanVienThongKe.Hide();
            screenNhanVienThemMoi.Hide();
            screenChuyenMon.Hide();

            screenThuocThongKe.Hide();
            screemThuocThemMoi.Hide();

            screenHoaDonBanThongKe.Hide();
            screenHoaDonNhapThongKe.Hide();
            screenHoaDonNhapThemMoi.Hide();

            screenCauHinhNuocSanXuat.Hide();
            screenCauHinhDonViTinh.Hide();
            screenCauHinhDangDieuChe.Hide();
            screenCauHinhCongDung.Hide();
        }

    }
}
