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
    public partial class UC_HoaDon : UserControl
    {
        private readonly BillService billService = new BillService();
        private readonly UserService userService = new UserService();
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            Refesh();

        }

        private void Refesh()
        {
            var listHoadon = billService.getAllBill();
            dtgv_hoadon.DataSource = listHoadon;
            UpdateDoanhthuVaSoluongdamua();
            txt_Id.Clear();
            txt_Status.Clear();
            txt_Username?.Clear();
            txt_totalPrice?.Clear();
        }

        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int billId = (int)dtgv_hoadon.Rows[e.RowIndex].Cells["id"].Value;
                var selectedBill = billService.getBillWithId(billId);

                if (selectedBill != null)
                {
                    txt_Id.Text = selectedBill.id.ToString();
                    txt_totalPrice.Text = string.Format("{0:#,0}", selectedBill.total_price?.ToString());
                    txt_Status.Text = selectedBill.status.ToString();
                    txt_Username.Text = userService.GetUserNameById(selectedBill.id_user ?? 0);
                    var billDetails = billService.GetBillDetailsByBillId(billId);
                    dtgv_chitiethoadon.DataSource = billDetails;
                }
            }

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            try
            {
                billService.UpdateBillStatus(id);
                MessageBox.Show("Thanh toán thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
            var listHoadon = billService.getAllBill();
            dtgv_hoadon.DataSource = listHoadon;
            Refesh();           
        }

        private void UpdateDoanhthuVaSoluongdamua()
        {
            int totalRevenue = billService.GetTotalRevenue();
            int totalCustomers = billService.GetTotalCustomers();

            txt_Doanhthu.Text = string.Format("{0:#,0}", totalRevenue);
            txt_soluongNguoimua.Text = totalCustomers.ToString();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Refesh();
        }
    }
}
