using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanThuoc.View
{
    public partial class screenTrangChu : UserControl
    {
        public screenTrangChu()
        {
            InitializeComponent();
        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Show();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Hide();

            this.ParentForm.Controls["screenThuocThongKe"].Hide();
            this.ParentForm.Controls["screemThuocThemMoi"].Hide();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Hide();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Hide();
        }

        private void btnThongKeHoaDonBan_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Hide();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Show();

            this.ParentForm.Controls["screenThuocThongKe"].Hide();
            this.ParentForm.Controls["screemThuocThemMoi"].Hide();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Hide();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Hide();
        }

        private void btnThemMoiThuoc_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Hide();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Hide();

            this.ParentForm.Controls["screenThuocThongKe"].Hide();
            this.ParentForm.Controls["screemThuocThemMoi"].Show();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Hide();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Hide();
        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Hide();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Hide();

            this.ParentForm.Controls["screenThuocThongKe"].Show();
            this.ParentForm.Controls["screemThuocThemMoi"].Hide();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Hide();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Hide();
        }

        private void btnThemMoiHoaDonNhap_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Hide();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Hide();

            this.ParentForm.Controls["screenThuocThongKe"].Hide();
            this.ParentForm.Controls["screemThuocThemMoi"].Hide();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Hide();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Show();
        }

        private void btnThongKeHoaDonNhap_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls["screenTrangChu"].Hide();

            this.ParentForm.Controls["screenBanThuoc"].Hide();
            this.ParentForm.Controls["screenHoaDonBanThongKe"].Hide();

            this.ParentForm.Controls["screenThuocThongKe"].Hide();
            this.ParentForm.Controls["screemThuocThemMoi"].Hide();

            this.ParentForm.Controls["screenHoaDonNhapThongKe"].Show();
            this.ParentForm.Controls["screenHoaDonNhapThemMoi"].Hide();
        }
    }
}
