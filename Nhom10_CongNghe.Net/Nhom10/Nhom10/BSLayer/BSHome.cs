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
using System.Security.Cryptography;

namespace Nhom10.BSLayer
{
    class BSHome
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        public string layquyen()
        {
            string sql = "select quyen from taikhoan tk where trangthai=N'ON'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
        public string layTenTK()
        {
            string sql = "select tentaikhoan from taikhoan  where trangthai=N'ON'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
        public void updateTrangThai()
        {
            string sql = "update Taikhoan set trangthai=N'OFF' where tentaikhoan='"+layTenTK()+"'";
            int r = con.executeNonQuery(sql);
            if(r>0)
            {
                MessageBox.Show("Đăng Xuất Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
        }

    }
}
