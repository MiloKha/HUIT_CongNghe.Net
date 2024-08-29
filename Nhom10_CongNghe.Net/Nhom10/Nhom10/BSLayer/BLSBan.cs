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
    class BLSBan
    {
        public string maMA { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        DataColumn[] primarykey = new DataColumn[1];
        /// <summary>
        /// Lọc Bàn Ăn
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        public void load(Guna2DataGridView dgv)
        {
            string sql = "select*from banan";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }

        //
        //Lọc Cmb 
        public void loadcmbTrangThai(Guna2ComboBox cmb)
        {
            cmb.Items.Add("Tất Cả");
            cmb.Items.Add("Trống");
            cmb.Items.Add("Đã Có Khách");
        }
        public void loadcmbTrangThai_Data(Guna2DataGridView dgv,Guna2ComboBox cmb)
        {
            string sql = "select*from banan where trangthai=N'"+cmb.Text+"'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }
        public string layMaMonMoi()
        {
            string sql1 = "select maban from banan";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);

            int mamoi = 1;

            foreach (DataRow row in DTB1.Rows)
            {
                string mabanHienTai = row["maban"].ToString();
                int maSo;
                if (int.TryParse(mabanHienTai, out maSo))
                {
                    if (maSo >= mamoi)
                    {
                        mamoi = maSo + 1;
                    }
                }
            }

            string mabanmoi = mamoi.ToString().PadLeft(3, '0');

            return mabanmoi;
        }

        public void themBan(string sochongoi,string trangthai)
        {
            string sql = "insert into banan values('" + layMaMonMoi() + "','" + sochongoi + "',N'" + trangthai + "')";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);

            }
        }
        public void suaBan(string maban, string scn, string trangthai)
        {
            string sql = "update banan set sochongoi='" + scn + "',trangthai='" + trangthai + "' where maban='" + maban + "'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        public void xoaBan(string maban)
        {
            string kt = "select COUNT(*) from phieuyeucau where maban='" + maban + "'";
            SqlCommand cmd = new SqlCommand(kt, con.Con);
            con.Con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar()); // Thực thi truy vấn và lấy số lượng bản ghi liên kết
            con.Con.Close();

            if (count > 0)
            {
                MessageBox.Show("Bàn " + maban + " hiện đang có khách hoặc có yêu cầu liên quan. Bạn không thể xóa bàn này.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "delete from banan where maban='" + maban + "'";
                int r = con.executeNonQuery(sql);
                if (r > 0)
                {
                    MessageBox.Show("Xóa Thành Công ", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
