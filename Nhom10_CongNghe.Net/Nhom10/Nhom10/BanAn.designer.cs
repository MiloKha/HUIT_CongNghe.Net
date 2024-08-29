namespace Nhom10
{
    partial class BanAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Ban = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoChoNgoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_lammoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_MaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.25394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.74606F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1523, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Ban);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 490);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Ban
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgv_Ban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ban.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Ban.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Ban.ColumnHeadersHeight = 21;
            this.dgv_Ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.SoChoNgoi,
            this.TrangThai});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ban.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ban.EnableHeadersVisualStyles = false;
            this.dgv_Ban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Ban.Location = new System.Drawing.Point(0, 0);
            this.dgv_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ban.Name = "dgv_Ban";
            this.dgv_Ban.RowHeadersVisible = false;
            this.dgv_Ban.RowHeadersWidth = 51;
            this.dgv_Ban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ban.Size = new System.Drawing.Size(833, 490);
            this.dgv_Ban.TabIndex = 0;
            this.dgv_Ban.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Ban.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Ban.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Ban.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Ban.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Ban.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Ban.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Ban.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Ban.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Ban.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Ban.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Ban.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Ban.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Ban.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Ban.ThemeStyle.ReadOnly = false;
            this.dgv_Ban.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Ban.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Ban.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Ban.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Ban.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Ban.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Ban.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ban_CellContentClick);
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MABAN";
            this.MaBan.HeaderText = "Mã Bàn";
            this.MaBan.MinimumWidth = 6;
            this.MaBan.Name = "MaBan";
            // 
            // SoChoNgoi
            // 
            this.SoChoNgoi.DataPropertyName = "SOCHONGOI";
            this.SoChoNgoi.HeaderText = "Số Chỗ Ngồi";
            this.SoChoNgoi.MinimumWidth = 6;
            this.SoChoNgoi.Name = "SoChoNgoi";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TRANGTHAI";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_SoChoNgoi);
            this.panel2.Controls.Add(this.btn_lammoi);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_TrangThai);
            this.panel2.Controls.Add(this.txt_MaBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(845, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 490);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 45);
            this.label4.TabIndex = 125;
            this.label4.Text = "Thông Tin Bàn";
            // 
            // txt_SoChoNgoi
            // 
            this.txt_SoChoNgoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoChoNgoi.DefaultText = "";
            this.txt_SoChoNgoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoChoNgoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoChoNgoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoChoNgoi.DisabledState.Parent = this.txt_SoChoNgoi;
            this.txt_SoChoNgoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoChoNgoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoChoNgoi.FocusedState.Parent = this.txt_SoChoNgoi;
            this.txt_SoChoNgoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoChoNgoi.HoverState.Parent = this.txt_SoChoNgoi;
            this.txt_SoChoNgoi.Location = new System.Drawing.Point(272, 162);
            this.txt_SoChoNgoi.Margin = new System.Windows.Forms.Padding(5);
            this.txt_SoChoNgoi.Name = "txt_SoChoNgoi";
            this.txt_SoChoNgoi.PasswordChar = '\0';
            this.txt_SoChoNgoi.PlaceholderText = "";
            this.txt_SoChoNgoi.SelectedText = "";
            this.txt_SoChoNgoi.ShadowDecoration.Parent = this.txt_SoChoNgoi;
            this.txt_SoChoNgoi.Size = new System.Drawing.Size(229, 48);
            this.txt_SoChoNgoi.TabIndex = 124;
            this.txt_SoChoNgoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoChoNgoi_KeyPress);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_lammoi.CheckedState.Parent = this.btn_lammoi;
            this.btn_lammoi.CustomImages.Parent = this.btn_lammoi;
            this.btn_lammoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_lammoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ForeColor = System.Drawing.Color.White;
            this.btn_lammoi.HoverState.Parent = this.btn_lammoi;
            this.btn_lammoi.Location = new System.Drawing.Point(385, 401);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.ShadowDecoration.Parent = this.btn_lammoi;
            this.btn_lammoi.Size = new System.Drawing.Size(140, 59);
            this.btn_lammoi.TabIndex = 123;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Xoa.CheckedState.Parent = this.btn_Xoa;
            this.btn_Xoa.CustomImages.Parent = this.btn_Xoa;
            this.btn_Xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.HoverState.Parent = this.btn_Xoa;
            this.btn_Xoa.Location = new System.Drawing.Point(385, 310);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ShadowDecoration.Parent = this.btn_Xoa;
            this.btn_Xoa.Size = new System.Drawing.Size(140, 59);
            this.btn_Xoa.TabIndex = 122;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Sua.CheckedState.Parent = this.btn_Sua;
            this.btn_Sua.CustomImages.Parent = this.btn_Sua;
            this.btn_Sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.HoverState.Parent = this.btn_Sua;
            this.btn_Sua.Location = new System.Drawing.Point(168, 401);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.ShadowDecoration.Parent = this.btn_Sua;
            this.btn_Sua.Size = new System.Drawing.Size(140, 59);
            this.btn_Sua.TabIndex = 121;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Them.CheckedState.Parent = this.btn_Them;
            this.btn_Them.CustomImages.Parent = this.btn_Them;
            this.btn_Them.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.HoverState.Parent = this.btn_Them;
            this.btn_Them.Location = new System.Drawing.Point(168, 310);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.ShadowDecoration.Parent = this.btn_Them;
            this.btn_Them.Size = new System.Drawing.Size(140, 59);
            this.btn_Them.TabIndex = 120;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 119;
            this.label3.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 118;
            this.label2.Text = "Số Chỗ Ngồi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 117;
            this.label1.Text = "Mã Bàn:";
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cmb_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_TrangThai.FocusedState.Parent = this.cmb_TrangThai;
            this.cmb_TrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_TrangThai.HoverState.Parent = this.cmb_TrangThai;
            this.cmb_TrangThai.ItemHeight = 30;
            this.cmb_TrangThai.ItemsAppearance.Parent = this.cmb_TrangThai;
            this.cmb_TrangThai.Location = new System.Drawing.Point(272, 238);
            this.cmb_TrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.ShadowDecoration.Parent = this.cmb_TrangThai;
            this.cmb_TrangThai.Size = new System.Drawing.Size(229, 36);
            this.cmb_TrangThai.TabIndex = 116;
            this.cmb_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cmb_TrangThai_SelectedIndexChanged);
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaBan.DefaultText = "";
            this.txt_MaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaBan.DisabledState.Parent = this.txt_MaBan;
            this.txt_MaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaBan.Enabled = false;
            this.txt_MaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaBan.FocusedState.Parent = this.txt_MaBan;
            this.txt_MaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaBan.HoverState.Parent = this.txt_MaBan;
            this.txt_MaBan.Location = new System.Drawing.Point(272, 97);
            this.txt_MaBan.Margin = new System.Windows.Forms.Padding(5);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.PasswordChar = '\0';
            this.txt_MaBan.PlaceholderText = "";
            this.txt_MaBan.SelectedText = "";
            this.txt_MaBan.ShadowDecoration.Parent = this.txt_MaBan;
            this.txt_MaBan.Size = new System.Drawing.Size(229, 44);
            this.txt_MaBan.TabIndex = 115;
            // 
            // BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BanAn";
            this.Text = "QLBan";
            this.Load += new System.EventHandler(this.QLBan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChoNgoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoChoNgoi;
        private Guna.UI2.WinForms.Guna2GradientButton btn_lammoi;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_TrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaBan;
    }
}