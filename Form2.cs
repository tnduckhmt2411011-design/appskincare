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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra có để trống ô nào không
            if (txtDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLySkincare_V1;Integrated Security=True";

            // Kết nối SQL
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                try
                {
                    con.Open();
                    // Dếm xem có bao nhiêu dòng khớp với tài khoản và mật khẩu này
                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TaiKhoan AND MatKhau = @MatKhau";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TaiKhoan", txtDangNhap.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                    // Thực thi và lấy kết quả đếm được
                    int ketQua = (int)cmd.ExecuteScalar();

                    // Xử lý kết quả
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Chào mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form5 frmDash = new Form5();
                        this.Hide(); // Giấu form đăng nhập đi
                        frmDash.ShowDialog();
                        this.Close(); // Tắt hoàn toàn form đăng nhập khi đóng form tổng
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}