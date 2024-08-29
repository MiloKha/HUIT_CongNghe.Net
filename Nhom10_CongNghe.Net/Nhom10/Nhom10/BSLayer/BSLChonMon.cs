using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Guna.UI2.WinForms;
using DTO;

namespace Nhom10.BSLayer
{
    class BSLChonMon
    {
        public string maMA { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        DataColumn[] primarykey = new DataColumn[1];
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
        public void loadTheoTen(FlowLayoutPanel flowLayoutPanel1,string txt)
        {

            string sql = "select ma.mama,tenma,donvitinh,giabanma,tennhomma,trangthai,hinhanh from monan ma,nhommonan nma where ma.manhomma=nma.manhomma and tenma=N'"+txt+"'";
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

        public void autotxtTimKiem(TextBox txt)
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
       public string loadmamadg(string tenmon)
        {
            string sql = "select giabanma from monan where tenma=N'"+tenmon+"'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
           
        }
       public void loadcmbTrangThai_Data(ComboBox cmb)
       {
           string sql = "select maPYC from PhieuYeuCau where trangthai=N'Chưa Thanh Toán'";
           da = new SqlDataAdapter(sql, con.Con);
           DataTable DTB = new DataTable();
           da.Fill(DTB);
           for (int i = 0; i < DTB.Rows.Count; i++)
           {
               cmb.Items.Add(DTB.Rows[i][0].ToString());
           }
       }
       public void loadDuLieuPYC(Guna2DataGridView dgv, string txt)
       {
           string sql = "select mapyc,tenma,dongia,soluong from chitietyeucau pyc, monan a where pyc.mama=a.mama and mapyc='"+txt+"'";
           da = new SqlDataAdapter(sql, con.Con);
           DataTable DTB = new DataTable();
           da.Fill(DTB);
           dgv.DataSource = DTB;
       }
        public string laymamon(string tenmon)
       {
           DataTable DTB = new DataTable();
           string sql = "select mama from monan where tenma=N'" + tenmon + "'";
           da = new SqlDataAdapter(sql, con.Con);
           da.Fill(DTB);
           return DTB.Rows[0][0].ToString().Trim(); 
       }
        public void themMon(string map,string tenmon,string dongia,string soluong)
       {
           string sql = "insert into chitietyeucau values('"+map+"','"+laymamon(tenmon)+"','"+dongia+"','"+soluong+"')";
           int r = con.executeNonQuery(sql);
           if(r>0)
           {
               MessageBox.Show("Thêm Món Thành Công ", "Thông Báo");
           }
            else
           {
               MessageBox.Show("Kiểm tra lại thông tin", "Chú Ý");
           }
       }
        public void SuaMon(string map, string tenmon, string dongia, string soluong)
        {
            string mama = laymamon(tenmon);
            string sql = "update chitietyeucau set soluong='"+soluong+"' where mapyc='"+map+"' and mama='"+mama+"'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Sửa Món Thành Công ", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin", "Chú Ý");
            }
        }
        public void XoaMon(string map, string tenmon, string dongia, string soluong)
        {

            string mama = laymamon(tenmon);
            string sql = "delete chitietyeucau where mapyc='" + map + "' and mama='" + mama + "'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Xóa Món Thành Công ", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin", "Chú Ý");
            }
        }
    }
}
