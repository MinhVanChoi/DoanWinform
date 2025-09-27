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
using System.Xml.Linq;

namespace DoAn
{
    public partial class UC_NguoiDung : UserControl
    {
        private readonly UserService userService = new UserService();
        public UC_NguoiDung()
        {
            InitializeComponent();
        }

        private void UC_NguoiDung_Load(object sender, EventArgs e)
        {
            Refesh();
        }

        private void Refesh()
        {
            var listUser = userService.getAllUser();
            dtgv_NguoiDung.DataSource = listUser;
            cmb_Role.DataSource = new List<int> { 0, 1 };
            cmb_Status.DataSource = new List<int> { 0, 1 };
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Email.Clear();
            txt_Phone.Clear();
            txt_Address.Clear();
            cmb_Role.SelectedIndex = default;
            cmb_Status.SelectedIndex = default;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string usernameFromText = txt_Username.Text;
            string passwordFromText = txt_Password.Text;
            string fullnameFromText = txt_Fullname.Text;
            string emailFromText = txt_Email.Text;
            string phoneFromText = txt_Phone.Text;
            string addressFromText = txt_Address.Text;
            string roleFromText = cmb_Role.Text;
            string statusFromText = cmb_Status.Text;

            if (string.IsNullOrEmpty(usernameFromText) ||
                string.IsNullOrEmpty(passwordFromText) ||
                string.IsNullOrEmpty(fullnameFromText) ||
                string.IsNullOrEmpty(emailFromText) ||
                string.IsNullOrEmpty(phoneFromText) ||
                string.IsNullOrEmpty(addressFromText) ||
              !int.TryParse(roleFromText, out int role_) ||
              !int.TryParse(statusFromText, out int status_))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var newUser = new user_
            {
                username = usernameFromText,
                password = passwordFromText,
                fullname = fullnameFromText,
                email = emailFromText,
                phone = phoneFromText,
                address = addressFromText,
                role = role_,
                status = status_,
            };

            userService.InsertUser(newUser);

            MessageBox.Show("Thêm người dùng thành công!");
            Refesh();







        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string idFromText = txt_Id.Text;
            string usernameFromText = txt_Username.Text;
            string passwordFromText = txt_Password.Text;
            string fullnameFromText = txt_Fullname.Text;
            string emailFromText = txt_Email.Text;
            string phoneFromText = txt_Phone.Text;
            string addressFromText = txt_Address.Text;
            string roleFromText = cmb_Role.Text;
            string statusFromText = cmb_Status.Text;

            if (string.IsNullOrEmpty(usernameFromText) ||
                string.IsNullOrEmpty(passwordFromText) ||
                string.IsNullOrEmpty(fullnameFromText) ||
                string.IsNullOrEmpty(emailFromText) ||
                string.IsNullOrEmpty(phoneFromText) ||
                string.IsNullOrEmpty(addressFromText) ||
                !int.TryParse(roleFromText, out int role_) ||
                !int.TryParse(statusFromText, out int status_))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(idFromText, out int userId))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            var user = userService.findUser(userId);
            if (user != null)
            {
                user.username = usernameFromText;
                user.password = passwordFromText;
                user.fullname = fullnameFromText;
                user.email = emailFromText;
                user.phone = phoneFromText;
                user.address = addressFromText;
                user.role = role_;
                user.status = status_;

                userService.InsertUser(user);

                MessageBox.Show("Cập nhật thông tin người dùng thành công!");

                Refesh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng với ID đã nhập!");
            }

        }

        private void dtgv_NguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtgv_NguoiDung.Rows[e.RowIndex];

                txt_Id.Text = selectedRow.Cells["id"].Value.ToString();
                txt_Username.Text = selectedRow.Cells["username"].Value.ToString();
                txt_Password.Text = selectedRow.Cells["password"].Value.ToString();
                txt_Fullname.Text = selectedRow.Cells["fullname"].Value.ToString();
                txt_Email.Text = selectedRow.Cells["email"].Value.ToString();
                txt_Phone.Text = selectedRow.Cells["phone"].Value.ToString();
                txt_Address.Text = selectedRow.Cells["address"].Value.ToString();
                cmb_Role.Text = selectedRow.Cells["role"].Value.ToString();
                cmb_Status.Text = selectedRow.Cells["status"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string idFromText = txt_Id.Text;



            if (!int.TryParse(idFromText, out int userId))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                userService.DeleteUser(userId);

                Refesh();

                MessageBox.Show("Xóa người dùng thành công!");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}
