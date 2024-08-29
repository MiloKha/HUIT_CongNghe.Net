using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace Nhom10.BSLayer
{
    public class BSDoanhThu
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;
        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MAHD, NGAYLAP, DONGIA FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void LocTheoNgay(Guna2DataGridView dgv, ComboBox day, ComboBox month, ComboBox year, Guna2TextBox txt)
        {
            string sql = "SELECT MAHD, NGAYLAP, DONGIA FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND DAY(NGAYLAP) = '" + day.Text + "' AND MONTH(NGAYLAP) = '" + month.Text + "' AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
            txt.ResetText();
            string sql1 = "SELECT SUM(DONGIA) FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND DAY(NGAYLAP) = '" + day.Text + "' AND MONTH(NGAYLAP) = '" + month.Text + "' AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            txt.Text += DTB1.Rows[0][0].ToString();
        }

        public void LocTheoThang(Guna2DataGridView dgv, ComboBox month, ComboBox year, Guna2TextBox txt)
        {
            string sql = "SELECT MAHD, NGAYLAP, DONGIA FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND MONTH(NGAYLAP) = '" + month.Text + "' AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
            txt.ResetText();
            string sql1 = "SELECT SUM(DONGIA) FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND MONTH(NGAYLAP) = '" + month.Text + "' AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            txt.Text += DTB1.Rows[0][0].ToString();
        }

        public void LocTheoNam(Guna2DataGridView dgv, ComboBox year, Guna2TextBox txt)
        {
            string sql = "SELECT MAHD, NGAYLAP, DONGIA FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
            txt.ResetText();
            string sql1 = "SELECT SUM(DONGIA) FROM HOADON, ChiTietYeuCau WHERE HOADON.MaPYC = ChiTietYeuCau.MaPYC AND YEAR(NGAYLAP) = '" + year.Text + "'";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            txt.Text += DTB1.Rows[0][0].ToString();
        }
    }
}
