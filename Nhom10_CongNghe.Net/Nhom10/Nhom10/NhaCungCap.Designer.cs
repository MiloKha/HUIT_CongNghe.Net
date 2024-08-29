namespace Nhom10
{
    partial class NhaCungCap
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_NCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_maNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_diaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 454F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_NCC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 405);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgv_NCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_NCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NCC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_NCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NCC.ColumnHeadersHeight = 21;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NCC.EnableHeadersVisualStyles = false;
            this.dgv_NCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NCC.Location = new System.Drawing.Point(3, 3);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.RowHeadersVisible = false;
            this.dgv_NCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NCC.Size = new System.Drawing.Size(682, 399);
            this.dgv_NCC.TabIndex = 0;
            this.dgv_NCC.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_NCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_NCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_NCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_NCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_NCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_NCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_NCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_NCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_NCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_NCC.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_NCC.ThemeStyle.ReadOnly = false;
            this.dgv_NCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_NCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_NCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_NCC.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_NCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChiNCC";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_maNCC);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.txt_diaChi);
            this.panel3.Controls.Add(this.txt_tenNCC);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(691, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 399);
            this.panel3.TabIndex = 1;
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maNCC.DefaultText = "";
            this.txt_maNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNCC.DisabledState.Parent = this.txt_maNCC;
            this.txt_maNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNCC.FocusedState.Parent = this.txt_maNCC;
            this.txt_maNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNCC.HoverState.Parent = this.txt_maNCC;
            this.txt_maNCC.Location = new System.Drawing.Point(98, 100);
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.PasswordChar = '\0';
            this.txt_maNCC.PlaceholderText = "";
            this.txt_maNCC.SelectedText = "";
            this.txt_maNCC.ShadowDecoration.Parent = this.txt_maNCC;
            this.txt_maNCC.Size = new System.Drawing.Size(227, 36);
            this.txt_maNCC.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(276, 329);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(96, 42);
            this.btn_xoa.TabIndex = 7;
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
            this.btn_sua.Location = new System.Drawing.Point(174, 329);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(96, 42);
            this.btn_sua.TabIndex = 6;
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
            this.btn_them.Location = new System.Drawing.Point(72, 329);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(96, 42);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diaChi.DefaultText = "";
            this.txt_diaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diaChi.DisabledState.Parent = this.txt_diaChi;
            this.txt_diaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diaChi.FocusedState.Parent = this.txt_diaChi;
            this.txt_diaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diaChi.HoverState.Parent = this.txt_diaChi;
            this.txt_diaChi.Location = new System.Drawing.Point(98, 258);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.PasswordChar = '\0';
            this.txt_diaChi.PlaceholderText = "";
            this.txt_diaChi.SelectedText = "";
            this.txt_diaChi.ShadowDecoration.Parent = this.txt_diaChi;
            this.txt_diaChi.Size = new System.Drawing.Size(227, 36);
            this.txt_diaChi.TabIndex = 3;
            // 
            // txt_tenNCC
            // 
            this.txt_tenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenNCC.DefaultText = "";
            this.txt_tenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenNCC.DisabledState.Parent = this.txt_tenNCC;
            this.txt_tenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenNCC.FocusedState.Parent = this.txt_tenNCC;
            this.txt_tenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenNCC.HoverState.Parent = this.txt_tenNCC;
            this.txt_tenNCC.Location = new System.Drawing.Point(98, 177);
            this.txt_tenNCC.Name = "txt_tenNCC";
            this.txt_tenNCC.PasswordChar = '\0';
            this.txt_tenNCC.PlaceholderText = "";
            this.txt_tenNCC.SelectedText = "";
            this.txt_tenNCC.ShadowDecoration.Parent = this.txt_tenNCC;
            this.txt_tenNCC.Size = new System.Drawing.Size(227, 36);
            this.txt_tenNCC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_NCC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_diaChi;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenNCC;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_them;
        private Guna.UI2.WinForms.Guna2TextBox txt_maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}