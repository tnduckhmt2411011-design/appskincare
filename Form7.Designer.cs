namespace appSkincare
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cboSanPham = new ComboBox();
            label3 = new Label();
            numSoSao = new NumericUpDown();
            label4 = new Label();
            txtNhanXet = new TextBox();
            btnThem = new Button();
            dgvDanhGia = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoSao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(162, 17);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 0;
            label1.Text = "Đánh Giá Sản Phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 75);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Chọn Sản Phẩm";
            label2.Click += label2_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.BackColor = SystemColors.MenuBar;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(157, 72);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(194, 23);
            cboSanPham.TabIndex = 2;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 131);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Đánh Giá";
            // 
            // numSoSao
            // 
            numSoSao.BackColor = SystemColors.MenuBar;
            numSoSao.Location = new Point(157, 128);
            numSoSao.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSoSao.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoSao.Name = "numSoSao";
            numSoSao.Size = new Size(43, 23);
            numSoSao.TabIndex = 4;
            numSoSao.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numSoSao.ValueChanged += numSoSao_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 197);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Nhận Xét";
            // 
            // txtNhanXet
            // 
            txtNhanXet.BackColor = SystemColors.Menu;
            txtNhanXet.Location = new Point(142, 191);
            txtNhanXet.Name = "txtNhanXet";
            txtNhanXet.Size = new Size(308, 23);
            txtNhanXet.TabIndex = 6;
            txtNhanXet.TextChanged += txtNhanXet_TextChanged;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Menu;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.HotTrack;
            btnThem.Location = new Point(186, 232);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 37);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm đánh giá";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // dgvDanhGia
            // 
            dgvDanhGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhGia.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvDanhGia.Location = new Point(2, 314);
            dgvDanhGia.Name = "dgvDanhGia";
            dgvDanhGia.RowHeadersWidth = 51;
            dgvDanhGia.RowTemplate.Height = 24;
            dgvDanhGia.Size = new Size(702, 97);
            dgvDanhGia.TabIndex = 8;
            dgvDanhGia.CellContentClick += dgvDanhGia_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 294);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 9;
            label5.Text = "Danh Sách Đánh Giá";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(700, 422);
            Controls.Add(label5);
            Controls.Add(dgvDanhGia);
            Controls.Add(btnThem);
            Controls.Add(txtNhanXet);
            Controls.Add(label4);
            Controls.Add(numSoSao);
            Controls.Add(label3);
            Controls.Add(cboSanPham);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Đánh giá sản phẩm";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)numSoSao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSoSao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
