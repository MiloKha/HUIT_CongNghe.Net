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
    public class BSPhieuNhapTP
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MaPhieu, NgayNhapPhieu, TenPhieu, MANV, MaNCC FROM PhieuNhapThucPham";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void LoadCBO_MANV(Guna2ComboBox cbo)
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = con.getDataTable(sql, "NHANVIEN");
            cbo.DataSource = dt;
            cbo.DisplayMember = "TENNV";
            cbo.ValueMember = "MANV";
        }

        public void LoadCBO_MANCC(Guna2ComboBox cbo)
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            DataTable dt = con.getDataTable(sql, "NHACUNGCAP");
            cbo.DataSource = dt;
            cbo.DisplayMember = "TENNCC";
            cbo.ValueMember = "MANCC";
        }

        public void ThemPN(string maPN, string ngayNhap, string tenPN, string maNV, string maNCC)
        {
            try
            {
                string sql = "SET DATEFORMAT DMY INSERT INTO PhieuNhapThucPham(MaPhieu, NgayNhapPhieu, TenPhieu, MANV, MaNCC) VALUES('" + maPN + "','" + ngayNhap + "',N'" + tenPN + "','" + maNV + "','" + maNCC + "')";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        public void SuaPN(string maPN, string ngayNhap, string tenPN, string maNV, string maNCC)
        {
            try
            {
                string sql = "SET DATEFORMAT DMY UPDATE PhieuNhapThucPham SET NgayNhapPhieu = '" + ngayNhap + "', TenPhieu = N'" + tenPN + "', MANV = '" + maNV + "', MaNCC = '" + maNCC + "' WHERE MaPhieu = '" + maPN + "'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại!!!");
            }
        }

        public bool KiemTraKhoaNgoai(string maPN)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietThucPham WHERE MaPhieu = '" + maPN + "'";
            int count = con.getResult_ExecuteScalar(sql);
            if (count >= 1)
                return false;
            return true;
        }

        public void XoaPN(string maPN)
        {
            try
            {
                if (KiemTraKhoaNgoai(maPN))
                {
                    string sql = "DELETE FROM PhieuNhapThucPham WHERE MaPhieu = '" + maPN + "'";
                    int r = con.executeNonQuery(sql);
                    if (r > 0)
                        MessageBox.Show("Xoá thành công");
                }
                else
                    MessageBox.Show("Đã có khoá ngoại tham chiếu đến MaPhieu này, không thể xoá được!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

    }
}
