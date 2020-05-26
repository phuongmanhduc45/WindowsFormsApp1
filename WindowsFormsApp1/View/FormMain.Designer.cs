namespace WindowsFormsApp1.View
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanThuocMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapThuocMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDonNhapThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDonNhapThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuCauHinhThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCongDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangDieuChe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuocSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCauHinhNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChuyenMon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrinhDo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenCauHinhCongDung = new WindowsFormsApp1.View.CauHinhCongDung();
            this.screenCauHinhDangDieuChe = new WindowsFormsApp1.View.CauHinhDangDieuChe();
            this.screenCauHinhDonViTinh = new WindowsFormsApp1.View.CauHinhDonViTinh();
            this.screenCauHinhNuocSanXuat = new WindowsFormsApp1.View.CauHinhNuocSanXuat();
            this.screenHoaDonNhapThemMoi = new WindowsFormsApp1.View.HoaDonNhapThemMoi();
            this.screenHoaDonNhapThongKe = new WindowsFormsApp1.View.HoaDonNhapThongKe();
            this.screenHoaDonBanThongKe = new WindowsFormsApp1.View.ThongKeHoaDonBan();
            this.screemThuocThemMoi = new WindowsFormsApp1.View.ThuocThemMoi();
            this.screenThuocThongKe = new WindowsFormsApp1.View.ThuocThongKe();
            this.screenChuyenMon = new WindowsFormsApp1.View.NhanVien.CauHinh.ChuyenMon();
            this.screenNhanVienThemMoi = new WindowsFormsApp1.View.NhanVien.NhanVienThemMoi();
            this.screenNhanVienThongKe = new WindowsFormsApp1.View.NhanVien.NhanVienThongKe();
            this.screenTrinhDo = new WindowsFormsApp1.View.NhanVien.TrinhDo();
            this.screenKhachHangThongKe = new WindowsFormsApp1.View.BanThuoc.KhachHangThongKe();
            this.screenNhaCungCap = new WindowsFormsApp1.View.NhapThuoc.NhaCungCap();
            this.screenBanThuoc = new WindowsFormsApp1.View.screenBanThuoc();
            this.screenTrangChu = new WindowsFormsApp1.View.screenTrangChu();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrangChu,
            this.menuBanThuocMenu,
            this.menuNhapThuocMenu,
            this.menuThuoc,
            this.menuNhanVien,
            this.menuUser});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(845, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuTrangChu
            // 
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Size = new System.Drawing.Size(73, 20);
            this.menuTrangChu.Text = "Trang Chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.menuTrangChu_Click);
            // 
            // menuBanThuocMenu
            // 
            this.menuBanThuocMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanThuoc,
            this.menuThongKeHoaDonBan,
            this.menuThongKeKhachHang});
            this.menuBanThuocMenu.Name = "menuBanThuocMenu";
            this.menuBanThuocMenu.Size = new System.Drawing.Size(75, 20);
            this.menuBanThuocMenu.Text = "Bán Thuốc";
            // 
            // menuBanThuoc
            // 
            this.menuBanThuoc.Name = "menuBanThuoc";
            this.menuBanThuoc.Size = new System.Drawing.Size(196, 22);
            this.menuBanThuoc.Text = "Bán Thuốc";
            this.menuBanThuoc.Click += new System.EventHandler(this.menuBanThuoc_Click);
            // 
            // menuThongKeHoaDonBan
            // 
            this.menuThongKeHoaDonBan.Name = "menuThongKeHoaDonBan";
            this.menuThongKeHoaDonBan.Size = new System.Drawing.Size(196, 22);
            this.menuThongKeHoaDonBan.Text = "Thống kê Hóa Đơn Bán";
            this.menuThongKeHoaDonBan.Click += new System.EventHandler(this.menuThongKeHoaDonBan_Click);
            // 
            // menuThongKeKhachHang
            // 
            this.menuThongKeKhachHang.Name = "menuThongKeKhachHang";
            this.menuThongKeKhachHang.Size = new System.Drawing.Size(196, 22);
            this.menuThongKeKhachHang.Text = "Thống kê Khách Hàng";
            this.menuThongKeKhachHang.Click += new System.EventHandler(this.menuThongKeKhachHang_Click);
            // 
            // menuNhapThuocMenu
            // 
            this.menuNhapThuocMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHoaDonNhapThemMoi,
            this.menuHoaDonNhapThongKe,
            this.toolStripSeparator1,
            this.menuNhaCungCap});
            this.menuNhapThuocMenu.Name = "menuNhapThuocMenu";
            this.menuNhapThuocMenu.Size = new System.Drawing.Size(84, 20);
            this.menuNhapThuocMenu.Text = "Nhập Thuốc";
            // 
            // menuHoaDonNhapThemMoi
            // 
            this.menuHoaDonNhapThemMoi.Name = "menuHoaDonNhapThemMoi";
            this.menuHoaDonNhapThemMoi.Size = new System.Drawing.Size(210, 22);
            this.menuHoaDonNhapThemMoi.Text = "Thêm mới Hóa Đơn Nhập";
            this.menuHoaDonNhapThemMoi.Click += new System.EventHandler(this.menuHoaDonNhapThemMoi_Click);
            // 
            // menuHoaDonNhapThongKe
            // 
            this.menuHoaDonNhapThongKe.Name = "menuHoaDonNhapThongKe";
            this.menuHoaDonNhapThongKe.Size = new System.Drawing.Size(210, 22);
            this.menuHoaDonNhapThongKe.Text = "Thống kê Hóa Đơn Nhập";
            this.menuHoaDonNhapThongKe.Click += new System.EventHandler(this.menuHoaDonNhapThongKe_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // menuNhaCungCap
            // 
            this.menuNhaCungCap.Name = "menuNhaCungCap";
            this.menuNhaCungCap.Size = new System.Drawing.Size(210, 22);
            this.menuNhaCungCap.Text = "Nhà Cung Cấp";
            this.menuNhaCungCap.Click += new System.EventHandler(this.menuNhaCungCap_Click);
            // 
            // menuThuoc
            // 
            this.menuThuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiThuoc,
            this.menuThongKeThuoc,
            this.cấuHìnhToolStripMenuItem,
            this.menuCauHinhThuoc});
            this.menuThuoc.Name = "menuThuoc";
            this.menuThuoc.Size = new System.Drawing.Size(52, 20);
            this.menuThuoc.Text = "Thuốc";
            // 
            // menuThemMoiThuoc
            // 
            this.menuThemMoiThuoc.Name = "menuThemMoiThuoc";
            this.menuThemMoiThuoc.Size = new System.Drawing.Size(159, 22);
            this.menuThemMoiThuoc.Text = "Thêm Mới";
            this.menuThemMoiThuoc.Click += new System.EventHandler(this.menuThemMoiThuoc_Click);
            // 
            // menuThongKeThuoc
            // 
            this.menuThongKeThuoc.Name = "menuThongKeThuoc";
            this.menuThongKeThuoc.Size = new System.Drawing.Size(159, 22);
            this.menuThongKeThuoc.Text = "Thống kê Thuốc";
            this.menuThongKeThuoc.Click += new System.EventHandler(this.menuThongKeThuoc_Click);
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(156, 6);
            // 
            // menuCauHinhThuoc
            // 
            this.menuCauHinhThuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCongDung,
            this.menuDonViTinh,
            this.menuDangDieuChe,
            this.menuNuocSanXuat});
            this.menuCauHinhThuoc.Name = "menuCauHinhThuoc";
            this.menuCauHinhThuoc.Size = new System.Drawing.Size(159, 22);
            this.menuCauHinhThuoc.Text = "Cấu Hình";
            // 
            // menuCongDung
            // 
            this.menuCongDung.Name = "menuCongDung";
            this.menuCongDung.Size = new System.Drawing.Size(153, 22);
            this.menuCongDung.Text = "Công Dụng";
            this.menuCongDung.Click += new System.EventHandler(this.menuCongDung_Click);
            // 
            // menuDonViTinh
            // 
            this.menuDonViTinh.Name = "menuDonViTinh";
            this.menuDonViTinh.Size = new System.Drawing.Size(153, 22);
            this.menuDonViTinh.Text = "Đơn Vị Tính";
            this.menuDonViTinh.Click += new System.EventHandler(this.menuDonViTinh_Click);
            // 
            // menuDangDieuChe
            // 
            this.menuDangDieuChe.Name = "menuDangDieuChe";
            this.menuDangDieuChe.Size = new System.Drawing.Size(153, 22);
            this.menuDangDieuChe.Text = "Dạng Điều Chế";
            this.menuDangDieuChe.Click += new System.EventHandler(this.menuDangDieuChe_Click);
            // 
            // menuNuocSanXuat
            // 
            this.menuNuocSanXuat.Name = "menuNuocSanXuat";
            this.menuNuocSanXuat.Size = new System.Drawing.Size(153, 22);
            this.menuNuocSanXuat.Text = "Nước Sản Xuất";
            this.menuNuocSanXuat.Click += new System.EventHandler(this.menuNuocSanXuat_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiNhanVien,
            this.menuThongKeNhanVien,
            this.cấuHìnhToolStripMenuItem2,
            this.menuCauHinhNhanVien});
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(74, 20);
            this.menuNhanVien.Text = "Nhân Viên";
            // 
            // menuThemMoiNhanVien
            // 
            this.menuThemMoiNhanVien.Name = "menuThemMoiNhanVien";
            this.menuThemMoiNhanVien.Size = new System.Drawing.Size(128, 22);
            this.menuThemMoiNhanVien.Text = "Thêm Mới";
            this.menuThemMoiNhanVien.Click += new System.EventHandler(this.menuThemMoiNhanVien_Click);
            // 
            // menuThongKeNhanVien
            // 
            this.menuThongKeNhanVien.Name = "menuThongKeNhanVien";
            this.menuThongKeNhanVien.Size = new System.Drawing.Size(128, 22);
            this.menuThongKeNhanVien.Text = "Thống Kê";
            this.menuThongKeNhanVien.Click += new System.EventHandler(this.menuThongKeNhanVien_Click);
            // 
            // cấuHìnhToolStripMenuItem2
            // 
            this.cấuHìnhToolStripMenuItem2.Name = "cấuHìnhToolStripMenuItem2";
            this.cấuHìnhToolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
            // 
            // menuCauHinhNhanVien
            // 
            this.menuCauHinhNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChuyenMon,
            this.menuTrinhDo});
            this.menuCauHinhNhanVien.Name = "menuCauHinhNhanVien";
            this.menuCauHinhNhanVien.Size = new System.Drawing.Size(128, 22);
            this.menuCauHinhNhanVien.Text = "Cấu Hình";
            // 
            // menuChuyenMon
            // 
            this.menuChuyenMon.Name = "menuChuyenMon";
            this.menuChuyenMon.Size = new System.Drawing.Size(143, 22);
            this.menuChuyenMon.Text = "Chuyên Môn";
            this.menuChuyenMon.Click += new System.EventHandler(this.menuChuyenMon_Click);
            // 
            // menuTrinhDo
            // 
            this.menuTrinhDo.Name = "menuTrinhDo";
            this.menuTrinhDo.Size = new System.Drawing.Size(143, 22);
            this.menuTrinhDo.Text = "Trình Độ";
            this.menuTrinhDo.Click += new System.EventHandler(this.menuTrinhDo_Click);
            // 
            // menuUser
            // 
            this.menuUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(145, 20);
            this.menuUser.Text = "Xin Chào Nhân viên 123";
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản Lý Thông Tin";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // screenCauHinhCongDung
            // 
            this.screenCauHinhCongDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenCauHinhCongDung.Location = new System.Drawing.Point(0, 0);
            this.screenCauHinhCongDung.Name = "screenCauHinhCongDung";
            this.screenCauHinhCongDung.Size = new System.Drawing.Size(845, 557);
            this.screenCauHinhCongDung.TabIndex = 18;
            // 
            // screenCauHinhDangDieuChe
            // 
            this.screenCauHinhDangDieuChe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenCauHinhDangDieuChe.Location = new System.Drawing.Point(0, 0);
            this.screenCauHinhDangDieuChe.Name = "screenCauHinhDangDieuChe";
            this.screenCauHinhDangDieuChe.Size = new System.Drawing.Size(845, 557);
            this.screenCauHinhDangDieuChe.TabIndex = 17;
            // 
            // screenCauHinhDonViTinh
            // 
            this.screenCauHinhDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenCauHinhDonViTinh.Location = new System.Drawing.Point(0, 0);
            this.screenCauHinhDonViTinh.Name = "screenCauHinhDonViTinh";
            this.screenCauHinhDonViTinh.Size = new System.Drawing.Size(845, 557);
            this.screenCauHinhDonViTinh.TabIndex = 16;
            // 
            // screenCauHinhNuocSanXuat
            // 
            this.screenCauHinhNuocSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenCauHinhNuocSanXuat.Location = new System.Drawing.Point(0, 0);
            this.screenCauHinhNuocSanXuat.Name = "screenCauHinhNuocSanXuat";
            this.screenCauHinhNuocSanXuat.Size = new System.Drawing.Size(845, 557);
            this.screenCauHinhNuocSanXuat.TabIndex = 14;
            // 
            // screenHoaDonNhapThemMoi
            // 
            this.screenHoaDonNhapThemMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenHoaDonNhapThemMoi.Location = new System.Drawing.Point(0, 0);
            this.screenHoaDonNhapThemMoi.Name = "screenHoaDonNhapThemMoi";
            this.screenHoaDonNhapThemMoi.Size = new System.Drawing.Size(845, 557);
            this.screenHoaDonNhapThemMoi.TabIndex = 13;
            // 
            // screenHoaDonNhapThongKe
            // 
            this.screenHoaDonNhapThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenHoaDonNhapThongKe.Location = new System.Drawing.Point(0, 0);
            this.screenHoaDonNhapThongKe.Name = "screenHoaDonNhapThongKe";
            this.screenHoaDonNhapThongKe.Size = new System.Drawing.Size(845, 557);
            this.screenHoaDonNhapThongKe.TabIndex = 12;
            // 
            // screenHoaDonBanThongKe
            // 
            this.screenHoaDonBanThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenHoaDonBanThongKe.Location = new System.Drawing.Point(0, 0);
            this.screenHoaDonBanThongKe.Name = "screenHoaDonBanThongKe";
            this.screenHoaDonBanThongKe.Size = new System.Drawing.Size(845, 557);
            this.screenHoaDonBanThongKe.TabIndex = 11;
            // 
            // screemThuocThemMoi
            // 
            this.screemThuocThemMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screemThuocThemMoi.Location = new System.Drawing.Point(0, 0);
            this.screemThuocThemMoi.Name = "screemThuocThemMoi";
            this.screemThuocThemMoi.Size = new System.Drawing.Size(845, 557);
            this.screemThuocThemMoi.TabIndex = 10;
            // 
            // screenThuocThongKe
            // 
            this.screenThuocThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenThuocThongKe.Location = new System.Drawing.Point(0, 0);
            this.screenThuocThongKe.Name = "screenThuocThongKe";
            this.screenThuocThongKe.Size = new System.Drawing.Size(845, 557);
            this.screenThuocThongKe.TabIndex = 9;
            // 
            // screenChuyenMon
            // 
            this.screenChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenChuyenMon.Location = new System.Drawing.Point(0, 0);
            this.screenChuyenMon.Name = "screenChuyenMon";
            this.screenChuyenMon.Size = new System.Drawing.Size(845, 557);
            this.screenChuyenMon.TabIndex = 8;
            // 
            // screenNhanVienThemMoi
            // 
            this.screenNhanVienThemMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenNhanVienThemMoi.Location = new System.Drawing.Point(0, 0);
            this.screenNhanVienThemMoi.Name = "screenNhanVienThemMoi";
            this.screenNhanVienThemMoi.Size = new System.Drawing.Size(845, 557);
            this.screenNhanVienThemMoi.TabIndex = 7;
            // 
            // screenNhanVienThongKe
            // 
            this.screenNhanVienThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenNhanVienThongKe.Location = new System.Drawing.Point(0, 0);
            this.screenNhanVienThongKe.Name = "screenNhanVienThongKe";
            this.screenNhanVienThongKe.Size = new System.Drawing.Size(845, 557);
            this.screenNhanVienThongKe.TabIndex = 6;
            // 
            // screenTrinhDo
            // 
            this.screenTrinhDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenTrinhDo.Location = new System.Drawing.Point(0, 0);
            this.screenTrinhDo.Name = "screenTrinhDo";
            this.screenTrinhDo.Size = new System.Drawing.Size(845, 557);
            this.screenTrinhDo.TabIndex = 5;
            // 
            // screenKhachHangThongKe
            // 
            this.screenKhachHangThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenKhachHangThongKe.Location = new System.Drawing.Point(0, 0);
            this.screenKhachHangThongKe.Name = "screenKhachHangThongKe";
            this.screenKhachHangThongKe.Size = new System.Drawing.Size(845, 557);
            this.screenKhachHangThongKe.TabIndex = 4;
            // 
            // screenNhaCungCap
            // 
            this.screenNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.screenNhaCungCap.Name = "screenNhaCungCap";
            this.screenNhaCungCap.Size = new System.Drawing.Size(845, 557);
            this.screenNhaCungCap.TabIndex = 3;
            // 
            // screenBanThuoc
            // 
            this.screenBanThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenBanThuoc.Location = new System.Drawing.Point(0, 0);
            this.screenBanThuoc.Name = "screenBanThuoc";
            this.screenBanThuoc.Size = new System.Drawing.Size(845, 557);
            this.screenBanThuoc.TabIndex = 2;
            // 
            // screenTrangChu
            // 
            this.screenTrangChu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.screenTrangChu.Location = new System.Drawing.Point(0, 27);
            this.screenTrangChu.Name = "screenTrangChu";
            this.screenTrangChu.Size = new System.Drawing.Size(845, 530);
            this.screenTrangChu.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 557);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.screenTrangChu);
            this.Controls.Add(this.screenCauHinhCongDung);
            this.Controls.Add(this.screenCauHinhDangDieuChe);
            this.Controls.Add(this.screenCauHinhDonViTinh);
            this.Controls.Add(this.screenCauHinhNuocSanXuat);
            this.Controls.Add(this.screenHoaDonNhapThemMoi);
            this.Controls.Add(this.screenHoaDonNhapThongKe);
            this.Controls.Add(this.screenHoaDonBanThongKe);
            this.Controls.Add(this.screemThuocThemMoi);
            this.Controls.Add(this.screenThuocThongKe);
            this.Controls.Add(this.screenChuyenMon);
            this.Controls.Add(this.screenNhanVienThemMoi);
            this.Controls.Add(this.screenNhanVienThongKe);
            this.Controls.Add(this.screenTrinhDo);
            this.Controls.Add(this.screenKhachHangThongKe);
            this.Controls.Add(this.screenNhaCungCap);
            this.Controls.Add(this.screenBanThuoc);
            this.MainMenuStrip = this.menuMain;
            this.Name = "formMain";
            this.Text = "Tiệm Thuốc";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuBanThuocMenu;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuNhapThuocMenu;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDonNhapThongKe;
        private System.Windows.Forms.ToolStripMenuItem menuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem menuThuoc;
        private System.Windows.Forms.ToolStripMenuItem menuThemMoiThuoc;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeThuoc;
        private System.Windows.Forms.ToolStripSeparator cấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCauHinhThuoc;
        private System.Windows.Forms.ToolStripMenuItem menuCongDung;
        private System.Windows.Forms.ToolStripMenuItem menuDonViTinh;
        private System.Windows.Forms.ToolStripMenuItem menuDangDieuChe;
        private System.Windows.Forms.ToolStripMenuItem menuNuocSanXuat;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuThemMoiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeNhanVien;
        private System.Windows.Forms.ToolStripSeparator cấuHìnhToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuCauHinhNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuChuyenMon;
        private System.Windows.Forms.ToolStripMenuItem menuTrinhDo;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private screenTrangChu screenTrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuBanThuoc;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDonNhapThemMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private screenBanThuoc screenBanThuoc;
        private NhapThuoc.NhaCungCap screenNhaCungCap;
        private BanThuoc.KhachHangThongKe screenKhachHangThongKe;
        private NhanVien.TrinhDo screenTrinhDo;
        private NhanVien.NhanVienThongKe screenNhanVienThongKe;
        private NhanVien.NhanVienThemMoi screenNhanVienThemMoi;
        private NhanVien.CauHinh.ChuyenMon screenChuyenMon;
        private ThuocThongKe screenThuocThongKe;
        private ThuocThemMoi screemThuocThemMoi;
        private ThongKeHoaDonBan screenHoaDonBanThongKe;
        private HoaDonNhapThongKe screenHoaDonNhapThongKe;
        private HoaDonNhapThemMoi screenHoaDonNhapThemMoi;
        private CauHinhNuocSanXuat screenCauHinhNuocSanXuat;
        private CauHinhDonViTinh screenCauHinhDonViTinh;
        private CauHinhDangDieuChe screenCauHinhDangDieuChe;
        private CauHinhCongDung screenCauHinhCongDung;
    }
}