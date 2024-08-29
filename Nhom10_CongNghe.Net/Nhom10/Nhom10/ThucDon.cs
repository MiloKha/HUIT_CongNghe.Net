using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Nhom10.BSLayer;
using System.Data.SqlClient;

namespace Nhom10
{
    public partial class ThucDon : Form
    {
        BSLThucDon td = new BSLThucDon();
        private string maMA;

        public string MaMA
        {
            get { return maMA; }
            set { maMA = value; }
        }
        public string urlh = "";
        DataColumn[] primarykey = new DataColumn[1];
        public ThucDon()
        {
            InitializeComponent();
        }
        private void frmThucDon_Load(object sender, EventArgs e)
        {
            loadDuLieu();

        }
    
        private void cmb_DVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if(cmb_DVT.Text.Trim()=="Tất Cả")
            {
                td.load(flowLayoutPanel1);
            }
            else
            {
                td.loadCMB_DVT(flowLayoutPanel1, cmb_DVT.Text.Trim());
            }
        }
        private void cmb_TenNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cmb_TenNM.Text.Trim() == "Tất Cả")
            {
                td.load(flowLayoutPanel1);
            }
            else
            {
                td.loadCMB_NhomMA(flowLayoutPanel1, cmb_TenNM.Text.Trim());
            }
        }

        private void cmb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            td.loadCMB_TrangThai(flowLayoutPanel1, cmb_trangthai.Text.Trim());
        }

        private void txt_TenMon_KeyDown(object sender, KeyEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                td.loadCMB_TenMon(flowLayoutPanel1, txt_TenMon.Text.Trim(), txt_MaMon, cmb_DVT, txt_Gia, cmb_TenNM, cmb_trangthai, txt_Hinh);
            }
        }

        private void txt_Gia_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txt_Hinh.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemtrathongtin() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn Thêm món:" + Environment.NewLine + txt_MaMon.Text + Environment.NewLine + txt_TenMon.Text + Environment.NewLine + cmb_DVT.Text + Environment.NewLine + txt_Gia.Text + Environment.NewLine + cmb_TenNM.Text + Environment.NewLine + cmb_trangthai.Text + Environment.NewLine + txt_Hinh.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string manhomma = td.layMaMon(cmb_TenNM.Text);
                    td.themThucDon(txt_TenMon.Text.Trim(), cmb_DVT.Text, txt_Gia.Text, manhomma, cmb_trangthai.Text, txt_Hinh.Text);
                    flowLayoutPanel1.Controls.Clear();
                    td.loadMaMon(flowLayoutPanel1, txt_MaMon.Text);


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
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn sửa món:" + Environment.NewLine + txt_MaMon.Text + Environment.NewLine + txt_TenMon.Text + Environment.NewLine + cmb_DVT.Text + Environment.NewLine + txt_Gia.Text + Environment.NewLine + cmb_TenNM.Text + Environment.NewLine + cmb_trangthai.Text + Environment.NewLine + txt_Hinh.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    td.SuaThucDon(txt_MaMon.Text.Trim(), txt_TenMon.Text, cmb_DVT.Text, txt_Gia.Text, cmb_TenNM.Text, cmb_trangthai.Text, txt_Hinh.Text);
                    flowLayoutPanel1.Controls.Clear();
                    td.loadMaMon(flowLayoutPanel1, txt_MaMon.Text);

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
                DialogResult dialogResult = MessageBox.Show("Bạn có chắt muốn xóa món:" + Environment.NewLine + txt_MaMon.Text + Environment.NewLine + txt_TenMon.Text + Environment.NewLine + cmb_DVT.Text + Environment.NewLine + txt_Gia.Text + Environment.NewLine + cmb_TenNM.Text + Environment.NewLine + cmb_trangthai.Text + Environment.NewLine + txt_Hinh.Text + "", "Chú Ý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    td.XoaThucDon(txt_MaMon.Text);
                    td.load(flowLayoutPanel1);
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

        public bool kiemtrathongtin()
        {
            if (txt_TenMon.Text.Trim().Length == 0 || cmb_DVT.Text.Trim().Length == 0 || txt_Gia.Text.Trim().Length == 0 || cmb_TenNM.Text.Trim().Length == 0 || cmb_trangthai.Text.Trim().Length == 0 || txt_Hinh.Text.Trim().Length == 0 || txt_MaMon.Text.Trim().Length == 0)
                return false;
            else
                return true;
        }
        public void Resettext()
        {
            txt_MaMon.ResetText();
            txt_TenMon.ResetText();
            cmb_DVT.SelectedIndex = -1;
            txt_Gia.ResetText();
            cmb_TenNM.SelectedIndex = -1;
            cmb_trangthai.SelectedIndex = -1;
            txt_Hinh.ResetText();
        }
        public void loadDuLieu()
        {
            Resettext();
            txt_MaMon.Text = td.layMaMonMoi();
            td.load(flowLayoutPanel1);
            //td.autotxtTimKiemGia(txt_Gia);
            td.autotxtTimKiem(txt_TenMon);
            txt_MaMon.Text = td.layMaMonMoi();
            td.loadDVT(cmb_DVT);
            td.loadNhomMA(cmb_TenNM);
            td.loadTrangThai(cmb_trangthai);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
                Resettext();
                loadDuLieu();
        }




    }
}
 