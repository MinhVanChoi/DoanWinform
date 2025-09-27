using DoAn.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class BillService
    {
        public List<bill> getAllBill()
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.bills.ToList();

        }

        public bill getBillWithId(int billId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.bills.FirstOrDefault(b => b.id == billId);
        }

        public List<bill_detail> GetBillDetailsByBillId(int billId)
        {
            ShoeModel shoeModel = new ShoeModel();
            return shoeModel.bill_detail
                .Where(bd => bd.id_bill == billId)
                .ToList();
        }

        public void CreateBillFromCartList(List<product> productList, List<int> quantities, int userId)
        {
            using (var shoeModel = new ShoeModel())
            {
                var newBill = new bill
                {
                    create_date = DateTime.Now,
                    id_user = userId,
                    status = 0,
                    total_price = 0
                };

                shoeModel.bills.Add(newBill);
                shoeModel.SaveChanges();

                int billId = newBill.id;
                int totalBillPrice = 0;

                for (int i = 0; i < productList.Count; i++)
                {
                    var product = productList[i];
                    int quantity = quantities[i];
                    int price = product.price ?? 0;
                    int totalPrice = price * quantity;

                    if (!string.IsNullOrEmpty(product.id_discount))
                    {
                        var discount = shoeModel.discount_product
                            .FirstOrDefault(d => d.idInfo == product.id_discount);

                        if (discount != null)
                        {
                            int discountAmount = discount.discount ?? 0;

                            if (discountAmount > 0)
                            {
                                int discountValue = (totalPrice * discountAmount) / 100;
                                totalPrice -= discountValue;
                            }
                        }
                    }

                    var billDetail = new bill_detail
                    {
                        id_bill = billId,
                        id_product = product.id,
                        amount = quantity,
                        sum_price = totalPrice
                    };

                    shoeModel.bill_detail.Add(billDetail);

                    if (product.amount >= quantity)
                    {
                        product.amount -= quantity;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Không đủ số lượng sản phẩm {product.name} trong kho.");
                    }

                    totalBillPrice += totalPrice;
                }

                newBill.total_price = totalBillPrice;
                shoeModel.SaveChanges();
            }
        }

        public void UpdateBillStatus(int billId)
        {
            using (var shoeModel = new ShoeModel())
            {
                var bill = shoeModel.bills.FirstOrDefault(b => b.id == billId);

                if (bill != null)
                {
                    bill.status = 1; // Đã thanh toán
                    shoeModel.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Hóa đơn không tồn tại.");
                }
            }
        }

        public int GetTotalRevenue()
        {
            ShoeModel shoeModel = new ShoeModel();
            var paidBills = shoeModel.bills.Where(b => b.status == 1).ToList();
            return paidBills.Sum(b => b.total_price ?? 0);
        }

        public int GetTotalCustomers()
        {
            ShoeModel shoeModel = new ShoeModel();
            var paidBills = shoeModel.bills.Where(b => b.status == 1).ToList();
            return paidBills.Select(b => b.id_user).Distinct().Count();
        }
    }
}
