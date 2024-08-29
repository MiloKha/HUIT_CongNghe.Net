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
    public partial class BoPhanNhanVien : Form
    {
        BSLBPNhanVien bpnv = new BSLBPNhanVien();
        public bool them = true;
        public BoPhanNhanVien()
        {
            InitializeComponent();
        }

        public void loadfrom()
        {
            bpnv.loadDuLieu(dgv_boPhan);
            bpnv.autotxtTimKiem_TenBP(txt_tenBP);
            btn_them.Enabled = false;
            txt_maBP.Enabled = false;
            txt_maBP.Text = bpnv.layMaBoPhanMoi();
        }
        private void BoPhanNhanVien_Load(object sender, EventArgs e)
        {
            loadfrom();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {

            them = true;
            txt_maBP.Enabled = false;
            txt_maBP.Text = bpnv.layMaBoPhanMoi();
            btn_sua.Enabled = false;
            txt_maBP.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chăt Muốn Thêm " + txt_maBP.Text + " và " + txt_tenBP.Text + " ", "Chú Ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bpnv.themBoPhan(txt_tenBP);
                tailai();
            }
            else
                if (dialogResult == DialogResult.No)
                {
                }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            txt_maBP.Enabled = false;
            btn_them.Enabled = false;
            bpnv.suaBoPhan(txt_maBP, txt_tenBP);
            tailai();
        }


        private void dgv_boPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_boPhan.CurrentCell.RowIndex;
            txt_maBP.Text = dgv_boPhan.Rows[r].Cells[0].Value.ToString();
            txt_tenBP.Text = dgv_boPhan.Rows[r].Cells[1].Value.ToString();
        }
        public void enablebtn(bool t)
        {

            this.btn_them.Enabled = t;
            this.btn_sua.Enabled = t;
            this.btn_lamMoi.Enabled = t;
        }
        public void resettext()
        {
            this.txt_maBP.ResetText();
            this.txt_tenBP.ResetText();
        }
        public void tailai()
        {
            resettext();
            bpnv.loadDuLieu(dgv_boPhan);
            enablebtn(true);
        }
        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            tailai();
            loadfrom();
        }

        private void txt_tenBP_TextChanged(object sender, EventArgs e)
        {
            if (txt_tenBP == null)
                btn_them.Enabled = false;
            else
                btn_them.Enabled = true;
        }
    }
}
