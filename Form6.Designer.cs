namespace appSkincare
{
    partial class Form6
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
            lnkDangNhap = new LinkLabel();
            panel1 = new Panel();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            btnThoat = new Button();
            btnDangKy = new Button();
            pnlLine2 = new Panel();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            pnlLine1 = new Panel();
            txtDangNhap = new TextBox();
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
            pnlScreen.Controls.Add(lnkDangNhap);
            pnlScreen.Controls.Add(panel1);
            pnlScreen.Controls.Add(txtHoTen);
            pnlScreen.Controls.Add(lblHoTen);
            pnlScreen.Controls.Add(btnThoat);
            pnlScreen.Controls.Add(btnDangKy);
            pnlScreen.Controls.Add(pnlLine2);
            pnlScreen.Controls.Add(txtMatKhau);
            pnlScreen.Controls.Add(lblMatKhau);
            pnlScreen.Controls.Add(pnlLine1);
            pnlScreen.Controls.Add(txtDangNhap);
            pnlScreen.Controls.Add(lblTaiKhoan);
            pnlScreen.Controls.Add(lblTitle);
            pnlScreen.Controls.Add(pnlLeft);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(800, 450);
            pnlScreen.TabIndex = 1;
            // 
            // lnkDangNhap
            // 
            lnkDangNhap.AutoSize = true;
            lnkDangNhap.LinkColor = Color.FromArgb(24, 119, 242);
            lnkDangNhap.Location = new Point(412, 414);
            lnkDangNhap.Name = "lnkDangNhap";
            lnkDangNhap.Size = new Size(155, 15);
            lnkDangNhap.TabIndex = 12;
            lnkDangNhap.TabStop = true;
            lnkDangNhap.Text = "Đã có tài khoản? Đăng nhập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 119, 242);
            panel1.Location = new Point(412, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 2);
            panel1.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.None;
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(412, 307);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(320, 22);
            txtHoTen.TabIndex = 11;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.Gray;
            lblHoTen.Location = new Point(410, 268);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 17);
            lblHoTen.TabIndex = 10;
            lblHoTen.Text = "Tên đăng nhập";
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
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(24, 119, 242);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(410, 355);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(320, 45);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Register";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine2.Location = new Point(410, 240);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(320, 2);
            pnlLine2.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(410, 220);
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
            lblMatKhau.Location = new Point(412, 183);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(66, 17);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine1.Location = new Point(410, 143);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(320, 2);
            pnlLine1.TabIndex = 4;
            // 
            // txtDangNhap
            // 
            txtDangNhap.BorderStyle = BorderStyle.None;
            txtDangNhap.Font = new Font("Segoe UI", 12F);
            txtDangNhap.Location = new Point(412, 123);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(320, 22);
            txtDangNhap.TabIndex = 3;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.Gray;
            lblTaiKhoan.Location = new Point(412, 86);
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
            lblTitle.Location = new Point(462, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "\r\nĐĂNG KÝ TÀI KHOẢN";
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
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            pnlScreen.ResumeLayout(false);
            pnlScreen.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlScreen;
        private Button btnThoat;
        private Button btnDangKy;
        private Panel pnlLine2;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Panel pnlLine1;
        private TextBox txtDangNhap;
        private Label lblTaiKhoan;
        private Label lblTitle;
        private Panel pnlLeft;
        private Label lblWelcome;
        private Panel panel1;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private LinkLabel lnkDangNhap;
    }
}