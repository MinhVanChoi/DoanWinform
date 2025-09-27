using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class ProductService
    {
        public List<product> getAllProduct()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.products.ToList();

        }
        public List<product> getAllProductsStatus()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.products.Where(p => p.status == 1).ToList();
        }


        public product findProduct(int productId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.products.FirstOrDefault(p => p.id == productId);
        }

        public bool CheckDuplicateProduct(string code, string name)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                bool isCodeExist = shoeModel.products.Any(p => p.code == code);
                bool isNameExist = shoeModel.products.Any(p => p.name == name);
                return isCodeExist || isNameExist;
            }
        }


        public void InsertProduct(product product)
        {
            ShoeModel shoeModel = new ShoeModel();

            shoeModel.products.AddOrUpdate(product);
            shoeModel.SaveChanges();
        }

        public int TotalProduct(List<product> listProduct)
        {
            return listProduct.Count;
        }

        public void DeleteProduct(int productId)
        {
            ShoeModel shoeModel = new ShoeModel();
            product product = shoeModel.products.FirstOrDefault(p => p.id == productId);
            shoeModel.products.Remove(product);
            shoeModel.SaveChanges();
        }

        public List<product> SearchProductByName(string name)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.products.Where(p => p.name.Contains(name)).ToList();
            }
        }

        public List<product> SearchProductByType(string type)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.products.Where(p => p.id_type == type).ToList();
            }
        }

        public List<product> SearchProductWithDiscount()
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                var allDiscounts = shoeModel.discount_product.ToList();
                var validDiscountIds = allDiscounts
                    .Where(d => d.idInfo != "Không có mã giảm giá")
                    .Select(d => d.idInfo) 
                    .ToList();

                var productsWithValidDiscount = shoeModel.products
                    .Where(p => !string.IsNullOrEmpty(p.id_discount) && validDiscountIds.Contains(p.id_discount))
                    .ToList();

                return productsWithValidDiscount;
            }
        }


        public List<product> SearchProductByGender(int gender)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.products.Where(p => p.gender == gender).ToList();
            }
        }

        public List<product> SearchProductByPriceRange(decimal minPrice, decimal maxPrice)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.products
                                .Where(p => p.price >= minPrice && p.price <= maxPrice)
                                .ToList();
            }
        }

        public List<product> SearchProductByTypeAndPrice(string type, int minPrice, int maxPrice)
        {
            using (ShoeModel shoeModel = new ShoeModel())
            {
                return shoeModel.products
                    .Where(p => p.id_type == type && p.price >= minPrice && p.price <= maxPrice)
                    .ToList();
            }
        }

        public discount_product GetDiscountForProduct(string productDiscountId)
        {
            using (var shoeModel = new ShoeModel())
            {
                return shoeModel.discount_product
                    .FirstOrDefault(d => d.idInfo == productDiscountId);
            }
        }


    }
}
