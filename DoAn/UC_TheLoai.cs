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
    public partial class UC_TheLoai : UserControl
    {
        private readonly TypeService typeService = new TypeService();
        public UC_TheLoai()
        {
            InitializeComponent();
        }

        private void UC_TheLoai_Load(object sender, EventArgs e)
        {
            Refesh();

        }

        private void Refesh()
        {
            var listType = typeService.getAllTypes();
            dtgv_TheLoai.DataSource = listType;

            txt_Name.Clear();
            txt_Sizefrom.Clear();
            txt_Sizeto.Clear();
        }

        private void dtgv_TheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dtgv_TheLoai.Rows[e.RowIndex];

                string selectedName = selectedRow.Cells["idName"].Value.ToString();
                string selectedSizeFrom = selectedRow.Cells["size_from"].Value.ToString();
                string selectedSizeTo = selectedRow.Cells["size_to"].Value.ToString();

                txt_Name.Text = selectedName;
                txt_Sizefrom.Text = selectedSizeFrom;
                txt_Sizeto.Text = selectedSizeTo;
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string sizeFromText = txt_Sizefrom.Text;
            string sizeToText = txt_Sizeto.Text;

            if (string.IsNullOrEmpty(name) ||
                !int.TryParse(sizeFromText, out int sizeFrom) ||
                !int.TryParse(sizeToText, out int sizeTo))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kích cỡ hợp lệ!");
                return;
            }

            var newType = new type
            {
                idName = name,
                size_from = sizeFrom,
                size_to = sizeTo
            };

            typeService.InsertType(newType);

            MessageBox.Show("Thêm loại giày thành công!");
            Refesh();



        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            string sizeFromText = txt_Sizefrom.Text;
            string sizeToText = txt_Sizeto.Text;

            if (string.IsNullOrEmpty(name) ||
                !int.TryParse(sizeFromText, out int sizeFrom) ||
                !int.TryParse(sizeToText, out int sizeTo))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kích cỡ hợp lệ!");
                return;
            }

            var typeToUpdate = new type
            {
                idName = name,
                size_from = sizeFrom,
                size_to = sizeTo
            };

            typeService.InsertType(typeToUpdate);

            MessageBox.Show("Cập nhật loại giày thành công!");

            Refesh();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng chọn một loại giày để xóa!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại giày này?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                typeService.DeleteProduct(name);

                Refesh();

                MessageBox.Show("Xóa loại giày thành công!");
            }

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}
