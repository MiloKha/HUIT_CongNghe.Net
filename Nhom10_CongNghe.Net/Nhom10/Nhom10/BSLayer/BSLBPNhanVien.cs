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
    class BSLBPNhanVien
    {
        public string maMA { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        DataColumn[] primarykey = new DataColumn[1];

        public void loadDuLieu(DataGridView dgv)
        {
            string sql = "select*from bophannhanvien";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }
        public void autotxtTimKiem_TenBP(Guna2TextBox txt)
        {
            string sql = "select tenbp from bophannhanvien";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                txt.AutoCompleteCustomSource.Add(DTB.Rows[i][0].ToString());
            }
        }
        public string layMaBoPhanMoi()
        {
            string mabanmoi = "";
            string sql1 = "select mabp from bophannhanvien";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            int mamoi = DTB1.Rows.Count + 1;
            if (mamoi < 10)
                mabanmoi = "BP00" + mamoi.ToString();
            else
            {
                if (mamoi > 10 && mamoi < 100)
                    mabanmoi = "BP0" + mamoi.ToString();
                else
                    mabanmoi = "BP" + mamoi.ToString();
            }
            for (int i = 0; i < DTB1.Rows.Count;i++ )
            {
                if(mabanmoi==DTB1.Rows[i][0].ToString())
                {
                    mamoi = DTB1.Rows.Count + 1;
                    if (mamoi < 10)
                        mabanmoi = "BP00" + mamoi.ToString();
                    else
                    {
                        if (mamoi > 10 && mamoi < 100)
                            mabanmoi = "BP0" + mamoi.ToString();
                        else
                            mabanmoi = "BP" + mamoi.ToString();
                    }
                }
            }
            return mabanmoi;
        }
        public void themBoPhan(Guna2TextBox txt)
        {
            string sql = "insert into bophannhanvien values('" + layMaBoPhanMoi() + "',N'" + txt.Text + "')";
            int r = con.executeNonQuery(sql);
            if(r>0)
            {
                MessageBox.Show("Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu ", "Thông Báo", MessageBoxButtons.OK);

            }
        }
        public void suaBoPhan(Guna2TextBox mabp,Guna2TextBox txt)
        {
            string sql = "update bophannhanvien set tenbp=N'"+txt.Text+"' where mabp='"+mabp.Text+"'";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thông Tin Không Tồn Tại", "Chú Ý");
            }
        }
        
    }
}
