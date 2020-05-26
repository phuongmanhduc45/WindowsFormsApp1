using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
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
            
        }

        private void btnThongKeHoaDonBan_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoiThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoiHoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeHoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangDieuChe_Click(object sender, EventArgs e)
        {

        }

        private void btnCongDung_Click(object sender, EventArgs e)
        {

        }

        private void btnNuocSanXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

        }
    }
}
