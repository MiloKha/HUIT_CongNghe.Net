namespace Nhom10
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_KH = new System.Windows.Forms.ComboBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_MaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_InHoaDon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TENMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.13883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.86117F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.btn_InHoaDon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_MaBan);
            this.panel1.Controls.Add(this.txt_MaNV);
            this.panel1.Controls.Add(this.cmb_KH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 108);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // cmb_KH
            // 
            this.cmb_KH.FormattingEnabled = true;
            this.cmb_KH.Location = new System.Drawing.Point(189, 41);
            this.cmb_KH.Name = "cmb_KH";
            this.cmb_KH.Size = new System.Drawing.Size(164, 24);
            this.cmb_KH.TabIndex = 1;
            this.cmb_KH.SelectedIndexChanged += new System.EventHandler(this.cmb_KH_SelectedIndexChanged);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(499, 41);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(170, 26);
            this.txt_MaNV.TabIndex = 2;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Location = new System.Drawing.Point(828, 41);
            this.txt_MaBan.Multiline = true;
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(170, 26);
            this.txt_MaBan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Bàn";
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.CheckedState.Parent = this.btn_InHoaDon;
            this.btn_InHoaDon.CustomImages.Parent = this.btn_InHoaDon;
            this.btn_InHoaDon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_InHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_InHoaDon.HoverState.Parent = this.btn_InHoaDon;
            this.btn_InHoaDon.Location = new System.Drawing.Point(1055, 41);
            this.btn_InHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.ShadowDecoration.Parent = this.btn_InHoaDon;
            this.btn_InHoaDon.Size = new System.Drawing.Size(191, 41);
            this.btn_InHoaDon.TabIndex = 28;
            this.btn_InHoaDon.Text = "In Hóa Đơn";
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1282, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 27);
            this.guna2ControlBox1.TabIndex = 30;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.95745F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.04256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel2.Controls.Add(this.guna2CustomGradientPanel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgv_HoaDon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2CustomGradientPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1313, 377);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(157, 371);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.AllowUserToDeleteRows = false;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENMA,
            this.DonGia,
            this.SL,
            this.Tong});
            this.dgv_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HoaDon.Location = new System.Drawing.Point(166, 3);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(854, 371);
            this.dgv_HoaDon.TabIndex = 5;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(1026, 3);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(284, 371);
            this.guna2CustomGradientPanel2.TabIndex = 6;
            // 
            // TENMA
            // 
            this.TENMA.DataPropertyName = "TenMA";
            this.TENMA.HeaderText = "Tên Món";
            this.TENMA.Name = "TENMA";
            this.TENMA.ReadOnly = true;
            this.TENMA.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 130;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 130;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "Tong";
            this.Tong.HeaderText = "Tổng Tiền";
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            this.Tong.Width = 140;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.TextBox txt_MaNV;
        private Guna.UI2.WinForms.Guna2GradientButton btn_InHoaDon;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
    }
}