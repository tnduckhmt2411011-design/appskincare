namespace appSkincare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnXoa = new Button();
            imageList1 = new ImageList(components);
            btnLamMoi = new Button();
            btnThem = new Button();
            clbSanPham = new CheckedListBox();
            txtTinhTrangDa = new TextBox();
            cboBuoi = new ComboBox();
            dtpNgay = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvLichTrinh = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichTrinh).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(clbSanPham);
            panel2.Controls.Add(txtTinhTrangDa);
            panel2.Controls.Add(cboBuoi);
            panel2.Controls.Add(dtpNgay);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 636);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ButtonFace;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.ImageIndex = 1;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(732, 239);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(5, 0, 0, 0);
            btnXoa.Size = new Size(135, 52);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá Routine";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.White;
            imageList1.Images.SetKeyName(0, "add_icon-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "trash-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "lúp-removebg-preview.png");
            imageList1.Images.SetKeyName(3, "làm_mới-removebg-preview.png");
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.RoyalBlue;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ButtonFace;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 3;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(557, 239);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Padding = new Padding(10, 0, 0, 0);
            btnLamMoi.Size = new Size(135, 52);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới RT";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SeaGreen;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ButtonFace;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.ImageIndex = 0;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(381, 239);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(5, 0, 0, 0);
            btnThem.Size = new Size(135, 52);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm Routine";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // clbSanPham
            // 
            clbSanPham.BorderStyle = BorderStyle.FixedSingle;
            clbSanPham.CheckOnClick = true;
            clbSanPham.FormattingEnabled = true;
            clbSanPham.Location = new Point(15, 209);
            clbSanPham.Name = "clbSanPham";
            clbSanPham.Size = new Size(300, 162);
            clbSanPham.TabIndex = 8;
            // 
            // txtTinhTrangDa
            // 
            txtTinhTrangDa.Location = new Point(381, 92);
            txtTinhTrangDa.Multiline = true;
            txtTinhTrangDa.Name = "txtTinhTrangDa";
            txtTinhTrangDa.Size = new Size(486, 114);
            txtTinhTrangDa.TabIndex = 7;
            // 
            // cboBuoi
            // 
            cboBuoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuoi.FormattingEnabled = true;
            cboBuoi.Items.AddRange(new object[] { "Sáng", "Tối" });
            cboBuoi.Location = new Point(205, 91);
            cboBuoi.Name = "cboBuoi";
            cboBuoi.Size = new Size(110, 25);
            cboBuoi.TabIndex = 6;
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(15, 92);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(117, 25);
            dtpNgay.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(381, 72);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 4;
            label5.Text = "Tình trạng da:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(15, 172);
            label4.Name = "label4";
            label4.Size = new Size(264, 34);
            label4.TabIndex = 3;
            label4.Text = "DANH SÁCH SẢN PHẨM TRONG ROUTINE\r\n(Tick chọn món dùng hôm nay):\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(205, 72);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 2;
            label3.Text = "Buổi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(321, 25);
            label1.TabIndex = 0;
            label1.Text = "NHẬP LỊCH TRÌNH THEO ROUTINE";
            // 
            // dgvLichTrinh
            // 
            dgvLichTrinh.AllowUserToAddRows = false;
            dgvLichTrinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichTrinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLichTrinh.BackgroundColor = Color.White;
            dgvLichTrinh.BorderStyle = BorderStyle.None;
            dgvLichTrinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichTrinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichTrinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLichTrinh.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLichTrinh.Location = new Point(15, 377);
            dgvLichTrinh.Name = "dgvLichTrinh";
            dgvLichTrinh.RowTemplate.Height = 30;
            dgvLichTrinh.Size = new Size(931, 247);
            dgvLichTrinh.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 636);
            Controls.Add(dgvLichTrinh);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichTrinh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboBuoi;
        private DateTimePicker dtpNgay;
        private Label label5;
        private TextBox txtTinhTrangDa;
        private CheckedListBox clbSanPham;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThem;
        private DataGridView dgvLichTrinh;
        private ImageList imageList1;
    }
}
