namespace appSkincare
{
    partial class FormSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            panel2 = new Panel();
            dgvSanPham = new DataGridView();
            txtSanPham = new TextBox();
            btnXoaSP = new Button();
            imageList2 = new ImageList(components);
            btnThemSP = new Button();
            cboPhanLoai = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(dgvSanPham);
            panel2.Controls.Add(txtSanPham);
            panel2.Controls.Add(btnXoaSP);
            panel2.Controls.Add(btnThemSP);
            panel2.Controls.Add(cboPhanLoai);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 2;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.Location = new Point(15, 211);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowTemplate.Height = 30;
            dgvSanPham.Size = new Size(766, 218);
            dgvSanPham.TabIndex = 13;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // txtSanPham
            // 
            txtSanPham.Location = new Point(15, 92);
            txtSanPham.Multiline = true;
            txtSanPham.Name = "txtSanPham";
            txtSanPham.Size = new Size(354, 23);
            txtSanPham.TabIndex = 12;
            // 
            // btnXoaSP
            // 
            btnXoaSP.BackColor = Color.Brown;
            btnXoaSP.Cursor = Cursors.Hand;
            btnXoaSP.FlatAppearance.BorderSize = 0;
            btnXoaSP.FlatStyle = FlatStyle.Flat;
            btnXoaSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaSP.ForeColor = SystemColors.ButtonFace;
            btnXoaSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaSP.ImageIndex = 1;
            btnXoaSP.ImageList = imageList2;
            btnXoaSP.Location = new Point(211, 135);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Padding = new Padding(15, 0, 0, 0);
            btnXoaSP.Size = new Size(158, 52);
            btnXoaSP.TabIndex = 11;
            btnXoaSP.Text = "Xoá Sản Phẩm";
            btnXoaSP.TextAlign = ContentAlignment.MiddleRight;
            btnXoaSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaSP.UseVisualStyleBackColor = false;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.White;
            imageList2.Images.SetKeyName(0, "add_icon-removebg-preview.png");
            imageList2.Images.SetKeyName(1, "trash-removebg-preview.png");
            imageList2.Images.SetKeyName(2, "lúp-removebg-preview.png");
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = Color.SeaGreen;
            btnThemSP.Cursor = Cursors.Hand;
            btnThemSP.FlatAppearance.BorderSize = 0;
            btnThemSP.FlatStyle = FlatStyle.Flat;
            btnThemSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemSP.ForeColor = SystemColors.ButtonFace;
            btnThemSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemSP.ImageIndex = 0;
            btnThemSP.ImageList = imageList2;
            btnThemSP.Location = new Point(15, 135);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Padding = new Padding(8, 0, 0, 0);
            btnThemSP.Size = new Size(158, 52);
            btnThemSP.TabIndex = 9;
            btnThemSP.Text = "Thêm Sản Phẩm";
            btnThemSP.TextAlign = ContentAlignment.MiddleRight;
            btnThemSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSP.UseVisualStyleBackColor = false;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // cboPhanLoai
            // 
            cboPhanLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhanLoai.FormattingEnabled = true;
            cboPhanLoai.Items.AddRange(new object[] { "Làm sạch", "Dưỡng ẩm", "Dưỡng trắng", "Bảo vệ", "Phục hồi", "Trị mụn", "", "" });
            cboPhanLoai.Location = new Point(453, 92);
            cboPhanLoai.Name = "cboPhanLoai";
            cboPhanLoai.Size = new Size(110, 23);
            cboPhanLoai.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(453, 72);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 2;
            label3.Text = "Phân loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "SẢN PHẨM";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += Form3_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnXoaSP;
        private Button btnThemSP;
        private ComboBox cboPhanLoai;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSanPham;
        private DataGridView dgvSanPham;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}