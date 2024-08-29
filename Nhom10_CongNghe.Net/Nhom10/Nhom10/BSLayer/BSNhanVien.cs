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
    public class BSNhanVien
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        public void LoadDuLieu(Guna2DataGridView dgv)
        {
            string sql = "SELECT MANV, TENNV, GIOITINH, NAMSINH, DIACHI, MaBP FROM NHANVIEN";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        public void LoadCBO_MABP(Guna2ComboBox cbo)
        {
            string sql = "SELECT * FROM BoPhanNhanVien";
            DataTable dt = con.getDataTable(sql, "BoPhanNhanVien");
            cbo.DataSource = dt;
            cbo.DisplayMember = "TenBP";
            cbo.ValueMember = "MaBP";
        }

        public void ThemNV(string maNV, string tenNV, string gioiTinh, string namSinh, string diaChi, string maBP)
        {
            try
            {
                string sql = "SET DATEFORMAT DMY INSERT INTO NHANVIEN(MANV, TENNV, GIOITINH, NAMSINH, DIACHI, MaBP) VALUES('" + maNV + "',N'" + tenNV + "',N'" + gioiTinh + "','" + namSinh + "',N'" + diaChi + "','" + maBP + "')";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }

        public void SuaNV(string maNV, string tenNV, string namSinh, string diaChi, string maBP)
        {
            try
            {
                string sql = "SET DATEFORMAT DMY UPDATE NHANVIEN SET TENNV = N'" + tenNV + "', NAMSINH = '" + namSinh + "', DIACHI = N'" + diaChi + "', MaBP = '" + maBP + "'  WHERE MANV = '" + maNV + "'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                    MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại!!!");
            }
        }

        public bool KiemTraKhoaNgoai(string maNV)
        {
            string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE MANV = '" + maNV + "'";
            string sql1 = "SELECT COUNT(*) FROM HOADON WHERE MANV = '" + maNV + "'";
            int r1 = con.getResult_ExecuteScalar(sql);
            int r2 = con.getResult_ExecuteScalar(sql1);
            if (r1 >= 1 || r2 >= 1)
                return false;
            return true;
        }

        public void XoaNV(string maNV)
        {
            try
            {
                if (KiemTraKhoaNgoai(maNV))
                {
                    string sql = "DELETE FROM NHANVIEN WHERE MANV = '" + maNV + "'";
                    int r = con.executeNonQuery(sql);
                    if (r > 0)
                        MessageBox.Show("Xoá thành công");
                }
                else
                    MessageBox.Show("Đã có khoá ngoại tham chiếu đến MANV này, không thể xoá được!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

    }
}
