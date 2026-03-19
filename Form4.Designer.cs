namespace appSkincare
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel2 = new Panel();
            dgvThongKe = new DataGridView();
            btnTraCuu = new Button();
            dtpNgayThongKe = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(dgvThongKe);
            panel2.Controls.Add(btnTraCuu);
            panel2.Controls.Add(dtpNgayThongKe);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 360);
            panel2.TabIndex = 2;
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvThongKe.BackgroundColor = Color.White;
            dgvThongKe.BorderStyle = BorderStyle.None;
            dgvThongKe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThongKe.Location = new Point(15, 130);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowTemplate.Height = 30;
            dgvThongKe.Size = new Size(803, 218);
            dgvThongKe.TabIndex = 11;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.RoyalBlue;
            btnTraCuu.Cursor = Cursors.Hand;
            btnTraCuu.FlatAppearance.BorderSize = 0;
            btnTraCuu.FlatStyle = FlatStyle.Flat;
            btnTraCuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = SystemColors.ButtonFace;
            btnTraCuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTraCuu.ImageIndex = 2;
            btnTraCuu.ImageList = imageList1;
            btnTraCuu.Location = new Point(268, 46);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Padding = new Padding(15, 0, 0, 0);
            btnTraCuu.Size = new Size(135, 52);
            btnTraCuu.TabIndex = 10;
            btnTraCuu.Text = "Tìm kiếm";
            btnTraCuu.TextAlign = ContentAlignment.MiddleRight;
            btnTraCuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // dtpNgayThongKe
            // 
            dtpNgayThongKe.Format = DateTimePickerFormat.Short;
            dtpNgayThongKe.Location = new Point(79, 60);
            dtpNgayThongKe.Name = "dtpNgayThongKe";
            dtpNgayThongKe.Size = new Size(117, 23);
            dtpNgayThongKe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(30, 64);
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
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "TRA CỨU";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.White;
            imageList1.Images.SetKeyName(0, "add_icon-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "trash-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "tìm-removebg-preview.png");
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 360);
            Controls.Add(panel2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnTraCuu;
        private DateTimePicker dtpNgayThongKe;
        private Label label2;
        private Label label1;
        private DataGridView dgvThongKe;
        private ImageList imageList1;
    }
}