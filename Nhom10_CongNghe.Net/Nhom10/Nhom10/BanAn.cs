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
    public partial class BanAn : Form
    {
        BLSBan ban = new BLSBan();
        bool them = false;
        public BanAn()
        {
            InitializeComponent();
            this.dgv_Ban.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 

        }

        private void QLBan_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            txt_MaBan.Text = ban.layMaMonMoi();
            ban.load(dgv_Ban);
            ban.loadcmbTrangThai(cmb_TrangThai);
            dgv_Ban.Columns[0].HeaderText = "Mã Bàn";
            dgv_Ban.Columns[1].HeaderText = "Số Chỗi Ngồi";
            dgv_Ban.Columns[2].HeaderText = "Trạng Thái";
        }
        private void dgv_Ban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Ban.CurrentCell.RowIndex;
            txt_MaBan.Text = dgv_Ban.Rows[r].Cells[0].Value.ToString();
            txt_SoChoNgoi.Text =dgv_Ban.Rows[r].Cells[1].Value.ToString();
            cmb_TrangThai.Text = dgv_Ban.Rows[r].Cells[2].Value.ToString();
        }

        private void cmb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TrangThai.Text == "Tất Cả")
            {
                ban.load(dgv_Ban);
            }
            else
            {
                ban.loadcmbTrangThai_Data(dgv_Ban, cmb_TrangThai);
            }
        }
        public bool kiemtraThongTin()
        {
            if (txt_MaBan.Text.Trim().Length == 0 || txt_SoChoNgoi.Text.Trim().Length ==0 || cmb_TrangThai.Text.Trim().Length==0)
                return false;
            else
                return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            them = true;
            if(kiemtraThongTin()==true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Thêm Bàn:" + Environment.NewLine + txt_MaBan.Text + Environment.NewLine + txt_SoChoNgoi.Text + Environment.NewLine + cmb_TrangThai.Text +"", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ban.themBan(txt_SoChoNgoi.Text,cmb_TrangThai.Text);
                    ban.load(dgv_Ban);


                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin !","Chú Ý");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (kiemtraThongTin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Sửa Bàn:" + Environment.NewLine + txt_MaBan.Text + Environment.NewLine + txt_SoChoNgoi.Text + Environment.NewLine + cmb_TrangThai.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ban.suaBan(txt_MaBan.Text.Trim(), txt_SoChoNgoi.Text, cmb_TrangThai.Text);
                    ban.load(dgv_Ban);

                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin !", "Chú Ý");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (kiemtraThongTin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Xóa Bàn:" + Environment.NewLine + txt_MaBan.Text + Environment.NewLine + txt_SoChoNgoi.Text + Environment.NewLine + cmb_TrangThai.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ban.xoaBan(txt_MaBan.Text.Trim());
                    ban.load(dgv_Ban);

                }
                else
                    if (dialogResult == DialogResult.No)
                    {
                    }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin !", "Chú Ý");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_MaBan.Text = ban.layMaMonMoi();
            txt_SoChoNgoi.ResetText();
            cmb_TrangThai.SelectedIndex = -1;
            ban.load(dgv_Ban);
        }
        private void txt_SoChoNgoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }
    }
}
