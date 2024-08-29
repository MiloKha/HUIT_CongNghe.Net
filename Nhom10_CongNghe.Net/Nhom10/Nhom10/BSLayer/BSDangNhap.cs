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
    public class BSDangNhap
    {
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da;

        void SetNull(Guna2TextBox t1, Guna2TextBox t2)
        {
            t1.Text = "";
            t2.Text = "";
        }

        public void DangNhap(Guna2TextBox t1, Guna2TextBox t2, Form frm)
        {
            if (con.getDataTable("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = '" + t1.Text.Trim() + "' AND MATKHAU = '" + t2.Text.Trim() + "'").Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công.");
                update(t1.Text, t2.Text);
                Home main = new Home();
                main.ShowDialog();
                frm.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
                SetNull(t1, t2);
                t1.Focus();
            }
        }

        public string MaHoa(string MK)
        {
            string str = "";
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(MK);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            str = hasPass.Substring(0, 15);
            return str;
        }

        public void QuenMatKhau(Guna2TextBox t1, Guna2TextBox t2, Guna2TextBox t3)
        {
            if (t1.Text == "" || t2.Text == "" || t3.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin!");
                return;
            }
            
        }

        public void LoadCBO_MANV(Guna2ComboBox cbo)
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = con.getDataTable(sql, "NHANVIEN");
            cbo.DataSource = dt;
            cbo.DisplayMember = "MANV";
            cbo.ValueMember = "MANV";
        }

        public void TaoTaiKhoan(Guna2TextBox tenTK, Guna2TextBox mk, Guna2TextBox nlmk, string maNV)
        {
            try
            {
                if (tenTK.Text == "" || mk.Text == "" || nlmk.Text == "")
                {
                    MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (mk.Text != nlmk.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không đúng!!");
                }
                else
                {
                    string sql = "INSERT INTO TAIKHOAN(TENTAIKHOAN, MATKHAU, MANV) VALUES('" + tenTK.Text + "', '" + mk.Text + "', '" + maNV + "')";
                    int r = con.executeNonQuery(sql);
                    if (r > 0)
                        MessageBox.Show("Tạo tài khoản thành công");
                }
            }
            catch
            {
                MessageBox.Show("Tạo tài khoản thất bại!!!");
            }
        }

        public void update(string tk, string mk)
        {
            string sql = "update Taikhoan set trangthai = N'ON' where tentaikhoan='" + tk + "' and matkhau='" + mk + "'";
            int r = con.executeNonQuery(sql);
        }
        public string laytenNVhoatdong()
        {
            string sql = "select tennv from nhanvien nv,taikhoan tk where tk.manv = nv.manv and trangthai = N'ON'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }

        public void doiMatKhau(string makhaucu, string mkm, string xnlai)
        {
            if (mkm == xnlai)
            {
                string sql = "update taikhoan set matkhau='" + xnlai + "' where matkhau='" + makhaucu + "' and trangthai=N'ON'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                {
                    MessageBox.Show("Đổi Mật Khẩu Thành Công ", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu Mới Với Mật Khẩu Xác Nhận Không Trùng Nhau ", "Thông Báo", MessageBoxButtons.OK);
            }
        }

    }
}
