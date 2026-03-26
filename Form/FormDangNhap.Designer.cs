namespace appSkincare
{
    partial class FormDangNhap
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
            pnlScreen = new Panel();
            ckbHienMatKhau = new CheckBox();
            lnkDangKy = new LinkLabel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            pnlLine2 = new Panel();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            pnlLine1 = new Panel();
            txtTaiKhoan = new TextBox();
            lblTaiKhoan = new Label();
            lblTitle = new Label();
            pnlLeft = new Panel();
            lblWelcome = new Label();
            pnlScreen.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.White;
            pnlScreen.Controls.Add(ckbHienMatKhau);
            pnlScreen.Controls.Add(lnkDangKy);
            pnlScreen.Controls.Add(btnThoat);
            pnlScreen.Controls.Add(btnDangNhap);
            pnlScreen.Controls.Add(pnlLine2);
            pnlScreen.Controls.Add(txtMatKhau);
            pnlScreen.Controls.Add(lblMatKhau);
            pnlScreen.Controls.Add(pnlLine1);
            pnlScreen.Controls.Add(txtTaiKhoan);
            pnlScreen.Controls.Add(lblTaiKhoan);
            pnlScreen.Controls.Add(lblTitle);
            pnlScreen.Controls.Add(pnlLeft);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(800, 450);
            pnlScreen.TabIndex = 0;
            // 
            // ckbHienMatKhau
            // 
            ckbHienMatKhau.AutoSize = true;
            ckbHienMatKhau.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbHienMatKhau.ForeColor = Color.Gray;
            ckbHienMatKhau.Location = new Point(414, 302);
            ckbHienMatKhau.Name = "ckbHienMatKhau";
            ckbHienMatKhau.Size = new Size(102, 17);
            ckbHienMatKhau.TabIndex = 14;
            ckbHienMatKhau.Text = "Hiện mật khẩu";
            ckbHienMatKhau.UseVisualStyleBackColor = true;
            ckbHienMatKhau.CheckedChanged += ckbHienMatKhau_CheckedChanged;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.LinkColor = Color.FromArgb(24, 119, 242);
            lnkDangKy.Location = new Point(410, 398);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(183, 15);
            lnkDangKy.TabIndex = 13;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản? Đăng ký ngay";
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.DarkGray;
            btnThoat.Location = new Point(760, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(35, 35);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "X";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(24, 119, 242);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(410, 336);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(320, 45);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Login";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine2.Location = new Point(410, 285);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(320, 2);
            pnlLine2.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(410, 260);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(320, 22);
            txtMatKhau.TabIndex = 6;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.Gray;
            lblMatKhau.Location = new Point(410, 230);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(66, 17);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine1.Location = new Point(410, 195);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(320, 2);
            pnlLine1.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(410, 170);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(320, 22);
            txtTaiKhoan.TabIndex = 3;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.Gray;
            lblTaiKhoan.Location = new Point(410, 140);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(68, 17);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(497, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "\r\nĐĂNG NHẬP";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(24, 119, 242);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(350, 450);
            pnlLeft.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(0, 160);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 100);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME TO\r\nSKINCARE APP";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            pnlScreen.ResumeLayout(false);
            pnlScreen.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlScreen;
        private Panel pnlLeft;
        private Label lblWelcome;
        private Label lblTitle;
        private Label lblTaiKhoan;
        private TextBox txtTaiKhoan;
        private Panel pnlLine1;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Panel pnlLine2;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
        private CheckBox ckbHienMatKhau;
    }
}