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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DoAn
{
   

    public partial class FTimKiem : Form
    {
        public class CartItem
        {
            public product Product { get; set; }
            public int Quantity { get; set; }
            public int TotalPrice { get; set; }

            public CartItem(product product, int quantity)
            {
                Product = product;
                Quantity = quantity;
                TotalPrice = (product.price ?? 0) * quantity;
            }
        }

        private readonly ProductService productService = new ProductService();
        private readonly TypeService typeService = new TypeService();
        BillService billService = new BillService();
        List<CartItem> cart = new List<CartItem>();
        private string searchType;
        private string searchName;
        private int searchGender;
        private bool? hasDiscount;
        user_ userset = null;
        public FTimKiem()
        {
            InitializeComponent();


        }

        public FTimKiem(user_ userlogin, string name)
        {
            InitializeComponent();

            searchName = name;
            this.userset = userlogin;
        }


        public FTimKiem(user_ userlogin, int gender)
        {
            InitializeComponent();
            searchGender = gender;
            this.userset = userlogin;
            if (searchGender == 1)
            {
                lbl_Gender.Text = "Nam";
            }
            else if (searchGender == 0)
            {
                lbl_Gender.Text = "Nữ";
            }
            

        }

        public FTimKiem(user_ userlogin, bool discount)
        {
            InitializeComponent();
            hasDiscount = discount;
            this.userset = userlogin;
            lbl_Gender.Hide();

        }

        public void ThemVaoGioHang(product selectedProduct)
        {
            var existingItem = cart.FirstOrDefault(item => item.Product.id == selectedProduct.id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
                existingItem.TotalPrice = existingItem.Quantity * (existingItem.Product.price ?? 0);
            }
            else
            {
                cart.Add(new CartItem(selectedProduct, 1));
            }
            DisplayCartItems();
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int totalPrice = cart.Sum(item => item.TotalPrice);
            int totalDiscount = 0;

            foreach (var cartItem in cart)
            {
                if (!string.IsNullOrEmpty(cartItem.Product.id_discount))
                {
                    var discount = productService.GetDiscountForProduct(cartItem.Product.id_discount);
                    if (discount != null)
                    {
                        totalDiscount += (cartItem.TotalPrice * discount.discount ?? 0) / 100;
                    }
                }
            }

            int totalPriceAfterDiscount = totalPrice - totalDiscount;
            lbl_TongTien.Text ="Tổng tiền: " + string.Format("{0:#,0}", totalPriceAfterDiscount);
        }


        private void FTimKiem_Load(object sender, EventArgs e)
        {
            uC_Header1.SetUser(userset);
            List<product> listProduct = new List<product>();

            if (!string.IsNullOrEmpty(searchType))
            {
                listProduct = productService.SearchProductByType(searchType);
            }
            else if (!string.IsNullOrEmpty(searchName))
            {
                listProduct = productService.SearchProductByName(searchName);
            }
            else if (hasDiscount != null)
            {
                listProduct = productService.SearchProductWithDiscount();
            }
            else if (searchGender != null)
            {
                listProduct = productService.SearchProductByGender(searchGender);
            }
           
            else
            {
                listProduct = productService.getAllProductsStatus();
            }

            DisplayProducts(listProduct);

            var listType = typeService.getAllTypes();
            cmb_TheLoai.DataSource = listType.Select(t => t.idName).ToList();
            var listGiaTien = new List<int> { 500000, 1000000, 2000000, 3000000 };
            var listGiaTien_1 = new List<int> { 500000, 1000000, 2000000, 3000000 };

            cmb_GiaTienTu.DataSource = listGiaTien;
            cmb_GiaTienDen.DataSource = listGiaTien_1;


        }

        private void DisplayCartItems()
        {
            ltv_SanPham.View = View.Details;
            ltv_SanPham.Columns.Clear();
            ltv_SanPham.Columns.Add("Id", 50);
            ltv_SanPham.Columns.Add("Tên sản phẩm", 150);
            ltv_SanPham.Columns.Add("Giá", 100);
            ltv_SanPham.Columns.Add("Số lượng", 100);
            ltv_SanPham.Columns.Add("Giảm giá", 100);
            ltv_SanPham.Columns.Add("Tổng tiền", 100);

            ltv_SanPham.Items.Clear();

            foreach (var cartItem in cart)
            {
                var listViewItem = new ListViewItem(cartItem.Product.id.ToString());
                string formattedPrice = string.Format("{0:#,0}", cartItem.Product.price);
                string formattedTotalPrice = string.Format("{0:#,0}", cartItem.TotalPrice);

                int discountAmount = 0;
                if (!string.IsNullOrEmpty(cartItem.Product.id_discount))
                {
                    var discount = productService.GetDiscountForProduct(cartItem.Product.id_discount);
                    if (discount != null && discount.discount.HasValue && discount.discount.Value > 0)
                    {
                        discountAmount = (cartItem.TotalPrice * discount.discount.Value) / 100;
                    }
                }

                int totalPriceAfterDiscount = cartItem.TotalPrice - discountAmount;
                string formattedDiscount = string.Format("{0:#,0}", discountAmount);
                string formattedTotalPriceAfterDiscount = string.Format("{0:#,0}", totalPriceAfterDiscount);

                listViewItem.SubItems.Add(cartItem.Product.name);
                listViewItem.SubItems.Add(formattedPrice);
                listViewItem.SubItems.Add(cartItem.Quantity.ToString());
                listViewItem.SubItems.Add(formattedDiscount);
                listViewItem.SubItems.Add(formattedTotalPriceAfterDiscount);

                ltv_SanPham.Items.Add(listViewItem);
            }
        }


        private void DisplayProducts(List<product> listProduct)
        {
            pnl_Product.Controls.Clear();
            int xOffset = 10;
            int yOffset = 10;
            int marginX = 20;
            int marginY = 20;

            foreach (var product in listProduct)
            {
                UC_SanPhamBan ucSanPham = new UC_SanPhamBan(product);
                ucSanPham.Location = new Point(xOffset, yOffset);
                pnl_Product.Controls.Add(ucSanPham);

                xOffset += ucSanPham.Width + marginX;

                if (xOffset + ucSanPham.Width > pnl_Product.Width)
                {
                    xOffset = 10;
                    yOffset += ucSanPham.Height + marginY;
                }
            }

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string theloai = cmb_TheLoai.Text;
            string priceFrom = cmb_GiaTienTu.Text;
            string priceTo = cmb_GiaTienDen.Text;
            int.TryParse(priceFrom, out int priceF);
            int.TryParse(priceTo, out int priceT);
            var listProduct_1 = productService.SearchProductByTypeAndPrice(theloai, priceF, priceT);
            DisplayProducts(listProduct_1);



        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống. Vui lòng thêm sản phẩm vào giỏ hàng.");
                return;
            }

            int userId = userset.id;

            List<product> productList = new List<product>();
            List<int> quantities = new List<int>();

            foreach (var cartItem in cart)
            {
                productList.Add(cartItem.Product);
                quantities.Add(cartItem.Quantity);
            }

            billService.CreateBillFromCartList(productList, quantities, userId);

            MessageBox.Show("Hóa đơn của bạn đã được tạo thành công!");
            cart.Clear();
            DisplayCartItems();
        }

        private void ltv_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltv_SanPham.SelectedItems.Count > 0)
            {
                var selectedItem = ltv_SanPham.SelectedItems[0];
                string productName = selectedItem.SubItems[1].Text;
                txt_Name.Text = productName;
            }

        }

        private void btn_XoaGiay_Click(object sender, EventArgs e)
        {
            if (ltv_SanPham.SelectedItems.Count > 0)
            {
                var selectedItem = ltv_SanPham.SelectedItems[0];
                int productId = int.Parse(selectedItem.SubItems[0].Text);
                var cartItem = cart.FirstOrDefault(item => item.Product.id == productId);

                if (cartItem != null)
                {
                    if (cartItem.Quantity > 1)
                    {
                        cartItem.Quantity--;
                        cartItem.TotalPrice = cartItem.Quantity * (cartItem.Product.price ?? 0);
                    }
                    else
                    {
                        cart.Remove(cartItem);
                    }
                }

                DisplayCartItems();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
            UpdateTotalPrice();

        }
    }
}

