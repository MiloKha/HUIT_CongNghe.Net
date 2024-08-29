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
    class BSHoaDon
    {
        public string maMA { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        public void loadHD(DataGridView dgv,string makh)
        {
            string sql="select tenma,dongia,soluong,dongia*soluong as "+"Tong"+" from phieuyeucau p,chitietyeucau ct,monan ma where p.mapyc=ct.mapyc  and ma.mama=ct.mama and p.makh='"+makh+"' ";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }
        public void loadcmb(ComboBox cmb)
        {
            string sql = "select makh from phieuyeucau";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for(int i=0;i<DTB.Rows.Count;i++)
            {
                cmb.Items.Add(DTB.Rows[i][0].ToString());
            }
        }
        public string laymaNV(string makh)
        {
            string sql = "select tennv from phieuyeucau p,nhanvien nv where nv.manv=p.manv and makh='"+makh+"'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
        public string laymaBan(string makh)
        {
            string sql = "select maban from phieuyeucau where makh='" + makh + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();

        }
        public string tongHoaDon(string makh)
        {
            string sql = "select sum(dongia*soluong) as "+"Tong"+" from chitietyeucau ct, phieuyeucau p where p.mapyc=ct.mapyc and makh='"+makh+"'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
      
    }
}
