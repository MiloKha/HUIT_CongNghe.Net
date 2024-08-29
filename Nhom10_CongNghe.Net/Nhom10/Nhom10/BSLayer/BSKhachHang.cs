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
    public class BSKhachHang
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;
        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MAKH, TENKH, SDT FROM KHACHHANG";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void ThemKH(string maKH, string tenKH, string sdt)
        {
            try
            {
                string sql = "INSERT INTO KHACHHANG(MAKH, TENKH, SDT) VALUES('" + maKH + "', N'" + tenKH + "', '" + sdt + "')";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        public void SuaKH(string maKH, string tenKH, string sdt)
        {
            try
            {
                string sql = "UPDATE KHACHHANG SET TENKH = N'" + tenKH + "', SDT = N'" + sdt + "' WHERE MAKH = '" + maKH + "'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại!!!");
            }
        }
    }
}
