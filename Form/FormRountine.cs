using System.Data;
using System.Data.SqlClient;
namespace appSkincare
{
    public partial class FormRountine : Form
    {
        string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLySkincare_V1;Integrated Security=True";
        private void LoadSanPham()
        {
            // Dùng khối using để tự động đóng kết nối khi chạy xong, cực kỳ an toàn
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                con.Open();
                string sql = "SELECT MaSP, TenSanPham FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                clbSanPham.DataSource = dt;
                clbSanPham.DisplayMember = "TenSanPham";
                clbSanPham.ValueMember = "MaSP";
            }
        }
        public FormRountine()
        {
            InitializeComponent();
        }

        private void FormRoutine_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLichTrinh();
        }

        private void LoadLichTrinh()
        {
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                con.Open();
                // Gom 3 bảng lại làm 1
                string sql = @"
            SELECT 
                r.MaRT AS [MÃ RT], 
                r.Ngay AS [NGÀY LT], 
                r.Buoi AS [BUỔI LT], 
                STRING_AGG(sp.TenSanPham, ', ') AS [SẢN PHẨM ROUTINE (Đã Tick)],
                r.TinhTrangDa AS [TÌNH TRẠNG DA]
            FROM Routine r
            LEFT JOIN ChiTietRoutine ct ON r.MaRT = ct.MaRT
            LEFT JOIN SanPham sp ON ct.MaSP = sp.MaSP
            GROUP BY r.MaRT, r.Ngay, r.Buoi, r.TinhTrangDa
            ORDER BY r.MaRT ASC"; // Xếp buổi mới nhất lên đầu

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Đưa toàn bộ dữ liệu ra bảng DataGridView
                dgvLichTrinh.DataSource = dt;

                // Ép các cột ngắn ôm sát chữ
                dgvLichTrinh.Columns["MÃ RT"].Width = 70;
                dgvLichTrinh.Columns["NGÀY LT"].Width = 100;
                dgvLichTrinh.Columns["BUỔI LT"].Width = 70;

                // Cho 2 cột dài tự động chia nhau chiếm hết toàn bộ khoảng trống còn lại
                dgvLichTrinh.Columns["SẢN PHẨM ROUTINE (Đã Tick)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvLichTrinh.Columns["SẢN PHẨM ROUTINE (Đã Tick)"].FillWeight = 150;

                dgvLichTrinh.Columns["TÌNH TRẠNG DA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvLichTrinh.Columns["TÌNH TRẠNG DA"].FillWeight = 100;

                dgvLichTrinh.Columns["NGÀY LT"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (cboBuoi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Buổi (Sáng/Tối)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clbSanPham.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng tick chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                con.Open();

                // Dùng Transaction: Nếu lưu 1 trong 2 bảng bị lỗi thì hủy toàn bộ --> không bị rác dữ liệu
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // SCOPE_IDENTITY() giúp lấy ngay cái MaRT vừa được SQL tự động tăng
                    string sqlRoutine = @"INSERT INTO Routine (Ngay, Buoi, TinhTrangDa) 
                                  VALUES (@Ngay, @Buoi, @TinhTrangDa);
                                  SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdRoutine = new SqlCommand(sqlRoutine, con, transaction);
                    cmdRoutine.Parameters.AddWithValue("@Ngay", dtpNgay.Value.Date);
                    cmdRoutine.Parameters.AddWithValue("@Buoi", cboBuoi.Text);
                    cmdRoutine.Parameters.AddWithValue("@TinhTrangDa", txtTinhTrangDa.Text);

                    // Excute và lấy cái MaRT vừa tạo
                    int newMaRT = Convert.ToInt32(cmdRoutine.ExecuteScalar());

                    string sqlChiTiet = "INSERT INTO ChiTietRoutine (MaRT, MaSP) VALUES (@MaRT, @MaSP)";

                    // Chạy vòng lặp qua từng món đồ đã tick chọn trong CheckedListBox
                    foreach (DataRowView item in clbSanPham.CheckedItems)
                    {
                        SqlCommand cmdChiTiet = new SqlCommand(sqlChiTiet, con, transaction);
                        cmdChiTiet.Parameters.AddWithValue("@MaRT", newMaRT);
                        cmdChiTiet.Parameters.AddWithValue("@MaSP", item["MaSP"]); // Lấy cái mã ẩn mà hôm qua đã lưu
                        cmdChiTiet.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Đã thêm Routine thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLichTrinh();

                    txtTinhTrangDa.Clear();
                    for (int i = 0; i < clbSanPham.Items.Count; i++) clbSanPham.SetItemChecked(i, false);
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Có lỗi thì quay lại
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã click chọn 1 dòng trên bảng chưa
            if (dgvLichTrinh.CurrentRow == null || dgvLichTrinh.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn lịch trình để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy "MÃ RT" của dòng đang được chọn
            string maRT = dgvLichTrinh.CurrentRow.Cells["MÃ RT"].Value.ToString();

            // Hiển thị hộp thoại hỏi lại cho chắc chắn
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa Lịch trình mã {maRT} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Mở kết nối và xoá
                using (SqlConnection con = new SqlConnection(chuoiKetNoi))
                {
                    try
                    {
                        con.Open();
                        // Xóa dòng ở bảng Routine, SQL sẽ tự động xoá các món đồ bên bảng ChiTietRoutine
                        string sqlXoa = "DELETE FROM Routine WHERE MaRT = @MaRT";
                        SqlCommand cmd = new SqlCommand(sqlXoa, con);
                        cmd.Parameters.AddWithValue("@MaRT", maRT);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại bảng
                        LoadLichTrinh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa chữ ở ô Tình trạng da
            txtTinhTrangDa.Clear();

            // Trả ngày về hôm nay
            dtpNgay.Value = DateTime.Now;

            // Bỏ tick toàn bộ danh sách sản phẩm
            for (int i = 0; i < clbSanPham.Items.Count; i++)
            {
                clbSanPham.SetItemChecked(i, false);
            }
        }

    }
}
