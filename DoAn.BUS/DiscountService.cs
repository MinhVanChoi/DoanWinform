using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class DiscountService
    {
        public List<discount_product> getAllDiscount()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.discount_product.ToList();

        }

        public List<discount_product> getAllDiscount_No()
        {
            ShoeModel shoeModel = new ShoeModel();
            var allDiscounts = shoeModel.discount_product.ToList();
            var validDiscounts = allDiscounts.Where(d => d.idInfo != "Không có mã giảm giá").ToList();
            return validDiscounts;
        }

        public discount_product findProduct(string discountId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.discount_product.FirstOrDefault(p => p.idInfo == discountId);
        }


        public void InsertDiscount(discount_product discount)
        {
            ShoeModel shoeModel = new ShoeModel();
            shoeModel.discount_product.AddOrUpdate(discount);
            shoeModel.SaveChanges();
        }

        public void DeleteDiscount(String discountId)
        {
            ShoeModel shoeModel = new ShoeModel();
            discount_product discount = shoeModel.discount_product.FirstOrDefault(p => p.idInfo == discountId);
            shoeModel.discount_product.Remove(discount);
            shoeModel.SaveChanges();
        }

    }
}
