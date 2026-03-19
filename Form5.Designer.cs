namespace appSkincare
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            btnThoat = new Button();
            imageList1 = new ImageList(components);
            btnThongKe = new Button();
            btnSanPham = new Button();
            btnRoutine = new Button();
            pnlScreen = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(btnRoutine);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 720);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ButtonFace;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.ImageIndex = 3;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(0, 524);
            btnThoat.MinimumSize = new Size(0, 60);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(50, 0, 0, 0);
            btnThoat.Size = new Size(207, 67);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
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
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonFace;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.ImageIndex = 1;
            btnThongKe.ImageList = imageList1;
            btnThongKe.Location = new Point(-4, 382);
            btnThongKe.MinimumSize = new Size(0, 60);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(50, 0, 0, 0);
            btnThongKe.Size = new Size(207, 62);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "TRA CỨU";
            btnThongKe.TextAlign = ContentAlignment.MiddleRight;
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
            btnSanPham.ImageIndex = 4;
            btnSanPham.ImageList = imageList1;
            btnSanPham.Location = new Point(-10, 234);
            btnSanPham.MinimumSize = new Size(0, 60);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(50, 0, 0, 0);
            btnSanPham.Size = new Size(217, 69);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "SẢN PHẨM";
            btnSanPham.TextAlign = ContentAlignment.MiddleRight;
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
            btnRoutine.ImageIndex = 2;
            btnRoutine.ImageList = imageList1;
            btnRoutine.Location = new Point(0, 86);
            btnRoutine.MinimumSize = new Size(0, 60);
            btnRoutine.Name = "btnRoutine";
            btnRoutine.Padding = new Padding(50, 0, 0, 0);
            btnRoutine.Size = new Size(203, 67);
            btnRoutine.TabIndex = 1;
            btnRoutine.Text = "ROUTINE";
            btnRoutine.TextAlign = ContentAlignment.MiddleRight;
            btnRoutine.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoutine.UseVisualStyleBackColor = false;
            btnRoutine.Click += btnRoutine_Click_1;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.WhiteSmoke;
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(200, 0);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(1080, 720);
            pnlScreen.TabIndex = 3;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlScreen);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
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
    }
}