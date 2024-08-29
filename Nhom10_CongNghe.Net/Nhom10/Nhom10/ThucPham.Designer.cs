namespace Nhom10
{
    partial class ThucPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_nguyenLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_maTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_dvt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenLieu)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.59545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.40455F));
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
            this.panel1.Controls.Add(this.dgv_nguyenLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 399);
            this.panel1.TabIndex = 0;
            // 
            // dgv_nguyenLieu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nguyenLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nguyenLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nguyenLieu.ColumnHeadersHeight = 21;
            this.dgv_nguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.DVT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nguyenLieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_nguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nguyenLieu.EnableHeadersVisualStyles = false;
            this.dgv_nguyenLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.dgv_nguyenLieu.Name = "dgv_nguyenLieu";
            this.dgv_nguyenLieu.RowHeadersVisible = false;
            this.dgv_nguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nguyenLieu.Size = new System.Drawing.Size(686, 399);
            this.dgv_nguyenLieu.TabIndex = 0;
            this.dgv_nguyenLieu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_nguyenLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_nguyenLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_nguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_nguyenLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_nguyenLieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nguyenLieu.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_nguyenLieu.ThemeStyle.ReadOnly = false;
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_nguyenLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguyenLieu_CellClick);
            // 
            // MaNL
            // 
            this.MaNL.DataPropertyName = "MaTP";
            this.MaNL.HeaderText = "Mã Thực Phẩm";
            this.MaNL.Name = "MaNL";
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenTP";
            this.TenNL.HeaderText = "Tên Thực Phẩm";
            this.TenNL.Name = "TenNL";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DONVITINH";
            this.DVT.HeaderText = "Đơn Vị Tính";
            this.DVT.Name = "DVT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_maTP);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_dvt);
            this.panel2.Controls.Add(this.txt_tenTP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(695, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 399);
            this.panel2.TabIndex = 1;
            // 
            // txt_maTP
            // 
            this.txt_maTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maTP.DefaultText = "";
            this.txt_maTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maTP.DisabledState.Parent = this.txt_maTP;
            this.txt_maTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maTP.FocusedState.Parent = this.txt_maTP;
            this.txt_maTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maTP.HoverState.Parent = this.txt_maTP;
            this.txt_maTP.Location = new System.Drawing.Point(96, 106);
            this.txt_maTP.Name = "txt_maTP";
            this.txt_maTP.PasswordChar = '\0';
            this.txt_maTP.PlaceholderText = "";
            this.txt_maTP.SelectedText = "";
            this.txt_maTP.ShadowDecoration.Parent = this.txt_maTP;
            this.txt_maTP.Size = new System.Drawing.Size(227, 36);
            this.txt_maTP.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(262, 335);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(82, 42);
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
            this.btn_sua.Location = new System.Drawing.Point(174, 335);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(82, 42);
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
            this.btn_them.Location = new System.Drawing.Point(86, 335);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(82, 42);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dvt.DefaultText = "";
            this.txt_dvt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dvt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dvt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dvt.DisabledState.Parent = this.txt_dvt;
            this.txt_dvt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dvt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dvt.FocusedState.Parent = this.txt_dvt;
            this.txt_dvt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dvt.HoverState.Parent = this.txt_dvt;
            this.txt_dvt.Location = new System.Drawing.Point(96, 264);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.PasswordChar = '\0';
            this.txt_dvt.PlaceholderText = "";
            this.txt_dvt.SelectedText = "";
            this.txt_dvt.ShadowDecoration.Parent = this.txt_dvt;
            this.txt_dvt.Size = new System.Drawing.Size(227, 36);
            this.txt_dvt.TabIndex = 3;
            // 
            // txt_tenTP
            // 
            this.txt_tenTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenTP.DefaultText = "";
            this.txt_tenTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenTP.DisabledState.Parent = this.txt_tenTP;
            this.txt_tenTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenTP.FocusedState.Parent = this.txt_tenTP;
            this.txt_tenTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenTP.HoverState.Parent = this.txt_tenTP;
            this.txt_tenTP.Location = new System.Drawing.Point(96, 183);
            this.txt_tenTP.Name = "txt_tenTP";
            this.txt_tenTP.PasswordChar = '\0';
            this.txt_tenTP.PlaceholderText = "";
            this.txt_tenTP.SelectedText = "";
            this.txt_tenTP.ShadowDecoration.Parent = this.txt_tenTP;
            this.txt_tenTP.Size = new System.Drawing.Size(227, 36);
            this.txt_tenTP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thực Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Thực Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Thực Phẩm";
            // 
            // ThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThucPham";
            this.Text = "NguyenLieu";
            this.Load += new System.EventHandler(this.ThucPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguyenLieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_nguyenLieu;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_them;
        private Guna.UI2.WinForms.Guna2TextBox txt_dvt;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_maTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
    }
}