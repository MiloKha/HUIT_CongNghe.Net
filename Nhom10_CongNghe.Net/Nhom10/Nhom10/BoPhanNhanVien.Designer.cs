namespace Nhom10
{
    partial class BoPhanNhanVien
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
            this.dgv_boPhan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_lamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_maBP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_tenBP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boPhan)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 592F));
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
            this.panel1.Controls.Add(this.dgv_boPhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 399);
            this.panel1.TabIndex = 0;
            // 
            // dgv_boPhan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_boPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_boPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_boPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_boPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_boPhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_boPhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_boPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_boPhan.ColumnHeadersHeight = 21;
            this.dgv_boPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBP,
            this.TenBP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_boPhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_boPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_boPhan.EnableHeadersVisualStyles = false;
            this.dgv_boPhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_boPhan.Location = new System.Drawing.Point(0, 0);
            this.dgv_boPhan.Name = "dgv_boPhan";
            this.dgv_boPhan.RowHeadersVisible = false;
            this.dgv_boPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_boPhan.Size = new System.Drawing.Size(544, 399);
            this.dgv_boPhan.TabIndex = 0;
            this.dgv_boPhan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_boPhan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_boPhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_boPhan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_boPhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_boPhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_boPhan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_boPhan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_boPhan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_boPhan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_boPhan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_boPhan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_boPhan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_boPhan.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_boPhan.ThemeStyle.ReadOnly = false;
            this.dgv_boPhan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_boPhan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_boPhan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_boPhan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_boPhan.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_boPhan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_boPhan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_boPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_boPhan_CellContentClick);
            // 
            // MaBP
            // 
            this.MaBP.DataPropertyName = "MaBP";
            this.MaBP.HeaderText = "Mã Bộ Phận";
            this.MaBP.Name = "MaBP";
            // 
            // TenBP
            // 
            this.TenBP.DataPropertyName = "TenBP";
            this.TenBP.HeaderText = "Tên Bộ Phận";
            this.TenBP.Name = "TenBP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_lamMoi);
            this.panel2.Controls.Add(this.txt_maBP);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_tenBP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(553, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 399);
            this.panel2.TabIndex = 1;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.CheckedState.Parent = this.btn_lamMoi;
            this.btn_lamMoi.CustomImages.Parent = this.btn_lamMoi;
            this.btn_lamMoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_lamMoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_lamMoi.HoverState.Parent = this.btn_lamMoi;
            this.btn_lamMoi.Location = new System.Drawing.Point(94, 311);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.ShadowDecoration.Parent = this.btn_lamMoi;
            this.btn_lamMoi.Size = new System.Drawing.Size(111, 42);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm Mới";
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // txt_maBP
            // 
            this.txt_maBP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maBP.DefaultText = "";
            this.txt_maBP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maBP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maBP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maBP.DisabledState.Parent = this.txt_maBP;
            this.txt_maBP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maBP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maBP.FocusedState.Parent = this.txt_maBP;
            this.txt_maBP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maBP.HoverState.Parent = this.txt_maBP;
            this.txt_maBP.Location = new System.Drawing.Point(162, 128);
            this.txt_maBP.Name = "txt_maBP";
            this.txt_maBP.PasswordChar = '\0';
            this.txt_maBP.PlaceholderText = "";
            this.txt_maBP.SelectedText = "";
            this.txt_maBP.ShadowDecoration.Parent = this.txt_maBP;
            this.txt_maBP.Size = new System.Drawing.Size(227, 36);
            this.txt_maBP.TabIndex = 1;
            // 
            // btn_sua
            // 
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(369, 311);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(94, 42);
            this.btn_sua.TabIndex = 5;
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
            this.btn_them.Location = new System.Drawing.Point(242, 311);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(94, 42);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tenBP
            // 
            this.txt_tenBP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenBP.DefaultText = "";
            this.txt_tenBP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenBP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenBP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenBP.DisabledState.Parent = this.txt_tenBP;
            this.txt_tenBP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenBP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenBP.FocusedState.Parent = this.txt_tenBP;
            this.txt_tenBP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenBP.HoverState.Parent = this.txt_tenBP;
            this.txt_tenBP.Location = new System.Drawing.Point(162, 236);
            this.txt_tenBP.Name = "txt_tenBP";
            this.txt_tenBP.PasswordChar = '\0';
            this.txt_tenBP.PlaceholderText = "";
            this.txt_tenBP.SelectedText = "";
            this.txt_tenBP.ShadowDecoration.Parent = this.txt_tenBP;
            this.txt_tenBP.Size = new System.Drawing.Size(227, 36);
            this.txt_tenBP.TabIndex = 2;
            this.txt_tenBP.TextChanged += new System.EventHandler(this.txt_tenBP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bộ Phận Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Bộ Phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Bộ Phận";
            // 
            // BoPhanNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoPhanNhanVien";
            this.Text = "BoPhanNhanVien";
            this.Load += new System.EventHandler(this.BoPhanNhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boPhan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_boPhan;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_them;
        private Guna.UI2.WinForms.Guna2TextBox txt_maBP;
        private Guna.UI2.WinForms.Guna2GradientButton btn_lamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBP;
    }
}