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
    public partial class UC_GiamGia : UserControl
    {
        private readonly DiscountService discountService = new DiscountService();
        public UC_GiamGia()
        {
            InitializeComponent();
        }

        private void UC_GiamGia_Load(object sender, EventArgs e)
        {
            Refesh();
            
        }

        private void Refesh()
        {
            var listDiscount = discountService.getAllDiscount();
            dtgv_GiamGia.DataSource = listDiscount;
            txt_Name.Clear();
            txt_Discount.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string discountFromText = txt_Discount.Text;

            if (string.IsNullOrEmpty(name) ||
              !int.TryParse(discountFromText, out int discount))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            var newDiscount = new discount_product
            {
                idInfo = name,
                discount = discount,
                create_date = DateTime.Now
            };

            discountService.InsertDiscount(newDiscount);

            MessageBox.Show("Thêm mã giảm giá thành công!");
            Refesh();

        }

        private void dtgv_GiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtgv_GiamGia.Rows[e.RowIndex];

                string selectedName = selectedRow.Cells["idInfo"].Value.ToString();
                string selectedDiscount = selectedRow.Cells["discount"].Value.ToString();

                txt_Name.Text = selectedName;
                txt_Discount.Text = selectedDiscount;
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string discountFromText = txt_Discount.Text;

            if (string.IsNullOrEmpty(name) ||
             !int.TryParse(discountFromText, out int discount))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            var newDiscount = new discount_product
            {
                idInfo = name,
                discount = discount,
                create_date = DateTime.Now
            };


            discountService.InsertDiscount(newDiscount);

            MessageBox.Show("Cập nhật mã giảm giá thành công!");

            Refesh();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng chọn một mã giảm giá để xóa!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mã giảm giá này?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                discountService.DeleteDiscount(name);

                Refesh();

                MessageBox.Show("Xóa mã giảm giá thành công!");
            }

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}
