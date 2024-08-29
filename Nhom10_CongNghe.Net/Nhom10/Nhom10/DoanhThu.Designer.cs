namespace Nhom10
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_doanhThu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_xem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_tong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_in = new Guna.UI2.WinForms.Guna2GradientButton();
            this.radio_nam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbo_n = new System.Windows.Forms.ComboBox();
            this.cbo_tn = new System.Windows.Forms.ComboBox();
            this.cbo_tt = new System.Windows.Forms.ComboBox();
            this.cbo_nnam = new System.Windows.Forms.ComboBox();
            this.cbo_nt = new System.Windows.Forms.ComboBox();
            this.cbo_nn = new System.Windows.Forms.ComboBox();
            this.radio_thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radio_ngay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.1944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.8056F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_doanhThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 399);
            this.panel1.TabIndex = 0;
            // 
            // dgv_doanhThu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_doanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_doanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_doanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_doanhThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_doanhThu.ColumnHeadersHeight = 24;
            this.dgv_doanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_doanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_doanhThu.EnableHeadersVisualStyles = false;
            this.dgv_doanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_doanhThu.Location = new System.Drawing.Point(0, 0);
            this.dgv_doanhThu.Name = "dgv_doanhThu";
            this.dgv_doanhThu.RowHeadersVisible = false;
            this.dgv_doanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doanhThu.Size = new System.Drawing.Size(670, 399);
            this.dgv_doanhThu.TabIndex = 0;
            this.dgv_doanhThu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_doanhThu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_doanhThu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_doanhThu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_doanhThu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_doanhThu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_doanhThu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_doanhThu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_doanhThu.ThemeStyle.HeaderStyle.Height = 24;
            this.dgv_doanhThu.ThemeStyle.ReadOnly = false;
            this.dgv_doanhThu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_doanhThu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_doanhThu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_doanhThu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_doanhThu.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_doanhThu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_doanhThu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MAHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NGAYLAP";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "DONGIA";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.btn_xem);
            this.panel2.Controls.Add(this.txt_tong);
            this.panel2.Controls.Add(this.btn_in);
            this.panel2.Controls.Add(this.radio_nam);
            this.panel2.Controls.Add(this.cbo_n);
            this.panel2.Controls.Add(this.cbo_tn);
            this.panel2.Controls.Add(this.cbo_tt);
            this.panel2.Controls.Add(this.cbo_nnam);
            this.panel2.Controls.Add(this.cbo_nt);
            this.panel2.Controls.Add(this.cbo_nn);
            this.panel2.Controls.Add(this.radio_thang);
            this.panel2.Controls.Add(this.radio_ngay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(679, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 399);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngày";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(32, 295);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(105, 22);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Tổng Tiền :";
            // 
            // btn_xem
            // 
            this.btn_xem.CheckedState.Parent = this.btn_xem;
            this.btn_xem.CustomImages.Parent = this.btn_xem;
            this.btn_xem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.ForeColor = System.Drawing.Color.White;
            this.btn_xem.HoverState.Parent = this.btn_xem;
            this.btn_xem.Location = new System.Drawing.Point(84, 335);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.ShadowDecoration.Parent = this.btn_xem;
            this.btn_xem.Size = new System.Drawing.Size(125, 45);
            this.btn_xem.TabIndex = 11;
            this.btn_xem.Text = "Xem Báo Cáo";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tong.DefaultText = "";
            this.txt_tong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tong.DisabledState.Parent = this.txt_tong;
            this.txt_tong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tong.Enabled = false;
            this.txt_tong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tong.FocusedState.Parent = this.txt_tong;
            this.txt_tong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tong.HoverState.Parent = this.txt_tong;
            this.txt_tong.Location = new System.Drawing.Point(143, 281);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.PasswordChar = '\0';
            this.txt_tong.PlaceholderText = "";
            this.txt_tong.SelectedText = "";
            this.txt_tong.ShadowDecoration.Parent = this.txt_tong;
            this.txt_tong.Size = new System.Drawing.Size(200, 36);
            this.txt_tong.TabIndex = 10;
            // 
            // btn_in
            // 
            this.btn_in.CheckedState.Parent = this.btn_in;
            this.btn_in.CustomImages.Parent = this.btn_in;
            this.btn_in.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.White;
            this.btn_in.HoverState.Parent = this.btn_in;
            this.btn_in.Location = new System.Drawing.Point(245, 335);
            this.btn_in.Name = "btn_in";
            this.btn_in.ShadowDecoration.Parent = this.btn_in;
            this.btn_in.Size = new System.Drawing.Size(125, 45);
            this.btn_in.TabIndex = 9;
            this.btn_in.Text = "In Báo Cáo";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // radio_nam
            // 
            this.radio_nam.AutoSize = true;
            this.radio_nam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_nam.CheckedState.BorderThickness = 0;
            this.radio_nam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_nam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_nam.CheckedState.InnerOffset = -4;
            this.radio_nam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nam.Location = new System.Drawing.Point(12, 191);
            this.radio_nam.Name = "radio_nam";
            this.radio_nam.Size = new System.Drawing.Size(225, 28);
            this.radio_nam.TabIndex = 8;
            this.radio_nam.Text = "Doanh Thu Theo Năm";
            this.radio_nam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_nam.UncheckedState.BorderThickness = 2;
            this.radio_nam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_nam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbo_n
            // 
            this.cbo_n.FormattingEnabled = true;
            this.cbo_n.Location = new System.Drawing.Point(83, 239);
            this.cbo_n.Name = "cbo_n";
            this.cbo_n.Size = new System.Drawing.Size(80, 21);
            this.cbo_n.TabIndex = 7;
            // 
            // cbo_tn
            // 
            this.cbo_tn.FormattingEnabled = true;
            this.cbo_tn.Location = new System.Drawing.Point(215, 148);
            this.cbo_tn.Name = "cbo_tn";
            this.cbo_tn.Size = new System.Drawing.Size(74, 21);
            this.cbo_tn.TabIndex = 6;
            // 
            // cbo_tt
            // 
            this.cbo_tt.FormattingEnabled = true;
            this.cbo_tt.Location = new System.Drawing.Point(95, 148);
            this.cbo_tt.Name = "cbo_tt";
            this.cbo_tt.Size = new System.Drawing.Size(61, 21);
            this.cbo_tt.TabIndex = 5;
            // 
            // cbo_nnam
            // 
            this.cbo_nnam.FormattingEnabled = true;
            this.cbo_nnam.Location = new System.Drawing.Point(351, 61);
            this.cbo_nnam.Name = "cbo_nnam";
            this.cbo_nnam.Size = new System.Drawing.Size(74, 21);
            this.cbo_nnam.TabIndex = 4;
            // 
            // cbo_nt
            // 
            this.cbo_nt.FormattingEnabled = true;
            this.cbo_nt.Location = new System.Drawing.Point(228, 63);
            this.cbo_nt.Name = "cbo_nt";
            this.cbo_nt.Size = new System.Drawing.Size(61, 21);
            this.cbo_nt.TabIndex = 3;
            // 
            // cbo_nn
            // 
            this.cbo_nn.FormattingEnabled = true;
            this.cbo_nn.Location = new System.Drawing.Point(87, 63);
            this.cbo_nn.Name = "cbo_nn";
            this.cbo_nn.Size = new System.Drawing.Size(61, 21);
            this.cbo_nn.TabIndex = 2;
            // 
            // radio_thang
            // 
            this.radio_thang.AutoSize = true;
            this.radio_thang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_thang.CheckedState.BorderThickness = 0;
            this.radio_thang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_thang.CheckedState.InnerOffset = -4;
            this.radio_thang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_thang.Location = new System.Drawing.Point(12, 99);
            this.radio_thang.Name = "radio_thang";
            this.radio_thang.Size = new System.Drawing.Size(239, 28);
            this.radio_thang.TabIndex = 1;
            this.radio_thang.Text = "Doanh Thu Theo Tháng";
            this.radio_thang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_thang.UncheckedState.BorderThickness = 2;
            this.radio_thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radio_ngay
            // 
            this.radio_ngay.AutoSize = true;
            this.radio_ngay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_ngay.CheckedState.BorderThickness = 0;
            this.radio_ngay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_ngay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_ngay.CheckedState.InnerOffset = -4;
            this.radio_ngay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ngay.Location = new System.Drawing.Point(12, 19);
            this.radio_ngay.Name = "radio_ngay";
            this.radio_ngay.Size = new System.Drawing.Size(229, 28);
            this.radio_ngay.TabIndex = 0;
            this.radio_ngay.Text = "Doanh Thu Theo Ngày";
            this.radio_ngay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_ngay.UncheckedState.BorderThickness = 2;
            this.radio_ngay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_ngay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThu";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_doanhThu;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_tong;
        private Guna.UI2.WinForms.Guna2GradientButton btn_in;
        private Guna.UI2.WinForms.Guna2RadioButton radio_nam;
        private System.Windows.Forms.ComboBox cbo_n;
        private System.Windows.Forms.ComboBox cbo_tn;
        private System.Windows.Forms.ComboBox cbo_tt;
        private System.Windows.Forms.ComboBox cbo_nnam;
        private System.Windows.Forms.ComboBox cbo_nt;
        private System.Windows.Forms.ComboBox cbo_nn;
        private Guna.UI2.WinForms.Guna2RadioButton radio_thang;
        private Guna.UI2.WinForms.Guna2RadioButton radio_ngay;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}