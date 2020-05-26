namespace WindowsFormsApp1.View
{
    partial class screenTrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxQuanLyThuocTrongTiem = new System.Windows.Forms.GroupBox();
            this.panelHoaDonNhap = new System.Windows.Forms.Panel();
            this.btnThongKeHoaDonNhap = new System.Windows.Forms.Button();
            this.btnThemMoiHoaDonNhap = new System.Windows.Forms.Button();
            this.lblHoaDonNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnDangDieuChe = new System.Windows.Forms.Button();
            this.btnNuocSanXuat = new System.Windows.Forms.Button();
            this.btnDonViTinh = new System.Windows.Forms.Button();
            this.btnCongDung = new System.Windows.Forms.Button();
            this.lblCauHinh = new System.Windows.Forms.Label();
            this.panelThuoc = new System.Windows.Forms.Panel();
            this.btnThongKeThuoc = new System.Windows.Forms.Button();
            this.btnThemMoiThuoc = new System.Windows.Forms.Button();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.groupBoxBanThuoc = new System.Windows.Forms.GroupBox();
            this.btnThongKeHoaDonBan = new System.Windows.Forms.Button();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.groupBoxQuanLyThuocTrongTiem.SuspendLayout();
            this.panelHoaDonNhap.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelThuoc.SuspendLayout();
            this.groupBoxBanThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQuanLyThuocTrongTiem
            // 
            this.groupBoxQuanLyThuocTrongTiem.Controls.Add(this.panelHoaDonNhap);
            this.groupBoxQuanLyThuocTrongTiem.Controls.Add(this.panel2);
            this.groupBoxQuanLyThuocTrongTiem.Controls.Add(this.panelThuoc);
            this.groupBoxQuanLyThuocTrongTiem.Location = new System.Drawing.Point(3, 121);
            this.groupBoxQuanLyThuocTrongTiem.Name = "groupBoxQuanLyThuocTrongTiem";
            this.groupBoxQuanLyThuocTrongTiem.Size = new System.Drawing.Size(776, 350);
            this.groupBoxQuanLyThuocTrongTiem.TabIndex = 4;
            this.groupBoxQuanLyThuocTrongTiem.TabStop = false;
            this.groupBoxQuanLyThuocTrongTiem.Text = "Quản lý thuốc trong tiệm";
            // 
            // panelHoaDonNhap
            // 
            this.panelHoaDonNhap.Controls.Add(this.btnThongKeHoaDonNhap);
            this.panelHoaDonNhap.Controls.Add(this.btnThemMoiHoaDonNhap);
            this.panelHoaDonNhap.Controls.Add(this.lblHoaDonNhap);
            this.panelHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDonNhap.Location = new System.Drawing.Point(3, 116);
            this.panelHoaDonNhap.Name = "panelHoaDonNhap";
            this.panelHoaDonNhap.Size = new System.Drawing.Size(770, 131);
            this.panelHoaDonNhap.TabIndex = 2;
            // 
            // btnThongKeHoaDonNhap
            // 
            this.btnThongKeHoaDonNhap.Location = new System.Drawing.Point(511, 46);
            this.btnThongKeHoaDonNhap.Name = "btnThongKeHoaDonNhap";
            this.btnThongKeHoaDonNhap.Size = new System.Drawing.Size(80, 40);
            this.btnThongKeHoaDonNhap.TabIndex = 4;
            this.btnThongKeHoaDonNhap.Text = "Thống Kê";
            this.btnThongKeHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnThongKeHoaDonNhap.Click += new System.EventHandler(this.btnThongKeHoaDonNhap_Click);
            // 
            // btnThemMoiHoaDonNhap
            // 
            this.btnThemMoiHoaDonNhap.Location = new System.Drawing.Point(191, 46);
            this.btnThemMoiHoaDonNhap.Name = "btnThemMoiHoaDonNhap";
            this.btnThemMoiHoaDonNhap.Size = new System.Drawing.Size(80, 40);
            this.btnThemMoiHoaDonNhap.TabIndex = 3;
            this.btnThemMoiHoaDonNhap.Text = "Thêm Mới";
            this.btnThemMoiHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnThemMoiHoaDonNhap.Click += new System.EventHandler(this.btnThemMoiHoaDonNhap_Click);
            // 
            // lblHoaDonNhap
            // 
            this.lblHoaDonNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoaDonNhap.AutoSize = true;
            this.lblHoaDonNhap.Location = new System.Drawing.Point(347, 3);
            this.lblHoaDonNhap.Name = "lblHoaDonNhap";
            this.lblHoaDonNhap.Size = new System.Drawing.Size(79, 13);
            this.lblHoaDonNhap.TabIndex = 0;
            this.lblHoaDonNhap.Text = "Hóa Đơn Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNhaCungCap);
            this.panel2.Controls.Add(this.btnDangDieuChe);
            this.panel2.Controls.Add(this.btnNuocSanXuat);
            this.panel2.Controls.Add(this.btnDonViTinh);
            this.panel2.Controls.Add(this.btnCongDung);
            this.panel2.Controls.Add(this.lblCauHinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(651, 42);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(80, 40);
            this.btnNhaCungCap.TabIndex = 9;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnDangDieuChe
            // 
            this.btnDangDieuChe.Location = new System.Drawing.Point(41, 42);
            this.btnDangDieuChe.Name = "btnDangDieuChe";
            this.btnDangDieuChe.Size = new System.Drawing.Size(80, 40);
            this.btnDangDieuChe.TabIndex = 8;
            this.btnDangDieuChe.Text = "Dạng Điều Chế";
            this.btnDangDieuChe.UseVisualStyleBackColor = true;
            this.btnDangDieuChe.Click += new System.EventHandler(this.btnDangDieuChe_Click);
            // 
            // btnNuocSanXuat
            // 
            this.btnNuocSanXuat.Location = new System.Drawing.Point(348, 42);
            this.btnNuocSanXuat.Name = "btnNuocSanXuat";
            this.btnNuocSanXuat.Size = new System.Drawing.Size(80, 40);
            this.btnNuocSanXuat.TabIndex = 7;
            this.btnNuocSanXuat.Text = "Nước Sản Xuất";
            this.btnNuocSanXuat.UseVisualStyleBackColor = true;
            this.btnNuocSanXuat.Click += new System.EventHandler(this.btnNuocSanXuat_Click);
            // 
            // btnDonViTinh
            // 
            this.btnDonViTinh.Location = new System.Drawing.Point(509, 42);
            this.btnDonViTinh.Name = "btnDonViTinh";
            this.btnDonViTinh.Size = new System.Drawing.Size(80, 40);
            this.btnDonViTinh.TabIndex = 6;
            this.btnDonViTinh.Text = "Đơn Vị Tính";
            this.btnDonViTinh.UseVisualStyleBackColor = true;
            this.btnDonViTinh.Click += new System.EventHandler(this.btnDonViTinh_Click);
            // 
            // btnCongDung
            // 
            this.btnCongDung.Location = new System.Drawing.Point(191, 42);
            this.btnCongDung.Name = "btnCongDung";
            this.btnCongDung.Size = new System.Drawing.Size(80, 40);
            this.btnCongDung.TabIndex = 5;
            this.btnCongDung.Text = "Công Dụng";
            this.btnCongDung.UseVisualStyleBackColor = true;
            this.btnCongDung.Click += new System.EventHandler(this.btnCongDung_Click);
            // 
            // lblCauHinh
            // 
            this.lblCauHinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCauHinh.AutoSize = true;
            this.lblCauHinh.Location = new System.Drawing.Point(364, 3);
            this.lblCauHinh.Name = "lblCauHinh";
            this.lblCauHinh.Size = new System.Drawing.Size(51, 13);
            this.lblCauHinh.TabIndex = 0;
            this.lblCauHinh.Text = "Cấu Hình";
            // 
            // panelThuoc
            // 
            this.panelThuoc.Controls.Add(this.btnThongKeThuoc);
            this.panelThuoc.Controls.Add(this.btnThemMoiThuoc);
            this.panelThuoc.Controls.Add(this.lblThuoc);
            this.panelThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThuoc.Location = new System.Drawing.Point(3, 16);
            this.panelThuoc.Name = "panelThuoc";
            this.panelThuoc.Size = new System.Drawing.Size(770, 100);
            this.panelThuoc.TabIndex = 0;
            // 
            // btnThongKeThuoc
            // 
            this.btnThongKeThuoc.Location = new System.Drawing.Point(511, 25);
            this.btnThongKeThuoc.Name = "btnThongKeThuoc";
            this.btnThongKeThuoc.Size = new System.Drawing.Size(80, 40);
            this.btnThongKeThuoc.TabIndex = 2;
            this.btnThongKeThuoc.Text = "Thống Kê";
            this.btnThongKeThuoc.UseVisualStyleBackColor = true;
            this.btnThongKeThuoc.Click += new System.EventHandler(this.btnThongKeThuoc_Click);
            // 
            // btnThemMoiThuoc
            // 
            this.btnThemMoiThuoc.Location = new System.Drawing.Point(191, 25);
            this.btnThemMoiThuoc.Name = "btnThemMoiThuoc";
            this.btnThemMoiThuoc.Size = new System.Drawing.Size(80, 40);
            this.btnThemMoiThuoc.TabIndex = 1;
            this.btnThemMoiThuoc.Text = "Thêm Mới";
            this.btnThemMoiThuoc.UseVisualStyleBackColor = true;
            this.btnThemMoiThuoc.Click += new System.EventHandler(this.btnThemMoiThuoc_Click);
            // 
            // lblThuoc
            // 
            this.lblThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Location = new System.Drawing.Point(364, 9);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(38, 13);
            this.lblThuoc.TabIndex = 0;
            this.lblThuoc.Text = "Thuốc";
            // 
            // groupBoxBanThuoc
            // 
            this.groupBoxBanThuoc.Controls.Add(this.btnThongKeHoaDonBan);
            this.groupBoxBanThuoc.Controls.Add(this.btnBanThuoc);
            this.groupBoxBanThuoc.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBanThuoc.Name = "groupBoxBanThuoc";
            this.groupBoxBanThuoc.Size = new System.Drawing.Size(776, 112);
            this.groupBoxBanThuoc.TabIndex = 3;
            this.groupBoxBanThuoc.TabStop = false;
            this.groupBoxBanThuoc.Text = "Bán Thuốc";
            // 
            // btnThongKeHoaDonBan
            // 
            this.btnThongKeHoaDonBan.Location = new System.Drawing.Point(514, 39);
            this.btnThongKeHoaDonBan.Name = "btnThongKeHoaDonBan";
            this.btnThongKeHoaDonBan.Size = new System.Drawing.Size(80, 40);
            this.btnThongKeHoaDonBan.TabIndex = 4;
            this.btnThongKeHoaDonBan.Text = "Thống Kê Hóa Đơn Bán";
            this.btnThongKeHoaDonBan.UseVisualStyleBackColor = true;
            this.btnThongKeHoaDonBan.Click += new System.EventHandler(this.btnThongKeHoaDonBan_Click);
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.Location = new System.Drawing.Point(194, 39);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(80, 40);
            this.btnBanThuoc.TabIndex = 3;
            this.btnBanThuoc.Text = "Bán Thuốc";
            this.btnBanThuoc.UseVisualStyleBackColor = true;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // screenTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxQuanLyThuocTrongTiem);
            this.Controls.Add(this.groupBoxBanThuoc);
            this.Name = "screenTrangChu";
            this.Size = new System.Drawing.Size(790, 484);
            this.groupBoxQuanLyThuocTrongTiem.ResumeLayout(false);
            this.panelHoaDonNhap.ResumeLayout(false);
            this.panelHoaDonNhap.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelThuoc.ResumeLayout(false);
            this.panelThuoc.PerformLayout();
            this.groupBoxBanThuoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuanLyThuocTrongTiem;
        private System.Windows.Forms.Panel panelHoaDonNhap;
        private System.Windows.Forms.Button btnThongKeHoaDonNhap;
        private System.Windows.Forms.Button btnThemMoiHoaDonNhap;
        private System.Windows.Forms.Label lblHoaDonNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnDangDieuChe;
        private System.Windows.Forms.Button btnNuocSanXuat;
        private System.Windows.Forms.Button btnDonViTinh;
        private System.Windows.Forms.Button btnCongDung;
        private System.Windows.Forms.Label lblCauHinh;
        private System.Windows.Forms.Panel panelThuoc;
        private System.Windows.Forms.Button btnThongKeThuoc;
        private System.Windows.Forms.Button btnThemMoiThuoc;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.GroupBox groupBoxBanThuoc;
        private System.Windows.Forms.Button btnThongKeHoaDonBan;
        private System.Windows.Forms.Button btnBanThuoc;
    }
}
