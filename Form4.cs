using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSkincare
{
    public partial class Form4 : Form
    {
        string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLySkincare_V1;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            // Lấy lại chuỗi kết nối quen thuộc
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                con.Open();

                // Gom 3 bảng + lọc WHERE
                string sql = @"
            SELECT 
                r.MaRT AS [MÃ RT], 
                r.Ngay AS [NGÀY LT], 
                r.Buoi AS [BUỔI LT], 
                STRING_AGG(sp.TenSanPham, ', ') AS [SẢN PHẨM ĐÃ DÙNG],
                r.TinhTrangDa AS [TÌNH TRẠNG DA]
            FROM Routine r
            LEFT JOIN ChiTietRoutine ct ON r.MaRT = ct.MaRT
            LEFT JOIN SanPham sp ON ct.MaSP = sp.MaSP
            WHERE r.Ngay = @NgayLoc
            GROUP BY r.MaRT, r.Ngay, r.Buoi, r.TinhTrangDa";

                SqlCommand cmd = new SqlCommand(sql, con);
                // Trỏ cái ngày cần tìm vào ô lịch trên giao diện
                cmd.Parameters.AddWithValue("@NgayLoc", dtpNgayThongKe.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Đổ dữ liệu ra bảng
                dgvThongKe.DataSource = dt;

                dgvThongKe.Columns["SẢN PHẨM ĐÃ DÙNG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Báo lỗi nếu ngày đó không nhập app
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ngày này bạn không Skincare", "Trống trơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
