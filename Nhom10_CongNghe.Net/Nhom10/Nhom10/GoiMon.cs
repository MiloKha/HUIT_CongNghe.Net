using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom10.BSLayer;


namespace Nhom10
{
    public partial class GoiMon : Form
    {
        BSLGoiMon gm = new BSLGoiMon();
        public GoiMon()
        {
            InitializeComponent();
        }

        private void GoiMon_Load(object sender, EventArgs e)
        {
            gm.loadban(fltable);
            gm.loadcmbPYC(cmb_maPYC);
            gm.loadPYC(dgv_PYC);
            gm.loadKhachHang(cmb_KhachHang);
            gm.loadcmbTrangThai_Data(cmb_banChon);
            Guna.UI.WinForms.GunaVScrollBar guna = new Guna.UI.WinForms.GunaVScrollBar();
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(fltable, guna, true);
        }
        public bool kiemtraTaoPhieu()
        {
            if (cmb_KhachHang.Text.Trim().Length==0 || cmb_banChon.Text.Trim().Length==0)
                return false;
            else
                return true;
        }
        private void btn_TaoPhieu_Click(object sender, EventArgs e)
        {
            if(kiemtraTaoPhieu()==true)
            {
                gm.taoPYC(cmb_banChon.Text.Trim(), cmb_KhachHang.Text.Trim());
                gm.loadcmbPYC(cmb_maPYC);
                fltable.Controls.Clear();
                gm.loadban(fltable);
                gm.loadcmbTrangThai_Data(cmb_banChon);
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Chú ý");
            }

        }

        private void btn_ChonMon_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ChonMon cm = new ChonMon();
            cm.ShowDialog();
            cm.TopLevel = false;
            panelchinh.Controls.Add(cm);
            cm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cm.Dock = DockStyle.Fill;
            cm.Show();
            this.Visible = true;
        }
        public bool kiemtraThanhToan()
        {
            if (cmb_maPYC.Text.Trim().Length==0)
                return false;
            else
                return true;
        }
        private void btn_ThanhToan_Click_1(object sender, EventArgs e)
        {
         
            if(kiemtraThanhToan()==true)
            {
                gm.updatectyc(cmb_maPYC.Text.Trim());
                gm.themhoadon(cmb_maPYC.Text.Trim());
                gm.suaBan(cmb_maPYC.Text.Trim());
                fltable.Controls.Clear();
                gm.loadban(fltable);
                gm.loadcmbTrangThai_Data(cmb_banChon);
                cmb_maPYC.SelectedIndex = -1;
                gm.loadcmbPYC(cmb_maPYC);
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Chú ý");
            }

        }

        private void cmb_maPYC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            gm.loadPYC(dgv_PYC);
            txt_TongTien.Text = gm.TongTien(cmb_maPYC.Text.Trim());

        }

        private void btn_LamMoi_Click_1(object sender, EventArgs e)
        {
            fltable.Controls.Clear();
            gm.loadban(fltable);
            gm.loadcmbTrangThai_Data(cmb_banChon);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KhachHang cm = new KhachHang();
            cm.ShowDialog();
            cm.TopLevel = false;
            panelchinh.Controls.Add(cm);
            cm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cm.Dock = DockStyle.Fill;
            cm.Show();
            this.Visible = true;
            gm.loadKhachHang(cmb_KhachHang);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HoaDon cm = new HoaDon();
            cm.ShowDialog();
            cm.TopLevel = false;
            panelchinh.Controls.Add(cm);
            cm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cm.Dock = DockStyle.Fill;
            cm.Show();
            this.Visible = true;
        }



    }
}
