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
    public class BSNhaCungCap
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MaNCC, TenNCC, DiaChiNCC FROM NHACUNGCAP";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void ThemNCC(string maNCC, string tenNCC, string dcNCC)
        {

            try
            {
                string sql = "INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChiNCC) VALUES('" + maNCC + "', N'" + tenNCC + "', N'" + dcNCC + "')";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        public bool KiemTraKhoaNgoai(string maNCC)
        {
            string sql = "SELECT COUNT(*) FROM PhieuNhapThucPham WHERE MaNCC = '" + maNCC + "'";
            int count = con.getResult_ExecuteScalar(sql);
            if (count >= 1)
                return false;
            return true;
        }

        public void XoaNCC(string maNCC)
        {
            try
            {
                if (KiemTraKhoaNgoai(maNCC))
                {
                    string sql = "DELETE FROM NHACUNGCAP WHERE MaNCC = '" + maNCC + "'";
                    int r = con.executeNonQuery(sql);
                    if (r > 0)
                        MessageBox.Show("Xoá thành công");
                }
                else
                    MessageBox.Show("Đã có khoá ngoại tham chiếu đến MaNCC này, không thể xoá được!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        public void SuaNCC(string maNCC, string tenNCC, string dcNCC)
        {
            try
            {
                string sql = "UPDATE NHACUNGCAP SET TenNCC = N'" + tenNCC + "', DiaChiNCC = N'" + dcNCC + "' WHERE MaNCC = '" + maNCC + "'";
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
