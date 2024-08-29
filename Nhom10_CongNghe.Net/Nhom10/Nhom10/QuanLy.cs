using Nhom10.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom10
{
    public partial class QuanLy : Form
    {
        private Form activeForm;
        BSHome h = new BSHome();
        public QuanLy()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pannel_hienThi.Controls.Add(childForm);
            this.pannel_hienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void phanquyen()
        {
            if (h.layquyen() == "USER")
            {
                quanLyNhanVienToolStripMenuItem.Enabled = false;
                boPhanNhanVienToolStripMenuItem.Enabled = false;
                phieuNhapThucPhamToolStripMenuItem.Enabled = false;
                thucPhamToolStripMenuItem.Enabled = false;
                nhaCungCapToolStripMenuItem.Enabled = false;
                taoTaiKhoanChoNhanVienToolStripMenuItem.Enabled = false;
            }
            else
            {
                taoTaiKhoanChoNhanVienToolStripMenuItem.Enabled = true;
                quanLyNhanVienToolStripMenuItem.Enabled = true;
                boPhanNhanVienToolStripMenuItem.Enabled = true;
                phieuNhapThucPhamToolStripMenuItem.Enabled = true;
                thucPhamToolStripMenuItem.Enabled = true;
                nhaCungCapToolStripMenuItem.Enabled = true;
                QuanLyKhachHangToolStripMenuItem.Enabled = true;
                quanLyBanAnToolStripMenuItem.Enabled = true;
            }
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            phanquyen();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien(), sender);
        }

        private void thucPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThucPham(), sender);
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap(), sender);
        }

        private void phieuNhapThucPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuNhapThucPham(), sender);
        }

        private void taoTaiKhoanChoNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoanNV nv = new TaoTaiKhoanNV();
            nv.ShowDialog();
        }

        private void boPhanNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BoPhanNhanVien(), sender);
        }

        private void QuanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang(), sender);
        }

        private void quanLyBanAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanAn(), sender);
        }

        

        

       
    }
}
