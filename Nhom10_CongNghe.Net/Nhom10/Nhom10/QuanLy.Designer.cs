namespace Nhom10
{
    partial class QuanLy
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoTaiKhoanChoNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boPhanNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThucPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuNhapThucPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thucPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannel_hienThi = new Guna.UI2.WinForms.Guna2Panel();
            this.quanLyBanAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pannel_hienThi, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.818182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.18182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNhanVienToolStripMenuItem,
            this.quanLyThucPhamToolStripMenuItem,
            this.QuanLyKhachHangToolStripMenuItem,
            this.quanLyBanAnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoTaiKhoanChoNhanVienToolStripMenuItem,
            this.boPhanNhanVienToolStripMenuItem});
            this.quanLyNhanVienToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // taoTaiKhoanChoNhanVienToolStripMenuItem
            // 
            this.taoTaiKhoanChoNhanVienToolStripMenuItem.Name = "taoTaiKhoanChoNhanVienToolStripMenuItem";
            this.taoTaiKhoanChoNhanVienToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.taoTaiKhoanChoNhanVienToolStripMenuItem.Text = "Tạo Tài Khoản Cho Nhân Viên";
            this.taoTaiKhoanChoNhanVienToolStripMenuItem.Click += new System.EventHandler(this.taoTaiKhoanChoNhanVienToolStripMenuItem_Click);
            // 
            // boPhanNhanVienToolStripMenuItem
            // 
            this.boPhanNhanVienToolStripMenuItem.Name = "boPhanNhanVienToolStripMenuItem";
            this.boPhanNhanVienToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.boPhanNhanVienToolStripMenuItem.Text = "Bộ Phận Nhân Viên";
            this.boPhanNhanVienToolStripMenuItem.Click += new System.EventHandler(this.boPhanNhanVienToolStripMenuItem_Click);
            // 
            // quanLyThucPhamToolStripMenuItem
            // 
            this.quanLyThucPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieuNhapThucPhamToolStripMenuItem,
            this.thucPhamToolStripMenuItem,
            this.nhaCungCapToolStripMenuItem});
            this.quanLyThucPhamToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyThucPhamToolStripMenuItem.Name = "quanLyThucPhamToolStripMenuItem";
            this.quanLyThucPhamToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.quanLyThucPhamToolStripMenuItem.Text = "Quản Lý Thực Phẩm";
            // 
            // phieuNhapThucPhamToolStripMenuItem
            // 
            this.phieuNhapThucPhamToolStripMenuItem.Name = "phieuNhapThucPhamToolStripMenuItem";
            this.phieuNhapThucPhamToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.phieuNhapThucPhamToolStripMenuItem.Text = "Phiếu Nhập Thực Phẩm";
            this.phieuNhapThucPhamToolStripMenuItem.Click += new System.EventHandler(this.phieuNhapThucPhamToolStripMenuItem_Click);
            // 
            // thucPhamToolStripMenuItem
            // 
            this.thucPhamToolStripMenuItem.Name = "thucPhamToolStripMenuItem";
            this.thucPhamToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.thucPhamToolStripMenuItem.Text = "Thực Phẩm";
            this.thucPhamToolStripMenuItem.Click += new System.EventHandler(this.thucPhamToolStripMenuItem_Click);
            // 
            // nhaCungCapToolStripMenuItem
            // 
            this.nhaCungCapToolStripMenuItem.Name = "nhaCungCapToolStripMenuItem";
            this.nhaCungCapToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.nhaCungCapToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhaCungCapToolStripMenuItem.Click += new System.EventHandler(this.nhaCungCapToolStripMenuItem_Click);
            // 
            // QuanLyKhachHangToolStripMenuItem
            // 
            this.QuanLyKhachHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyKhachHangToolStripMenuItem.Name = "QuanLyKhachHangToolStripMenuItem";
            this.QuanLyKhachHangToolStripMenuItem.Size = new System.Drawing.Size(184, 25);
            this.QuanLyKhachHangToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.QuanLyKhachHangToolStripMenuItem.Click += new System.EventHandler(this.QuanLyKhachHangToolStripMenuItem_Click);
            // 
            // pannel_hienThi
            // 
            this.pannel_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannel_hienThi.Location = new System.Drawing.Point(3, 32);
            this.pannel_hienThi.Name = "pannel_hienThi";
            this.pannel_hienThi.ShadowDecoration.Parent = this.pannel_hienThi;
            this.pannel_hienThi.Size = new System.Drawing.Size(1142, 405);
            this.pannel_hienThi.TabIndex = 1;
            // 
            // quanLyBanAnToolStripMenuItem
            // 
            this.quanLyBanAnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyBanAnToolStripMenuItem.Name = "quanLyBanAnToolStripMenuItem";
            this.quanLyBanAnToolStripMenuItem.Size = new System.Drawing.Size(148, 25);
            this.quanLyBanAnToolStripMenuItem.Text = "Quản Lý Bàn Ăn";
            this.quanLyBanAnToolStripMenuItem.Click += new System.EventHandler(this.quanLyBanAnToolStripMenuItem_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel pannel_hienThi;
        private System.Windows.Forms.ToolStripMenuItem quanLyThucPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuNhapThucPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thucPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoTaiKhoanChoNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boPhanNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyBanAnToolStripMenuItem;
    }
}