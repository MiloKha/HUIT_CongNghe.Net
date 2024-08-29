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
    public partial class ChonMon : Form
    {
        BSLChonMon cm = new BSLChonMon();
        public ChonMon()
        {
            InitializeComponent();
        }



        private void ChonMon_Load(object sender, EventArgs e)
        {
            cm.load(flowLayoutPanel1);
            cm.loadcmbTrangThai_Data(cmb_PhieuYeuCau);
            cm.autotxtTimKiem(txt_TenMA);
            Guna.UI.WinForms.GunaVScrollBar guna = new Guna.UI.WinForms.GunaVScrollBar();
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, guna, true);

        }

        private void cmb_PhieuYeuCau_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm.loadDuLieuPYC(dgv_CTYC, cmb_PhieuYeuCau.Text.Trim());
           
        }

        private void dgv_CTYC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_CTYC.CurrentCell.RowIndex;
           cmb_PhieuYeuCau.Text = dgv_CTYC.Rows[r].Cells[0].Value.ToString();
            txt_TenMA.Text = dgv_CTYC.Rows[r].Cells[1].Value.ToString();
            txt_DonGia.Text = dgv_CTYC.Rows[r].Cells[2].Value.ToString();
            txt_SoLuong.Text = dgv_CTYC.Rows[r].Cells[3].Value.ToString();

        }
        public bool kiemtrathongtin()
        {
            if (cmb_PhieuYeuCau.Text.Trim().Length == 0 || txt_DonGia.Text.Trim().Length == 0 || txt_SoLuong.Text.Trim().Length == 0 ||txt_TenMA.Text.Trim().Length == 0 )
                return false;
            else
                return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemtrathongtin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Thêm Món:" + Environment.NewLine + cmb_PhieuYeuCau.Text + Environment.NewLine + txt_DonGia.Text + Environment.NewLine + txt_SoLuong.Text + Environment.NewLine + txt_TenMA.Text+"", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cm.themMon(cmb_PhieuYeuCau.Text.Trim(), txt_TenMA.Text, txt_DonGia.Text, txt_SoLuong.Text);
                    cm.loadDuLieuPYC(dgv_CTYC, cmb_PhieuYeuCau.Text);
                    txt_DonGia.ResetText();
                    txt_SoLuong.ResetText();
                    txt_TenMA.ResetText();
                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Chú Ý");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (kiemtrathongtin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Sửa Món:" + Environment.NewLine + cmb_PhieuYeuCau.Text + Environment.NewLine + txt_DonGia.Text + Environment.NewLine + txt_SoLuong.Text + Environment.NewLine + txt_TenMA.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cm.SuaMon(cmb_PhieuYeuCau.Text.Trim(), txt_TenMA.Text, txt_DonGia.Text, txt_SoLuong.Text);
                    cm.loadDuLieuPYC(dgv_CTYC, cmb_PhieuYeuCau.Text);

                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Chú Ý");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (kiemtrathongtin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Sửa Món:" + Environment.NewLine + cmb_PhieuYeuCau.Text + Environment.NewLine + txt_DonGia.Text + Environment.NewLine + txt_SoLuong.Text + Environment.NewLine + txt_TenMA.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cm.XoaMon(cmb_PhieuYeuCau.Text.Trim(), txt_TenMA.Text, txt_DonGia.Text, txt_SoLuong.Text);
                    cm.loadDuLieuPYC(dgv_CTYC, cmb_PhieuYeuCau.Text);

                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Chú Ý");
            }
        }

        private void txt_TenMA_KeyDown_1(object sender, KeyEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                txt_DonGia.Text = cm.loadmamadg(txt_TenMA.Text.Trim());
                cm.loadTheoTen(flowLayoutPanel1, txt_TenMA.Text);

            }
        }


    }
}
