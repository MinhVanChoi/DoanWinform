using DoAn.BUS;
using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace DoAn
{
    public partial class UC_SanPham : UserControl
    {
        private readonly ProductService productService = new ProductService();
        private readonly TypeService typeService = new TypeService();
        private readonly DiscountService discountService = new DiscountService();
        private string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        public string pathImage;
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string codeFromText = txt_Code.Text;
            string nameFromText = txt_Name.Text;
            string priceFromText = txt_Price.Text;
            string genderFromText = cmb_Gender.Text;
            string amountFromText = cmb_Amount.Text;
            string statusFromText = cmb_Status.Text;
            string typeFromText = cmb_Type.Text;
            string discountFromText = cmb_Discount.Text;
            string link = null;
           
            if (string.IsNullOrEmpty(codeFromText) ||
                string.IsNullOrEmpty(nameFromText) ||
                string.IsNullOrEmpty(typeFromText) ||
                string.IsNullOrEmpty(discountFromText) ||
               !int.TryParse(priceFromText, out int price) ||
               !int.TryParse(genderFromText, out int gender) ||
               !int.TryParse(amountFromText, out int amount) ||
               !int.TryParse(statusFromText, out int status))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            if (!string.IsNullOrEmpty(pathImage) && File.Exists(pathImage))
            {
                string imageName = txt_Code.Text.Trim()+ Path.GetExtension(pathImage);
                string imagePath = Path.Combine(projectDirectory, "Images");

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                string imageDestinationPath = Path.Combine(imagePath, imageName);
                File.Copy(pathImage, imageDestinationPath, true);
                link = imageName;
                ptb_SanPham.Image = Image.FromFile(imageDestinationPath); 
            }
            else
            {
                ptb_SanPham.Image = null; 
            }




            var newProduct = new product
            {
                code = codeFromText,
                name = nameFromText,
                id_type = typeFromText,
                id_discount = discountFromText,
                price = price,
                gender = gender,
                amount = amount,
                status = status,
                create_date = DateTime.Now,
                link = link
            };


            if (productService.CheckDuplicateProduct(newProduct.code, newProduct.name))
            {
                MessageBox.Show("Sản phẩm đã tồn tại với mã code hoặc tên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productService.InsertProduct(newProduct);

            MessageBox.Show("Thêm sản phẩm thành công!");
            Refesh();
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {

            Refesh();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string idFromText = txt_Id.Text;
            string codeFromText = txt_Code.Text;
            string nameFromText = txt_Name.Text;
            string priceFromText = txt_Price.Text;
            string genderFromText = cmb_Gender.Text;
            string amountFromText = cmb_Amount.Text;
            string statusFromText = cmb_Status.Text;
            string typeFromText = cmb_Type.Text;
            string discountFromText = cmb_Discount.Text;
            string link = null;

            if (
                string.IsNullOrEmpty(codeFromText) ||
                string.IsNullOrEmpty(nameFromText) ||
                string.IsNullOrEmpty(typeFromText) ||
                string.IsNullOrEmpty(discountFromText) ||
                !int.TryParse(priceFromText, out int price) ||
                !int.TryParse(genderFromText, out int gender) ||
                !int.TryParse(amountFromText, out int amount) ||
                !int.TryParse(statusFromText, out int status))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return;
            }

            if (!int.TryParse(idFromText, out int productId))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            product product = productService.findProduct(productId);
            if (product != null)
            {
                if (File.Exists(pathImage))
                {
                    string imageName = txt_Code.Text.Trim() + Path.GetExtension(pathImage);
                    string imagePath = Path.Combine(projectDirectory, "Images");

                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }

                    string imageDestinationPath = Path.Combine(imagePath, imageName);
                    File.Copy(pathImage, imageDestinationPath, true);
                    link = imageName;
                    ptb_SanPham.Image = Image.FromFile(imageDestinationPath);
                }
                else
                {
                    ptb_SanPham.Image = null;
                    link = null;
                }

                product.code = codeFromText;
                product.name = nameFromText;
                product.id_type = typeFromText;
                product.id_discount = discountFromText;
                product.price = price;
                product.gender = gender;
                product.amount = amount;
                product.status = status;
                product.create_date = DateTime.Now;
                product.link = link;

                productService.InsertProduct(product);

                MessageBox.Show("Cập nhật sản phẩm thành công!");

                Refesh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm với ID đã nhập!");
            }
        }

        private void dtgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_SanPham.Rows[e.RowIndex];

                txt_Id.Text = row.Cells["id"].Value.ToString();
                txt_Code.Text = row.Cells["code"].Value.ToString();
                txt_Name.Text = row.Cells["name"].Value.ToString();
                txt_Price.Text = row.Cells["price"].Value.ToString();
                cmb_Amount.SelectedItem = row.Cells["amount"].Value;
                cmb_Status.SelectedItem = row.Cells["status"].Value;
                cmb_Gender.SelectedItem = row.Cells["gender"].Value;
                cmb_Type.SelectedItem = row.Cells["id_type"].Value.ToString();
                cmb_Discount.SelectedItem = row.Cells["id_discount"].Value.ToString();
                string imagePath = Path.Combine(projectDirectory, "Images", row.Cells["link"].Value.ToString());
                txt_link.Text = imagePath;
                ptb_SanPham.Image = Image.FromFile(imagePath);

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string idFromText = txt_Id.Text;

            if (!int.TryParse(idFromText, out int productId))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                productService.DeleteProduct(productId);

                Refesh();

                MessageBox.Show("Xóa sản phẩm thành công!");
            } 
        }

        private void btn_ThemAnh_Click(object sender, EventArgs e)
        {

            String imageLocation = "";
            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Chọn hình ảnh sản phẩm";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = fileOpen.FileName;
                    ptb_SanPham.Image = Image.FromFile(imageLocation);
                    pathImage = imageLocation;
                    txt_link.Text = pathImage;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi không thể upload ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }

        private void Refesh()
        {
            var listProduct = productService.getAllProduct();
            dtgv_SanPham.DataSource = listProduct;
            var listType = typeService.getAllTypes();
            var listDiscount = discountService.getAllDiscount();
            cmb_Status.DataSource = new List<int> { 0, 1 };
            cmb_Gender.DataSource = new List<int> { 0, 1 };
            cmb_Type.DataSource = listType.Select(t => t.idName).ToList();
            cmb_Discount.DataSource = listDiscount.Select(d => d.idInfo).ToList();
            var amounts = Enumerable.Range(1, 10).ToList();
            amounts.Sort();
            cmb_Amount.DataSource = amounts;

            txt_Id.Clear();
            txt_Code.Clear();
            txt_Name.Clear();
            txt_Price.Clear();
            cmb_Amount.SelectedIndex = default;
            cmb_Status.SelectedIndex = default;
            cmb_Discount.SelectedIndex = default;
            cmb_Gender.SelectedIndex = default;
            cmb_Type.SelectedIndex = default;
        }
    }
}
