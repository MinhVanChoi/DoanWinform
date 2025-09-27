using DoAn.BUS;
using DoAn.DAL.Entities;
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
    public partial class FDangNhap : Form
    {
        private readonly UserService userService = new UserService();

        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TenDangNhap.Text;
            string password = txt_MatKhau.Text;
            user_ user = userService.Login(username, password);
            if (user != null )
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FTrangChu ftrangchu = new FTrangChu(user);
                ftrangchu.ShowDialog();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKi fdangki = new FDangKi(this);
            fdangki.Show();
            this.Hide();
        }
    }
}
