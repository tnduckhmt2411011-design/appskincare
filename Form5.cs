using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSkincare
{
    public partial class Form5 : Form
    {
        // Biến để nhớ xem Form nào đang mở
        private Form currentFormChild;
        // Biến để nhớ nút nào đang được bấm
        private Button currentButton;

        public Form5()
        {
            InitializeComponent();
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
            OpenChildForm(new Form1(), sender);
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(), sender);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form4(), sender);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnRoutine.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống Skincare không?",
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
