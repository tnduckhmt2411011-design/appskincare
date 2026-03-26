using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appSkincare
{
    public partial class FormSanPham : Form
    {
        string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLySkincare_V1;Integrated Security=True";

        private void LoadDanhSachSanPham()
        {
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                con.Open();

                // Dùng AS để SQL tự tao cột cho Form Sản Phẩm
                string sql = @"
            SELECT 
                MaSP AS [MÃ SP], 
                TenSanPham AS [TÊN SẢN PHẨM], 
                PhanLoai AS [PHÂN LOẠI] 
            FROM SanPham";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Đổ dữ liệu vào DataGridView
                dgvSanPham.DataSource = dt;

                // Căn chỉnh độ rộng
                dgvSanPham.Columns["MÃ SP"].Width = 80;
                dgvSanPham.Columns["PHÂN LOẠI"].Width = 150;

                // Cho cột Tên Sản Phẩm tự động giãn ra chiếm hết chỗ trống còn lại
                dgvSanPham.Columns["TÊN SẢN PHẨM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDanhSachSanPham();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                // Chay dữ liệu từ dưới bảng lên các ô nhập liệu
                txtSanPham.Text = row.Cells["TÊN SẢN PHẨM"].Value.ToString();
                cboPhanLoai.Text = row.Cells["PHÂN LOẠI"].Value.ToString();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên và chọn Phân loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO SanPham (TenSanPham, PhanLoai) VALUES (@TenSP, @PhanLoai)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TenSP", txtSanPham.Text);
                    cmd.Parameters.AddWithValue("@PhanLoai", cboPhanLoai.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm món mới vào tủ Skincare", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSanPham(); // Cập nhật lại bảng
                    txtSanPham.Clear();      // Xóa chữ cho sạch
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null || dgvSanPham.CurrentRow.IsNewRow) return;

            string maSP = dgvSanPham.CurrentRow.Cells["MÃ SP"].Value.ToString();

            // Hộp thoại nhắc nhở user cẩn thận trước khi xóa
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?\n\nCẢNH BÁO: Món này sẽ biến mất khỏi tất cả các lịch trình Routine bạn từng lưu trước đó", "Cẩn thận nhé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(chuoiKetNoi))
                {
                    try
                    {
                        con.Open();
                        string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachSanPham();
                        txtSanPham.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
