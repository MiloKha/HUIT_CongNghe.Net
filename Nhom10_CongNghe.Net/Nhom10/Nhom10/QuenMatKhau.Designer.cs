namespace Nhom10
{
    partial class QuenMatKhau
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chek_showMK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_thayDoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_mkMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mkCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_xacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_troVe = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::Nhom10.Properties.Resources.dn;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(452, 454);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // chek_showMK
            // 
            this.chek_showMK.AutoSize = true;
            this.chek_showMK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chek_showMK.CheckedState.BorderRadius = 0;
            this.chek_showMK.CheckedState.BorderThickness = 0;
            this.chek_showMK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chek_showMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chek_showMK.Location = new System.Drawing.Point(526, 297);
            this.chek_showMK.Name = "chek_showMK";
            this.chek_showMK.Size = new System.Drawing.Size(147, 23);
            this.chek_showMK.TabIndex = 4;
            this.chek_showMK.Text = "HIển Thị Mật Khẩu";
            this.chek_showMK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chek_showMK.UncheckedState.BorderRadius = 0;
            this.chek_showMK.UncheckedState.BorderThickness = 0;
            this.chek_showMK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chek_showMK.CheckedChanged += new System.EventHandler(this.chek_showMK_CheckedChanged);
            // 
            // btn_thayDoi
            // 
            this.btn_thayDoi.BorderRadius = 20;
            this.btn_thayDoi.CheckedState.Parent = this.btn_thayDoi;
            this.btn_thayDoi.CustomImages.Parent = this.btn_thayDoi;
            this.btn_thayDoi.FillColor2 = System.Drawing.Color.Gray;
            this.btn_thayDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_thayDoi.HoverState.Parent = this.btn_thayDoi;
            this.btn_thayDoi.Location = new System.Drawing.Point(544, 326);
            this.btn_thayDoi.Name = "btn_thayDoi";
            this.btn_thayDoi.ShadowDecoration.Parent = this.btn_thayDoi;
            this.btn_thayDoi.Size = new System.Drawing.Size(180, 45);
            this.btn_thayDoi.TabIndex = 5;
            this.btn_thayDoi.Text = "Thay Đổi";
            this.btn_thayDoi.Click += new System.EventHandler(this.btn_thayDoi_Click);
            // 
            // txt_mkMoi
            // 
            this.txt_mkMoi.BorderRadius = 20;
            this.txt_mkMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mkMoi.DefaultText = "";
            this.txt_mkMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mkMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mkMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkMoi.DisabledState.Parent = this.txt_mkMoi;
            this.txt_mkMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkMoi.FocusedState.Parent = this.txt_mkMoi;
            this.txt_mkMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkMoi.HoverState.Parent = this.txt_mkMoi;
            this.txt_mkMoi.IconLeft = global::Nhom10.Properties.Resources.matKhau;
            this.txt_mkMoi.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_mkMoi.Location = new System.Drawing.Point(511, 192);
            this.txt_mkMoi.Name = "txt_mkMoi";
            this.txt_mkMoi.PasswordChar = '\0';
            this.txt_mkMoi.PlaceholderText = "Nhập mật khẩu mới";
            this.txt_mkMoi.SelectedText = "";
            this.txt_mkMoi.ShadowDecoration.Parent = this.txt_mkMoi;
            this.txt_mkMoi.Size = new System.Drawing.Size(248, 42);
            this.txt_mkMoi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thay Đổi Mật Khẩu";
            // 
            // txt_mkCu
            // 
            this.txt_mkCu.BorderRadius = 20;
            this.txt_mkCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mkCu.DefaultText = "";
            this.txt_mkCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mkCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mkCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkCu.DisabledState.Parent = this.txt_mkCu;
            this.txt_mkCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkCu.FocusedState.Parent = this.txt_mkCu;
            this.txt_mkCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkCu.HoverState.Parent = this.txt_mkCu;
            this.txt_mkCu.IconLeft = global::Nhom10.Properties.Resources.matKhau;
            this.txt_mkCu.IconLeftSize = new System.Drawing.Size(36, 36);
            this.txt_mkCu.Location = new System.Drawing.Point(511, 144);
            this.txt_mkCu.Name = "txt_mkCu";
            this.txt_mkCu.PasswordChar = '\0';
            this.txt_mkCu.PlaceholderText = "Nhập mật khẩu cũ";
            this.txt_mkCu.SelectedText = "";
            this.txt_mkCu.ShadowDecoration.Parent = this.txt_mkCu;
            this.txt_mkCu.Size = new System.Drawing.Size(248, 42);
            this.txt_mkCu.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(723, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 14;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(764, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // txt_xacNhanMK
            // 
            this.txt_xacNhanMK.BorderRadius = 20;
            this.txt_xacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_xacNhanMK.DefaultText = "";
            this.txt_xacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_xacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_xacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_xacNhanMK.DisabledState.Parent = this.txt_xacNhanMK;
            this.txt_xacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_xacNhanMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_xacNhanMK.FocusedState.Parent = this.txt_xacNhanMK;
            this.txt_xacNhanMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_xacNhanMK.HoverState.Parent = this.txt_xacNhanMK;
            this.txt_xacNhanMK.IconLeft = global::Nhom10.Properties.Resources.matKhau;
            this.txt_xacNhanMK.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_xacNhanMK.Location = new System.Drawing.Point(511, 240);
            this.txt_xacNhanMK.Name = "txt_xacNhanMK";
            this.txt_xacNhanMK.PasswordChar = '\0';
            this.txt_xacNhanMK.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txt_xacNhanMK.SelectedText = "";
            this.txt_xacNhanMK.ShadowDecoration.Parent = this.txt_xacNhanMK;
            this.txt_xacNhanMK.Size = new System.Drawing.Size(248, 42);
            this.txt_xacNhanMK.TabIndex = 3;
            // 
            // lbl_troVe
            // 
            this.lbl_troVe.AutoSize = true;
            this.lbl_troVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_troVe.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_troVe.Location = new System.Drawing.Point(733, 409);
            this.lbl_troVe.Name = "lbl_troVe";
            this.lbl_troVe.Size = new System.Drawing.Size(52, 19);
            this.lbl_troVe.TabIndex = 6;
            this.lbl_troVe.TabStop = true;
            this.lbl_troVe.Text = "Trở Về";
            this.lbl_troVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_troVe_LinkClicked);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.lbl_troVe);
            this.Controls.Add(this.txt_xacNhanMK);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.chek_showMK);
            this.Controls.Add(this.btn_thayDoi);
            this.Controls.Add(this.txt_mkMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mkCu);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chek_showMK;
        private Guna.UI2.WinForms.Guna2GradientButton btn_thayDoi;
        private Guna.UI2.WinForms.Guna2TextBox txt_mkMoi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_mkCu;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_xacNhanMK;
        private System.Windows.Forms.LinkLabel lbl_troVe;

    }
}