using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSkincare
{
    public partial class FormDanhGia : Form
    {
        public FormDanhGia()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void Form7_Load(object sender, EventArgs e)
        {
            cboSanPham.Items.Add("Serum Vitamin C");
            cboSanPham.Items.Add("Kem Dưỡng Ẩm");
            cboSanPham.Items.Add("Toner Trà Xanh");
            cboSanPham.SelectedIndex = 0;
        }
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numSoSao_ValueChanged(object sender, EventArgs e) { }
        private void txtNhanXet_TextChanged(object sender, EventArgs e) { }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            AddReview();
        }
        private void dgvDanhGia_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void AddReview()
        {
            string tenSP = cboSanPham.Text;    
            int sao = (int)numSoSao.Value;
            string binhLuan = txtNhanXet.Text;
            string ngayHT = DateTime.Now.ToString("dd/MM/yyyy");

            string hienThiSao = "";
            for (int i = 0; i < sao; i++) { hienThiSao += "⭐"; }

            if (string.IsNullOrEmpty(binhLuan))
            {
                MessageBox.Show("Vui lòng nhập nhận xét trước khi thêm!");
                return;
            }
            dgvDanhGia.Rows.Add(tenSP, hienThiSao, binhLuan, ngayHT);
            txtNhanXet.Clear();
        }
    }
}
