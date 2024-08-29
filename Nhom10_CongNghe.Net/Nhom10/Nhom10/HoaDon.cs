using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom10.BSLayer;

namespace Nhom10
{
    public partial class HoaDon : Form
    {
        BSHoaDon hd = new BSHoaDon();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            hd.loadcmb(cmb_KH);

        }

        private void cmb_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            hd.loadHD(dgv_HoaDon, cmb_KH.Text.Trim());
            txt_MaBan.Text = hd.laymaBan(cmb_KH.Text.Trim());
            txt_MaNV.Text = hd.laymaNV(cmb_KH.Text.Trim());
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headerFont = new Font("Times New Roman", 40, FontStyle.Bold);
            Font subHeaderFont = new Font("Times New Roman", 16, FontStyle.Italic);
            Font contentFont = new Font("Arial", 25, FontStyle.Italic);
            float yPos = 120;

            e.Graphics.DrawString("Hóa Đơn", headerFont, Brushes.Black, 305, yPos);
            yPos += headerFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawString("Tên quán: Quán Ăn Gia Đình", subHeaderFont, Brushes.Black, 80, yPos);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 20;
            e.Graphics.DrawString("Địa chỉ: 410 Tân Kỳ Tân Quý", subHeaderFont, Brushes.Black, 100, yPos);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 20;
            e.Graphics.DrawString("Điện thoại: 0343543538", subHeaderFont, Brushes.Black, 100, yPos);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawString("BẢNG CHI TIẾT Món Ăn", contentFont, Brushes.Black, 280, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            Bitmap bitmap = new Bitmap(dgv_HoaDon.Width, dgv_HoaDon.Height);
            dgv_HoaDon.DrawToBitmap(bitmap, new Rectangle(0, 0, dgv_HoaDon.Width, dgv_HoaDon.Height));
            e.Graphics.DrawImage(bitmap, new PointF(60, yPos));
            yPos += bitmap.Height + 20;
            bitmap.Dispose();

            e.Graphics.DrawString("Ngày Xuất Hóa Đơn: " + DateTime.Now.ToString("dd/MM/yyyy"), subHeaderFont, Brushes.Black, 80, yPos);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 20;
            e.Graphics.DrawString("Tổng thành tiền: " + hd.tongHoaDon(cmb_KH.Text.Trim()) + " VNĐ", subHeaderFont, Brushes.Black, 400, yPos);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 20;
            e.Graphics.DrawString("Nhân Viên: " + txt_MaNV.Text, subHeaderFont, Brushes.Black, 400, yPos);
        }


        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;

                if (!printPreviewDialog1.Visible)
                {
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hộp thoại xem trước in đã được mở.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Không có máy in nào được cài đặt.", "Lỗi Máy In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
