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

namespace Nhom10
{
    public partial class MonAn : UserControl
    {
        public MonAn()
        {
            InitializeComponent();
        }
        private string tenMon;

        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; lab_TenMon.Text = value; }
        }
        private string hinhanh;
        [Category("Custom Props")]
        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; pic_img.LoadAsync(value); }
        }
        private string mamon;
        [Category("Custom Props")]
        public string Mamon
        {
            get { return mamon; }
            set { mamon = value; lab_MaMon.Text = value; }
        }
        private string dvt;
                [Category("Custom Props")]

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; lab_DVT.Text = value; }
        }
        private string giaban;
                [Category("Custom Props")]
        public string Giaban
        {
            get { return giaban; }
            set { giaban = value; lab_Gia.Text = value; }
        }
        private string maloai;
        [Category("Custom Props")]
        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; lab_TenLoai.Text = value; }
        }
        private string trangthai;
                [Category("Custom Props")]
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; lab_TrangThai.Text = value; }
        }
        private void MonAn_Load(object sender, EventArgs e)
        {

        }
        public delegate void truyen(string txt);
        public truyen truyenMaMA;
        private void pic_img_Click_1(object sender, EventArgs e)
        {
        }
    }
}
