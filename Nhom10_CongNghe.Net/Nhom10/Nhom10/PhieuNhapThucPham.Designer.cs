namespace Nhom10
{
    partial class PhieuNhapThucPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_phieuNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cbo_maNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_maNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10508F));
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
            this.panel1.Controls.Add(this.dgv_phieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 399);
            this.panel1.TabIndex = 0;
            // 
            // dgv_phieuNhap
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_phieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_phieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_phieuNhap.ColumnHeadersHeight = 21;
            this.dgv_phieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.TenPhieu,
            this.NgayNhap,
            this.MaNV,
            this.MaNCC});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phieuNhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_phieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phieuNhap.EnableHeadersVisualStyles = false;
            this.dgv_phieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_phieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgv_phieuNhap.Name = "dgv_phieuNhap";
            this.dgv_phieuNhap.RowHeadersVisible = false;
            this.dgv_phieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieuNhap.Size = new System.Drawing.Size(677, 399);
            this.dgv_phieuNhap.TabIndex = 0;
            this.dgv_phieuNhap.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_phieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_phieuNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_phieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_phieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_phieuNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_phieuNhap.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_phieuNhap.ThemeStyle.ReadOnly = false;
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_phieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_phieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuNhap_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.Name = "MaPhieu";
            // 
            // TenPhieu
            // 
            this.TenPhieu.DataPropertyName = "TenPhieu";
            this.TenPhieu.HeaderText = "Tên Phiếu";
            this.TenPhieu.Name = "TenPhieu";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhapPhieu";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MANV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MANCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.cbo_maNV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbo_maNCC);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_maPN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_tenPN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(686, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 399);
            this.panel2.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(138, 201);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // cbo_maNV
            // 
            this.cbo_maNV.BackColor = System.Drawing.Color.Transparent;
            this.cbo_maNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_maNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maNV.FocusedState.Parent = this.cbo_maNV;
            this.cbo_maNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_maNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_maNV.HoverState.Parent = this.cbo_maNV;
            this.cbo_maNV.ItemHeight = 30;
            this.cbo_maNV.ItemsAppearance.Parent = this.cbo_maNV;
            this.cbo_maNV.Location = new System.Drawing.Point(138, 236);
            this.cbo_maNV.Name = "cbo_maNV";
            this.cbo_maNV.ShadowDecoration.Parent = this.cbo_maNV;
            this.cbo_maNV.Size = new System.Drawing.Size(246, 36);
            this.cbo_maNV.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "Phiếu Nhập Thực Phẩm";
            // 
            // cbo_maNCC
            // 
            this.cbo_maNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbo_maNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_maNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_maNCC.FocusedState.Parent = this.cbo_maNCC;
            this.cbo_maNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_maNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_maNCC.HoverState.Parent = this.cbo_maNCC;
            this.cbo_maNCC.ItemHeight = 30;
            this.cbo_maNCC.ItemsAppearance.Parent = this.cbo_maNCC;
            this.cbo_maNCC.Location = new System.Drawing.Point(138, 278);
            this.cbo_maNCC.Name = "cbo_maNCC";
            this.cbo_maNCC.ShadowDecoration.Parent = this.cbo_maNCC;
            this.cbo_maNCC.Size = new System.Drawing.Size(246, 36);
            this.cbo_maNCC.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Nhà Cung Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Nhân Viên";
            // 
            // txt_maPN
            // 
            this.txt_maPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maPN.DefaultText = "";
            this.txt_maPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maPN.DisabledState.Parent = this.txt_maPN;
            this.txt_maPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maPN.FocusedState.Parent = this.txt_maPN;
            this.txt_maPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maPN.HoverState.Parent = this.txt_maPN;
            this.txt_maPN.Location = new System.Drawing.Point(138, 73);
            this.txt_maPN.Name = "txt_maPN";
            this.txt_maPN.PasswordChar = '\0';
            this.txt_maPN.PlaceholderText = "";
            this.txt_maPN.SelectedText = "";
            this.txt_maPN.ShadowDecoration.Parent = this.txt_maPN;
            this.txt_maPN.Size = new System.Drawing.Size(125, 37);
            this.txt_maPN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // txt_tenPN
            // 
            this.txt_tenPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenPN.DefaultText = "";
            this.txt_tenPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenPN.DisabledState.Parent = this.txt_tenPN;
            this.txt_tenPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenPN.FocusedState.Parent = this.txt_tenPN;
            this.txt_tenPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenPN.HoverState.Parent = this.txt_tenPN;
            this.txt_tenPN.Location = new System.Drawing.Point(138, 131);
            this.txt_tenPN.Name = "txt_tenPN";
            this.txt_tenPN.PasswordChar = '\0';
            this.txt_tenPN.PlaceholderText = "";
            this.txt_tenPN.SelectedText = "";
            this.txt_tenPN.ShadowDecoration.Parent = this.txt_tenPN;
            this.txt_tenPN.Size = new System.Drawing.Size(246, 37);
            this.txt_tenPN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Phiếu Nhập";
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(281, 337);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(89, 42);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(186, 337);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(89, 42);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(91, 337);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(89, 42);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // PhieuNhapThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuNhapThucPham";
            this.Text = "PhieuNhapThucPham";
            this.Load += new System.EventHandler(this.PhieuNhapThucPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_phieuNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_maNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_maPN;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_them;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_maNV;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}