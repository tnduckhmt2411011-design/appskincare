using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appSkincare
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDangKy frmRegister = new FormDangKy();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra có để trống ô nào không
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
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
                    string sql = "SELECT HoTen FROM TaiKhoan WHERE TenDangNhap = @TaiKhoan AND MatKhau = @MatKhau";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                    // Thực thi và lấy kết quả
                    object result = cmd.ExecuteScalar();

                    // Xử lý kết quả
                    if (result != null)
                    {
                        string hoTenNguoiDung = result.ToString(); // Ép kiểu lấy họ tên
                        MessageBox.Show("Đăng nhập thành công", "Chào mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormMenu frmDash = new FormMenu(hoTenNguoiDung);
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

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện chữ
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn chữ
            }
        }
    }
}
