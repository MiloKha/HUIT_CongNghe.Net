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
    public partial class NhanVien : Form
    {
        BSNhanVien nv = new BSNhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            nv.LoadDuLieu(dgv_nhanVien);
            nv.LoadCBO_MABP(cbo_maBP);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Thêm", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                nv.ThemNV(txt_maNV.Text.Trim(), txt_tenNV.Text.Trim(), cbo_gioiTinh.Text, maskedTextBox1.Text, txt_diaChi.Text.Trim(), cbo_maBP.SelectedValue.ToString().Trim());
                nv.LoadDuLieu(dgv_nhanVien);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Sửa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                nv.SuaNV(txt_maNV.Text.Trim(), txt_tenNV.Text.Trim(), maskedTextBox1.Text, txt_diaChi.Text.Trim(), cbo_maBP.SelectedValue.ToString().Trim());
                nv.LoadDuLieu(dgv_nhanVien);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Xoá", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                nv.XoaNV(txt_maNV.Text.Trim());
                nv.LoadDuLieu(dgv_nhanVien);
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }

        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_nhanVien.CurrentCell.RowIndex;
            txt_maNV.Text = dgv_nhanVien.Rows[r].Cells[0].Value.ToString();
            txt_tenNV.Text = dgv_nhanVien.Rows[r].Cells[1].Value.ToString();
            cbo_gioiTinh.SelectedValue = dgv_nhanVien.Rows[r].Cells[2].Value.ToString();
            maskedTextBox1.Text = dgv_nhanVien.Rows[r].Cells[3].Value.ToString();
            txt_diaChi.Text = dgv_nhanVien.Rows[r].Cells[4].Value.ToString();
            cbo_maBP.SelectedValue = dgv_nhanVien.Rows[r].Cells[5].Value.ToString();
        }

        
    }
}
