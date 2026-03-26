namespace appSkincare
{
    partial class FormMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            btnDanhGia = new Button();
            imageList1 = new ImageList(components);
            btnThoat = new Button();
            btnThongKe = new Button();
            btnSanPham = new Button();
            btnRoutine = new Button();
            btnMenu = new Button();
            pnlScreen = new Panel();
            pnlAccountMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblAccountName = new Label();
            btnDangXuat = new Button();
            imageList2 = new ImageList(components);
            panelMenu = new Panel();
            pbAccount = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            pnlScreen.SuspendLayout();
            pnlAccountMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnDanhGia);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(btnRoutine);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 720);
            panel1.TabIndex = 1;
            // 
            // btnDanhGia
            // 
            btnDanhGia.FlatAppearance.BorderSize = 0;
            btnDanhGia.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnDanhGia.FlatStyle = FlatStyle.Flat;
            btnDanhGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDanhGia.ForeColor = SystemColors.ButtonFace;
            btnDanhGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhGia.ImageIndex = 11;
            btnDanhGia.ImageList = imageList1;
            btnDanhGia.Location = new Point(-10, 538);
            btnDanhGia.MinimumSize = new Size(0, 60);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Padding = new Padding(20, 0, 0, 0);
            btnDanhGia.Size = new Size(217, 69);
            btnDanhGia.TabIndex = 7;
            btnDanhGia.Text = "ĐÁNH GIÁ";
            btnDanhGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDanhGia.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "sp-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "thống_kê-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "lịch-removebg-preview.png");
            imageList1.Images.SetKeyName(3, "exit-icon-png-close-0-removebg-preview.png");
            imageList1.Images.SetKeyName(4, "824792-removebg-preview (1).png");
            imageList1.Images.SetKeyName(5, "Hamburger_icon.svg-removebg-preview (1).png");
            imageList1.Images.SetKeyName(6, "skincare-removebg-preview.png");
            imageList1.Images.SetKeyName(7, "Hamburger_icon.svg-removebg-preview (1).png");
            imageList1.Images.SetKeyName(8, "exit-icon-png-close-0-removebg-preview.png");
            imageList1.Images.SetKeyName(9, "thống_kê-removebg-preview.png");
            imageList1.Images.SetKeyName(10, "lịch-removebg-preview.png");
            imageList1.Images.SetKeyName(11, "707675-removebg-preview.png");
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CadetBlue;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ButtonFace;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.ImageIndex = 8;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(0, 653);
            btnThoat.MinimumSize = new Size(0, 60);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(15, 0, 0, 0);
            btnThoat.Size = new Size(207, 67);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonFace;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.ImageIndex = 9;
            btnThongKe.ImageList = imageList1;
            btnThongKe.Location = new Point(-4, 389);
            btnThongKe.MinimumSize = new Size(0, 60);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(15, 0, 0, 0);
            btnThongKe.Size = new Size(207, 62);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "TRA CỨU";
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click_1;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSanPham.ForeColor = SystemColors.ButtonFace;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.ImageIndex = 6;
            btnSanPham.ImageList = imageList1;
            btnSanPham.Location = new Point(-10, 233);
            btnSanPham.MinimumSize = new Size(0, 60);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(20, 0, 0, 0);
            btnSanPham.Size = new Size(217, 69);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "SẢN PHẨM";
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click_1;
            // 
            // btnRoutine
            // 
            btnRoutine.BackColor = Color.Teal;
            btnRoutine.FlatAppearance.BorderSize = 0;
            btnRoutine.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnRoutine.FlatStyle = FlatStyle.Flat;
            btnRoutine.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRoutine.ForeColor = SystemColors.ButtonFace;
            btnRoutine.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoutine.ImageIndex = 10;
            btnRoutine.ImageList = imageList1;
            btnRoutine.Location = new Point(0, 107);
            btnRoutine.MinimumSize = new Size(0, 60);
            btnRoutine.Name = "btnRoutine";
            btnRoutine.Padding = new Padding(15, 0, 0, 0);
            btnRoutine.Size = new Size(203, 67);
            btnRoutine.TabIndex = 1;
            btnRoutine.Text = "ROUTINE";
            btnRoutine.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoutine.UseVisualStyleBackColor = false;
            btnRoutine.Click += btnRoutine_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.CadetBlue;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMenu.ForeColor = SystemColors.ButtonFace;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.ImageIndex = 7;
            btnMenu.ImageList = imageList1;
            btnMenu.Location = new Point(0, 0);
            btnMenu.MinimumSize = new Size(0, 60);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(25, 0, 0, 0);
            btnMenu.Size = new Size(200, 60);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "MENU";
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.WhiteSmoke;
            pnlScreen.Controls.Add(pnlAccountMenu);
            pnlScreen.Controls.Add(panelMenu);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(200, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(1080, 720);
            pnlScreen.TabIndex = 3;
            // 
            // pnlAccountMenu
            // 
            pnlAccountMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAccountMenu.BackColor = Color.FloralWhite;
            pnlAccountMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountMenu.Controls.Add(pictureBox1);
            pnlAccountMenu.Controls.Add(lblAccountName);
            pnlAccountMenu.Controls.Add(btnDangXuat);
            pnlAccountMenu.Location = new Point(918, 63);
            pnlAccountMenu.Name = "pnlAccountMenu";
            pnlAccountMenu.Size = new Size(159, 228);
            pnlAccountMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.OnePiece_Monkey_D_Luffy_1024x819_removebg_preview;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblAccountName
            // 
            lblAccountName.AutoEllipsis = true;
            lblAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(-1, 94);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(159, 21);
            lblAccountName.TabIndex = 3;
            lblAccountName.Text = "TEXT";
            lblAccountName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Gainsboro;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.ImageIndex = 0;
            btnDangXuat.ImageList = imageList2;
            btnDangXuat.Location = new Point(22, 187);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(117, 36);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "exit-icon-png-close-0-removebg-preview.png");
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CadetBlue;
            panelMenu.Controls.Add(pbAccount);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1080, 60);
            panelMenu.TabIndex = 0;
            // 
            // pbAccount
            // 
            pbAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAccount.Cursor = Cursors.Hand;
            pbAccount.ErrorImage = null;
            pbAccount.Image = Properties.Resources.OnePiece_Monkey_D_Luffy_1024x819_removebg_preview;
            pbAccount.InitialImage = null;
            pbAccount.Location = new Point(963, 0);
            pbAccount.Name = "pbAccount";
            pbAccount.Size = new Size(105, 60);
            pbAccount.SizeMode = PictureBoxSizeMode.Zoom;
            pbAccount.TabIndex = 1;
            pbAccount.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.CadetBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1080, 60);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ LỊCH TRÌNH SKINCARE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlScreen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lịch trình Skincare";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            pnlScreen.ResumeLayout(false);
            pnlAccountMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private Button btnThongKe;
        private Button btnSanPham;
        private Button btnRoutine;
        private Panel pnlScreen;
        private ImageList imageList1;
        private Button btnMenu;
        private Panel panelMenu;
        private Label label1;
        private PictureBox pbAccount;
        private Panel pnlAccountMenu;
        private Button btnDangXuat;
        private Label lblAccountName;
        private PictureBox pictureBox1;
        private ImageList imageList2;
        private Button btnDanhGia;
    }
}