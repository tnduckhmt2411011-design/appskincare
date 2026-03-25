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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            // Gắn sự kiện cho các control
            lnkDangNhap.LinkClicked += lnkDangNhap_LinkClicked;
            btnThoat.Click += btnThoat_Click;
            btnDangKy.Click += btnDangKy_Click;
        }

        private void lnkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ẩn Form đăng ký, mở Form đăng nhập và đóng Form đăng ký sau khi Form2 đóng
            this.Hide();
            Form2 frmLogin = new Form2();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLySkincare_V1;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen) VALUES (@TK, @MK, @HT)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@TK", txtDangNhap.Text.Trim());
                        cmd.Parameters.AddWithValue("@MK", txtMatKhau.Text.Trim());
                        cmd.Parameters.AddWithValue("@HT", txtHoTen.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Xóa rỗng các textbox
                            txtHoTen.Clear();
                            txtDangNhap.Clear();
                            txtMatKhau.Clear();

                            // Chuyển về Form đăng nhập
                            this.Hide();
                            Form2 frmLogin = new Form2();
                            frmLogin.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx) when (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
