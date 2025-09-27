using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class UC_SanPhamBan : UserControl
    {
        private product _product;
        public UC_SanPhamBan()
        {
            InitializeComponent();
        }

        public UC_SanPhamBan(product product)
        {
            InitializeComponent();
            _product = product;
            DisplayProductInfo();
        }

        private void UC_SanPhamBan_Load(object sender, EventArgs e)
        {


        }

        private void DisplayProductInfo()
        {
            lbl_Name.Text = _product.name;
            lbl_Code.Text = _product.code;
            lbl_Price.Text = _product.price.ToString() + "đ";
            lbl_Gender.Text = _product.gender.ToString();
            lbl_Type.Text = _product.id_type;
            lbl_Discount.Text = _product.id_discount;
            lbl_Gender.Text = _product.gender == 1 ? "Nam" : "Nữ";
            lbl_Amount.Text = "Số lượng còn lại: " + _product.amount.ToString();
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectDirectory, "Images", _product.link);
            ptb_SanPham.Image = Image.FromFile(imagePath);


        }

        private void btn_ThemVaoGioHang_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is FTimKiem)
            {
                FTimKiem form = parentForm as FTimKiem;
                form.ThemVaoGioHang(_product);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
