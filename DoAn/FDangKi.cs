using DoAn.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FDangKi : Form
    {
        private readonly UserService userService = new UserService();

        private Form previousForm;
        public FDangKi()
        {
            InitializeComponent();
        }

        public FDangKi(Form form)
        {
            InitializeComponent();
            previousForm = form;

        }

        private void FDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            string username = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
            string fullname = txt_HovaTen.Text;
            string email = txt_Email.Text;
            string phone = txt_Sdt.Text;
            string diachi = txt_DiaChi.Text;
            string result = userService.Register(username, password, fullname, email, phone, diachi);

            if (result == "Đăng ký thành công!")
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                previousForm.Show();
            }
            else if (result == "Email đã tồn tại!")
            {
                MessageBox.Show("Email đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "Tên đăng nhập đã tồn tại!")
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
