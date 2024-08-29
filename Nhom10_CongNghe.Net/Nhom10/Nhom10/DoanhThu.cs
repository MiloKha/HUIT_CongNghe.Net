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
    public partial class DoanhThu : Form
    {
        BSDoanhThu dt = new BSDoanhThu();
        public DoanhThu()
        {
            InitializeComponent();
        }

        public void LoadCBO()
        {
            for (int i = 1; i <= 31; i++)
            {
                cbo_nn.Items.Add(Convert.ToString(i));
            }
            for (int j = 1; j <= 12; j++)
            {
                cbo_nt.Items.Add(Convert.ToString(j));
                cbo_tt.Items.Add(Convert.ToString(j));
            }
            for (int k = 2022; k <= 2023; k++)
            {
                cbo_nnam.Items.Add(Convert.ToString(k));
                cbo_tn.Items.Add(Convert.ToString(k)); ;
                cbo_n.Items.Add(Convert.ToString(k)); ;
            }
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadCBO();
            dt.LoadDuLieu(dgv_doanhThu);
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (radio_ngay.Checked == true)
            {
                dt.LocTheoNgay(dgv_doanhThu, cbo_nn, cbo_nt, cbo_nnam, txt_tong);
            }
            if (radio_thang.Checked == true)
            {
                dt.LocTheoThang(dgv_doanhThu, cbo_tt, cbo_tn, txt_tong);
            }
            if (radio_nam.Checked == true)
            {
                dt.LocTheoNam(dgv_doanhThu, cbo_n, txt_tong);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO DOANH THU", new Font("Times New Roman", 40, FontStyle.Bold), Brushes.Black, 105, 120);
            int x = dgv_doanhThu.Height;
            dgv_doanhThu.Height = dgv_doanhThu.RowCount * dgv_doanhThu.RowTemplate.Height;
            //tạo bitmap để vẽ lên document
            Bitmap btm = new Bitmap(this.dgv_doanhThu.Width, this.dgv_doanhThu.Height);
            //cắt datagridview chuyển sang bitmap
            dgv_doanhThu.DrawToBitmap(btm, new Rectangle(0, 0, this.dgv_doanhThu.Width - 20, this.dgv_doanhThu.Height));
            e.Graphics.DrawImage(btm, 100, 400);
            dgv_doanhThu.Height = x;

            e.Graphics.DrawString("Tên quán: Quán Ăn Gia Đình", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 100, 200);
            e.Graphics.DrawString("Địa chỉ: 410 Tân Kỳ Tân Quý", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 100, 240);
            e.Graphics.DrawString("Điện thoại: 0343543538", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 100, 280);
            e.Graphics.DrawString("BẢNG CHI TIẾT", new Font("Arial", 25, FontStyle.Italic), Brushes.Black, 280, 325);

            e.Graphics.DrawString("Ngày báo cáo :   " + DateTime.Now.ToString(), new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 80, 700);
            e.Graphics.DrawString("Tổng doanh thu : " + txt_tong.Text + " VNĐ", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 460, 760);
            e.Graphics.DrawString("Người lập :..............................", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, 400, 850);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}
