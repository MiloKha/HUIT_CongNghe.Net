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
    public partial class Home : Form
    {
        private Form activeForm;
        BSHome h = new BSHome();
        BSDangNhap dn = new BSDangNhap();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_hienThi.Controls.Add(childForm);
            this.panel_hienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btn_tieuDe.Text = childForm.Text;
        }

        private void btn_quanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy(), sender);
        }

        private void btn_thayDoi_Click(object sender, EventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            h.updateTrangThai();
            DangNhap DangNhap = new DangNhap();

            DangNhap.Show();
        }

        private void btn_thucDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThucDon(), sender);
        }

        private void btn_goiMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GoiMon(), sender);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_tenNV.Text = dn.laytenNVhoatdong();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            h.updateTrangThai();
        }

        private void btn_doanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThu(), sender);
        }

        

    }
}
