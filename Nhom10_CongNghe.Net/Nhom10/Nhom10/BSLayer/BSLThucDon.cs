using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Guna.UI2.WinForms;
using DTO;

namespace Nhom10.BSLayer
{
    class BSLThucDon

    {
        public string maMA { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        DataColumn[] primarykey = new DataColumn[1];
        /// <summary>
        /// Lọc Món Ăn
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void load(FlowLayoutPanel flowLayoutPanel1)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// <summary>
        /// Lọc Theo Combox DVT
        /// </summary>
        /// <param name="txt"></param>
        /// 
        public void loadCMB_DVT(FlowLayoutPanel flowLayoutPanel1,string cmb)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and Donvitinh=N'"+cmb+"'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// <summary>
        /// Lọc Theo Ten Mon
        /// </summary>
        /// <param name="txt"></param>
        /// 
        public void loadMaMon(FlowLayoutPanel flowLayoutPanel1, string cmb)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and ma.mama=N'" + cmb + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString();
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// <summary>
        /// Lọc Theo Combox Tên Loai
        /// </summary>
        /// <param name="txt"></param>
        /// 
        public void loadCMB_NhomMA(FlowLayoutPanel flowLayoutPanel1, string cmb)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and tennhomma=N'" + cmb + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// <summary>
        /// Lọc Theo Combox Tên Loai
        /// </summary>
        /// <param name="txt"></param>
        /// 
        public void loadCMB_TrangThai(FlowLayoutPanel flowLayoutPanel1, string cmb)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and trangthai=N'" + cmb + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }

        /// <summary>
        /// Lọc Món Ăn Giá Tăng Dần
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void SapXepTangDan(FlowLayoutPanel flowLayoutPanel1)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma  ORDER BY giabanma";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// <summary>
        /// Lọc Món Ăn Giá Giảm Dần
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void SapXepGiamDan(FlowLayoutPanel flowLayoutPanel1)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma  ORDER BY giabanma DESC";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// Lọc Món Ăn theo ten
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void loadCMB_TenMon(FlowLayoutPanel flowLayoutPanel1, string cmb, Guna2TextBox mama, Guna2ComboBox dvt, Guna2TextBox giaban, Guna2ComboBox maloai, Guna2ComboBox trangthai, Guna2TextBox hinhanh)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and tenma=N'" + cmb + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString();
                ThucDon td = new ThucDon();
               
                mama.Text = DTB.Rows[i][0].ToString();
                dvt.Text = DTB.Rows[i][2].ToString();
                giaban.Text = DTB.Rows[i][3].ToString();
                maloai.Text = DTB.Rows[i][4].ToString();
                trangthai.Text = DTB.Rows[i][5].ToString();
                hinhanh.Text = DTB.Rows[i][6].ToString();
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        /// Lọc Món Ăn theo Giá
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void loadCMB_Gia(FlowLayoutPanel flowLayoutPanel1, string cmb)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and giabanma=N'" + cmb + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            var listItems = new MonAn[DTB.Rows.Count];
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                listItems[i] = new MonAn();
                Label lb = new Label();
                listItems[i].Mamon = DTB.Rows[i][0].ToString();
                listItems[i].TenMon = DTB.Rows[i][1].ToString();
                listItems[i].Dvt = DTB.Rows[i][2].ToString();
                listItems[i].Giaban = DTB.Rows[i][3].ToString();
                listItems[i].Maloai = DTB.Rows[i][4].ToString();
                listItems[i].Trangthai = DTB.Rows[i][5].ToString();
                urlh = Environment.CurrentDirectory;
                string newstring = urlh.Substring(0, urlh.Length - 10);
                listItems[i].Hinhanh = newstring + "\\hinhanh_MonAn\\" + DTB.Rows[i][6].ToString(); 
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }
        public void autotxtTimKiem(Guna2TextBox txt)
        {
            string sql = "select tenma from monan";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                txt.AutoCompleteCustomSource.Add(DTB.Rows[i][0].ToString());
            }
        }
        public void autotxtTimKiemGia(Guna2TextBox txt)
        {
            string sql = "select giabanma from monan";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                txt.AutoCompleteCustomSource.Add(DTB.Rows[i][0].ToString());
            }
        }
        /// <summary>
        /// Combobox---load dữ liệu
        /// </summary>
        /// <param name="txt"></param>
        public void loadDVT(Guna2ComboBox txt)
        {
            txt.Items.Add("Tất Cả");
            txt.Items.Add("Dĩa");
            txt.Items.Add("Tô");
            txt.Items.Add("Con");
            txt.Items.Add("Nồi");
            txt.Items.Add("Lon");
            txt.Items.Add("Tộ");
        }
        public void loadNhomMA(Guna2ComboBox txt)
        {
            txt.Items.Add("Tất Cả");
            txt.Items.Add("Ăn Sáng");
            txt.Items.Add("Hải Sản");
            txt.Items.Add("Món Chính");
            txt.Items.Add("Nước Uống");
        }
        public void loadTrangThai(Guna2ComboBox txt)
        {
            txt.Items.Add("Còn");
            txt.Items.Add("Hết");
        }

        public string layMaMonMoi()
        {
            string mabanmoi = "";
            string sql1 = "select mama from monan";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            int mamoi = DTB1.Rows.Count + 1;
            if (mamoi < 10)
                mabanmoi = "MA00" + mamoi.ToString();
            else
            {
                if (mamoi > 10 && mamoi < 100)
                    mabanmoi = "MA0" + mamoi.ToString();
                else
                    mabanmoi = "MA" + mamoi.ToString();
            }
            for (int i = 0; i < DTB1.Rows.Count; i++)
            {
                if (mabanmoi == DTB1.Rows[i][0].ToString())
                {
                    mamoi = DTB1.Rows.Count + 1;
                    if (mamoi < 10)
                        mabanmoi = "MA00" + mamoi.ToString();
                    else
                    {
                        if (mamoi > 10 && mamoi < 100)
                            mabanmoi = "MA0" + mamoi.ToString();
                        else
                            mabanmoi = "MA" + mamoi.ToString();
                    }
                }
            }
            return mabanmoi;
        }
        public string layMaMon(string tenloai)
        {
                DataTable DTB = new DataTable();
                string sql = "select manhomma from nhommonan where tennhomma=N'"+tenloai+"'";
                da = new SqlDataAdapter(sql, con.Con);
                da.Fill(DTB);
                return DTB.Rows[0][0].ToString(); 
        }
        public string layhinhanh(string duongdan)
        {
            return Path.GetFileName(duongdan);
        }
        public void themThucDon(string tenma,string dvt,string gia,string mama,string trangthai,string hinhanh)
        {
            string sql = "insert into monan values('" + layMaMonMoi() + "',N'" + tenma + "',N'" + dvt + "','" + gia + "','" + mama + "',N'" + trangthai + "','" + hinhanh + "')";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);

            }
        }
        public void SuaThucDon(string mama,string tenma, string dvt, string gia, string manhomma, string trangthai, string hinhanh)
        {

            string sql = "update monan set tenma=N'"+tenma+"',donvitinh=N'"+dvt+"',giabanma='"+gia+"',manhomma='"+layMaMon(manhomma)+"',trangthai=N'"+trangthai+"',hinhanh='"+hinhanh+"' where mama='"+mama+"'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        public void XoaThucDon(string mama)
        {
            string sql = "delete from monan where mama='" + mama+ "'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Đã xóa thành công","Thông Báo");
            }
            else
                MessageBox.Show("Hãy kiểm tra lại dữ liệu","Chú Ý");
        }

    }
}
