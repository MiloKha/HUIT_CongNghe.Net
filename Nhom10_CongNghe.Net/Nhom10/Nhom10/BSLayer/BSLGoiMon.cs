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
    class BSLGoiMon
    {
        public string maBan { get; set; }
        public string urlh = "";
        KetNoiSQL con = new KetNoiSQL();
        SqlDataAdapter da = new SqlDataAdapter();
        DataColumn[] primarykey = new DataColumn[1];
        Guna2ComboBox cmb;

        public void loadban(FlowLayoutPanel fltable)
        {
            string sql = "select*from banan";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {

          
                Guna2Button btn = new Guna2Button()
                {
                    Width = 90,
                    Height = 90,
                    Font = new Font("Arial", 9, FontStyle.Bold)
                };
                btn.Text = DTB.Rows[i][0].ToString() + Environment.NewLine + DTB.Rows[i][1].ToString() + Environment.NewLine + DTB.Rows[i][2].ToString();
                btn.Tag = string.Format(DTB.Rows[i][0].ToString());
                if (DTB.Rows[i][2].ToString() == "Trống")
                {
                    btn.FillColor = Color.BlueViolet;
                }
                else
                if (DTB.Rows[i][2].ToString() == "Đã Có Khách")
                {
                    btn.FillColor = Color.Coral;

                }
                btn.Click += new EventHandler(btn_Click);
               fltable.Controls.Add(btn);  //add button vào control

            }
        }
        public string kh(string maKH)
        {
            return maKH;
        }
        private void btn_Click(object sender, EventArgs e)
        {

            if (((Guna2Button)sender).FillColor == Color.BlueViolet)
            {
                string maban = "" + ((Guna2Button)sender).Tag.ToString().Trim() ;
                ((Guna2Button)sender).FillColor = Color.CadetBlue;
                maBan = maban;
            }
            else
            if (((Guna2Button)sender).FillColor == Color.Coral)
            {
                MessageBox.Show("Đã có khách");
            }

            
        }
        public void loadDatagvBan(Guna2DataGridView dgv)
        {
            string sql = "select*from banan where trangthai=N'Trống'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }
        public string layPhieuYCMoi()
        {
            string mabanmoi = "";
            string sql1 = "select mapyc from phieuyeucau";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            int mamoi = DTB1.Rows.Count + 1;
            if (mamoi < 10)
                mabanmoi = "0" + mamoi.ToString();
            else
            {
                if (mamoi > 10 && mamoi < 100)
                    mabanmoi = "0" + mamoi.ToString();
                else
                    mabanmoi = "" + mamoi.ToString();
            }
            for (int i = 0; i < DTB1.Rows.Count; i++)
            {
                if (mabanmoi == DTB1.Rows[i][0].ToString())
                {
                    mamoi = DTB1.Rows.Count + 1;
                    if (mamoi < 10)
                        mabanmoi = "00" + mamoi.ToString();
                    else
                    {
                        if (mamoi > 10 && mamoi < 100)
                            mabanmoi = "0" + mamoi.ToString();
                        else
                            mabanmoi = "" + mamoi.ToString();
                    }
                }
            }
            return mabanmoi.Trim();
        }
        public string layNhanVien()
        {
            string sql = "select manv from taikhoan where trangthai = N'ON'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString().Trim();
        }
        public void loadcmbTrangThai(Guna2ComboBox cmb)
        {
            cmb.Items.Add("Tất Cả");
            cmb.Items.Add("Trống");
            cmb.Items.Add("Đã Có Khách");
        }
        public void loadcmbTrangThai_Data(ComboBox cmb)
        {
            cmb.Items.Clear();
            string sql = "select maban from banan where trangthai=N'Trống'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                cmb.Items.Add(DTB.Rows[i][0].ToString());
            }
        }
        public void taoPYC(string makh)
        {
            string ngay = DateTime.Now.ToString();
            ngay = ngay.Substring(0, 10);
            string sql = "insert into phieuyeucau values('" + layPhieuYCMoi() + "','" + layNhanVien() + "','" +ngay.Trim()+ "','" + maBan + "',N'Chưa Thanh Toán','" + makh.Trim() + "')";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Tạo Phiếu Thành Công" + Environment.NewLine + layPhieuYCMoi().Trim() + Environment.NewLine + layNhanVien() + Environment.NewLine + ngay+ Environment.NewLine + "Chưa Thanh Toán" + Environment.NewLine + makh, "Tạo Phiếu", MessageBoxButtons.OK);
                string sql1 = "update banan set trangthai=N'Đã Có Khách' where maban='" + maBan + "'";
                int a = con.executeNonQuery(sql1);
            }
            else
            {
                MessageBox.Show("Hãy Kiểm tra lại thông tin", "Chú Ý", MessageBoxButtons.OK);
            }
        }
        public void taoPYC(string maban,string makh)
        {
            maBan = maban;
            string ngay = DateTime.Now.ToString();
            ngay = ngay.Substring(0, 10);
            string sql = "insert into phieuyeucau values('" + layPhieuYCMoi() + "','" + layNhanVien() + "','" + ngay.Trim() + "','" + maBan + "',N'Chưa Thanh Toán','" + makh.Trim() + "')";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Tạo Phiếu Thành Công" + Environment.NewLine + layPhieuYCMoi().Trim() + Environment.NewLine + layNhanVien() + Environment.NewLine + ngay + Environment.NewLine + "Chưa Thanh Toán" + Environment.NewLine + makh, "Tạo Phiếu", MessageBoxButtons.OK);
                string sql1 = "update banan set trangthai=N'Đã Có Khách' where maban='" + maBan + "'";
                int a = con.executeNonQuery(sql1);
            }
            else
            {
                MessageBox.Show("Hãy Kiểm tra lại thông tin", "Chú Ý", MessageBoxButtons.OK);
            }

        }
        public void loadPYC(Guna2DataGridView dgv)
        {
            string sql = "select p.mapyc,maban,tennv, kh.tenkh, ngayyc,p.trangthai from phieuyeucau p, khachhang kh,nhanvien nv where nv.manv=p.manv and  kh.makh=p.makh  and trangthai=N'Chưa Thanh Toán'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            dgv.DataSource = DTB;
        }
        public void loadcmbPYC(ComboBox cmb)
        {
            //cmb.Items.Clear();
            //string sql = "select mapyc from PhieuYeuCau where trangthai=N'Chưa Thanh Toán'";
            //da = new SqlDataAdapter(sql, con.Con);
            //DataTable DTB = new DataTable();
            //da.Fill(DTB);
            //for (int i = 0; i < DTB.Rows.Count; i++)
            //{
            //    cmb.Items.Add(DTB.Rows[i][0].ToString());
            //}
            cmb.Items.Clear();
            string sql = "select maban from banan where trangthai=N'Đã Có Khách'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                cmb.Items.Add(DTB.Rows[i][0].ToString());
            }
        }
        public string TongTien(string maBan)
        {
            string sql = "select sum(dongia*soluong) from chitietyeucau ct,phieuyeucau p where ct.mapyc=p.mapyc and  maban='" + maBan + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
        public void updatectyc(string maban)
        {
            string sql = "update phieuyeucau set trangthai='Đã Thanh Toán' where  maban='" + maban + "'";
            int r = con.executeNonQuery(sql);
        }
        public string layMaHDMoi()
        {
            string mabanmoi = "";
            string sql1 = "select mahd from hoadon";
            da = new SqlDataAdapter(sql1, con.Con);
            DataTable DTB1 = new DataTable();
            da.Fill(DTB1);
            int mamoi = DTB1.Rows.Count + 1;
            if (mamoi < 10)
                mabanmoi = "HD00" + mamoi.ToString();
            else
            {
                if (mamoi > 10 && mamoi < 100)
                    mabanmoi = "HD0" + mamoi.ToString();
                else
                    mabanmoi = "HD" + mamoi.ToString();
            }
            for (int i = 0; i < DTB1.Rows.Count; i++)
            {
                if (mabanmoi == DTB1.Rows[i][0].ToString())
                {
                    mamoi = DTB1.Rows.Count + 1;
                    if (mamoi < 10)
                        mabanmoi = "HD00" + mamoi.ToString();
                    else
                    {
                        if (mamoi > 10 && mamoi < 100)
                            mabanmoi = "HD0" + mamoi.ToString();
                        else
                            mabanmoi = "HD" + mamoi.ToString();
                    }
                }
            }
            return mabanmoi.Trim();
        }
        public string laymakh(string mayc)
        {
            string sql = "select makh from PhieuYeuCau where mayc='" + mayc + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString();
        }
        public string laymapyc(string maban)
        {
            string sql = "select mapyc from PhieuYeuCau where maban='" + maban + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString().Trim();
        }
        public void themhoadon(string maban)
        {
            string myc = laymapyc(maban);
            string ngay = DateTime.Now.ToString().Substring(0, 10);
            string sql = "insert into hoadon values('" + layMaHDMoi() + "','" + ngay.Trim()+ "','" + layNhanVien() + "','" + myc.Trim() + "')";
            int r = con.executeNonQuery(sql);
            if (r > 0)
            {
                MessageBox.Show("Thanh Toán Thành Công  ", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy Kiểm tra lại thông tin", "Chú Ý", MessageBoxButtons.OK);
            }
        }
        public string laymaban(string mayc)
        {
            string sql = "select mapyc from PhieuYeuCau where maban='" + mayc + "'";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            return DTB.Rows[0][0].ToString().Trim();
        }
        public void suaBan(string maBan)
        {
            string sql = "update banan set trangthai=N'Trống' where maban='" + maBan + "'";
            int r = con.executeNonQuery(sql);
        }
        public void loadKhachHang(ComboBox cmb)
        {
            cmb.Items.Clear();
            string sql = "select makh from khachhang";
            da = new SqlDataAdapter(sql, con.Con);
            DataTable DTB = new DataTable();
            da.Fill(DTB);
            for (int i = 0; i < DTB.Rows.Count; i++)
            {
                cmb.Items.Add(DTB.Rows[i][0].ToString());
            }
        }
    }
}
