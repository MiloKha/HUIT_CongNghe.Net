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
    public class BSThucPham
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MaTP, TenTP, DONVITINH FROM THUCPHAM";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void ThemTP(string maTP, string tenTP, string DVT)
        {

            try
            {
                string sql = "INSERT INTO THUCPHAM(MaTP, TenTP, DONVITINH) VALUES('" + maTP + "', N'" + tenTP + "', N'" + DVT + "')";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        public void SuaTP(string maTP, string tenTP, string DVT)
        {
            try
            {
                string sql = "UPDATE THUCPHAM SET TenTP = N'" + tenTP + "', DONVITINH = N'" + DVT + "' WHERE MaTP = '" + maTP + "'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại!!!");
            }
        }

        public bool KiemTraKhoaNgoai(string maTP)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietThucPham WHERE MaTP = '" + maTP + "'";
            int count = con.getResult_ExecuteScalar(sql);
            if (count >= 1)
                return false;
            return true;
        }

        public void XoaTP(string maTP)
        {
            try
            {
                if (KiemTraKhoaNgoai(maTP))
                {
                    string sql = "DELETE FROM THUCPHAM WHERE MaTP = '" + maTP + "'";
                    int r = con.executeNonQuery(sql);
                    if (r > 0)
                        MessageBox.Show("Xoá thành công");
                }
                else
                    MessageBox.Show("Đã có khoá ngoại tham chiếu đến MaTP này, không thể xoá được!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Xoá thất bại!!!");
            }
        }
    }
}
