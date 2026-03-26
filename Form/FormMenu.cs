using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSkincare
{
    public partial class FormMenu : Form
    {
        // Biến để nhớ xem Form nào đang mở
        private Form currentFormChild;
        // Biến để nhớ nút nào đang được bấm
        private Button currentButton;
        // Biến lưu trạng thái sidebar (mở / gọn)
        private bool isSidebarExpanded = true; // theo yêu cầu
        // Timer dùng để tạo animation thu gọn / mở sidebar
        private System.Windows.Forms.Timer sidebarTimer;
        // Lưu text gốc của các nút để khôi phục khi mở sidebar
        private string btnMenuText;
        private string btnRoutineText;
        private string btnSanPhamText;
        private string btnThongKeText;
        private string btnDanhGiaText;
        private string btnThoatText;

        // Constructor bổ sung nhận tên người dùng và gắn sự kiện cho avatar / đăng xuất
        public FormMenu(string hoTen)
        {
            // Khởi tạo các control (bắt buộc)
            InitializeComponent();

            // --- Gắn sự kiện cho pbAccount và btnDangXuat NGAY BÊN DƯỚI InitializeComponent() ---
            if (pbAccount != null)
            {
                pbAccount.Click += pbAccount_Click;
                // Hiệu ứng hover: đổi màu nền khi chuột vào/ra
                pbAccount.MouseEnter += pbAccount_MouseEnter;
                pbAccount.MouseLeave += pbAccount_MouseLeave;
            }
            if (btnDangXuat != null) btnDangXuat.Click += btnDangXuat_Click;

            // Kiểm tra nhanh xem các control quan trọng có null hay đã Dispose không
            // (nếu null, các hành động tiếp theo sẽ được bỏ qua để tránh ngoại lệ)
            // Khởi tạo timer sidebar để tạo hiệu ứng mượt mà
            sidebarTimer = new System.Windows.Forms.Timer();
            sidebarTimer.Interval = 15; // ms: 10-15 ms để mượt
            sidebarTimer.Tick += sidebarTimer_Tick;

            // Lưu lại text gốc của các nút để khôi phục khi mở rộng
            if (btnMenu != null) btnMenuText = btnMenu.Text;
            if (btnRoutine != null) btnRoutineText = btnRoutine.Text;
            if (btnSanPham != null) btnSanPhamText = btnSanPham.Text;
            if (btnThongKe != null) btnThongKeText = btnThongKe.Text;
            if (btnDanhGia != null) btnDanhGiaText = btnDanhGia.Text;
            if (btnThoat != null) btnThoatText = btnThoat.Text;

            // Gắn sự kiện Click cho nút menu bằng code để chắc chắn luôn chạy
            if (btnMenu != null)
            {
                btnMenu.Click += btnMenu_Click;
            }

            // Gắn sự kiện Click cho nút Đánh Giá nếu có
            if (btnDanhGia != null)
            {
                btnDanhGia.Click += btnDanhGia_Click;
            }

            // Hiển thị tên người dùng nếu nhãn tồn tại
            if (lblAccountName != null) lblAccountName.Text = "Chào " + hoTen;

            // Đảm bảo pnlAccountMenu ở trạng thái ẩn ban đầu
            if (pnlAccountMenu != null) pnlAccountMenu.Visible = false;
        }

        // HÀM XỬ LÝ ĐỔI MÀU NÚT BẤM
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // Đổi màu
                btnRoutine.BackColor = Color.Teal;
                btnSanPham.BackColor = Color.Teal;
                btnThongKe.BackColor = Color.Teal;
                btnDanhGia.BackColor = Color.Teal;

                // Trả màu chữ về mặc định
                btnRoutine.ForeColor = SystemColors.ButtonFace;
                btnSanPham.ForeColor = SystemColors.ButtonFace;
                btnThongKe.ForeColor = SystemColors.ButtonFace;
                btnDanhGia.ForeColor = SystemColors.ButtonFace;

                // bật sáng nút đang chọn
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.LightCyan;

                // Đổi màu chữ của nút đang sáng 
                currentButton.ForeColor = Color.Black;
            }
        }

        // HÀM MỞ FORM CON VÀO TRONG PANEL
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Tắt form cũ đang mở
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            // Kích hoạt màu nút
            ActivateButton(btnSender);

            currentFormChild = childForm;

            // Biến Form thành 1 cái Control bình thường
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền của Form con
            childForm.Dock = DockStyle.Fill; // Fill vô panel

            // Add Form con vào panel và cho hiển thị
            pnlScreen.Controls.Add(childForm);
            pnlScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // GÁN SỰ KIỆN CLICK CHO TỪNG NÚT BÊN MENU
        private void btnRoutine_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormRountine(), sender);
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham(), sender);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormTraCuu(), sender);
        }

        // Sự kiện Click cho nút Đánh Giá: nhúng Form7 vào pnlScreen
        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhGia(), sender);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            btnRoutine.PerformClick();
        }

        // Sự kiện Tick của sidebar timer: tăng/giảm chiều rộng panel1
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Tốc độ thay đổi mỗi Tick (px)
            int step = 25; // có thể đặt tuỳ ý

            if (isSidebarExpanded)
            {
                // Nếu đang mở thì thu gọn lại
                if (panel1.Width - step > 65)
                {
                    panel1.Width -= step;
                }
                else
                {
                    // Đạt kích thước nhỏ nhất, dừng timer và cập nhật trạng thái
                    panel1.Width = 65;
                    sidebarTimer.Stop();
                    isSidebarExpanded = false;
                    // Ẩn text các nút khi thu gọn (chỉ giữ icon)
                    if (btnMenu != null) btnMenu.Text = string.Empty;
                    if (btnRoutine != null) btnRoutine.Text = string.Empty;
                    if (btnSanPham != null) btnSanPham.Text = string.Empty;
                    if (btnThongKe != null) btnThongKe.Text = string.Empty;
                    if (btnDanhGia != null) btnDanhGia.Text = string.Empty;
                    if (btnThoat != null) btnThoat.Text = string.Empty;

                }
            }
            else
            {
                // Nếu đang gọn thì mở ra
                if (panel1.Width + step < 200)
                {
                    panel1.Width += step;
                }
                else
                {
                    // Đạt kích thước lớn nhất, dừng timer và cập nhật trạng thái
                    panel1.Width = 200;
                    sidebarTimer.Stop();
                    isSidebarExpanded = true;
                    // Khôi phục text gốc khi mở rộng
                    if (btnMenu != null) btnMenu.Text = btnMenuText;
                    if (btnRoutine != null) btnRoutine.Text = btnRoutineText;
                    if (btnSanPham != null) btnSanPham.Text = btnSanPhamText;
                    if (btnThongKe != null) btnThongKe.Text = btnThongKeText;
                    if (btnDanhGia != null) btnDanhGia.Text = btnDanhGiaText;
                    if (btnThoat != null) btnThoat.Text = btnThoatText;
                }
            }
        }

        // Hàm công khai để gọi khi muốn toggle sidebar (bắt đầu animation)
        public void ToggleSidebar()
        {
            // Bắt đầu timer sẽ kích hoạt sidebarTimer_Tick liên tục
            sidebarTimer.Start();
        }

        // Sự kiện Click cho nút btnMenu: gọi ToggleSidebar để thu/gom sidebar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ToggleSidebar();
        }

        // Sự kiện Click cho Avatar (pbAccount): đảo ngược trạng thái hiển thị của pnlAccountMenu
        private void pbAccount_Click(object sender, EventArgs e)
        {

            if (pnlAccountMenu == null) return;

            // Đảo ngược trạng thái Visible
            pnlAccountMenu.Visible = !pnlAccountMenu.Visible;

            // Nếu vừa hiện lên thì đưa lên trước
            if (pnlAccountMenu.Visible)
            {
                pnlAccountMenu.BringToFront();
            }
        }

        // Hiệu ứng hover cho pbAccount: khi chuột vào thay đổi nền, khi chuột rời trả về trong suốt
        private void pbAccount_MouseEnter(object sender, EventArgs e)
        {
            if (pbAccount != null) pbAccount.BackColor = Color.LightSeaGreen;
        }

        private void pbAccount_MouseLeave(object sender, EventArgs e)
        {
            if (pbAccount != null) pbAccount.BackColor = Color.Transparent;
        }

        // Sự kiện Click cho nút Đăng xuất trong pnlAccountMenu
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại, mở Form2 dưới dạng dialog, sau đó đóng form này
            this.Hide();
            FormDangNhap frmLogin = new FormDangNhap();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng Skincare không?",
                                      "Xác nhận thoát",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // tắt hết form
                Application.Exit();
            }
        }
    }
}
