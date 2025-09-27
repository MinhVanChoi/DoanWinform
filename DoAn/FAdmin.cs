using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FAdmin : Form
    {
        UC_SanPham uc_sanpham = new UC_SanPham();
        UC_NguoiDung uc_nguoidung = new UC_NguoiDung();
        UC_TheLoai uc_theloai = new UC_TheLoai();
        UC_GiamGia uc_giamgia = new UC_GiamGia();
        UC_HoaDon uc_hoadon = new UC_HoaDon();

        public FAdmin()
        {
            InitializeComponent();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            uc_sanpham.Location = new Point(3, 15);
            uc_sanpham.Dock = DockStyle.None;
            uc_nguoidung.Location = new Point(3, 15);
            uc_nguoidung.Dock = DockStyle.None;
            uc_theloai.Location = new Point(3, 15);
            uc_theloai.Dock = DockStyle.None;
            uc_giamgia.Location = new Point(3, 15);
            uc_giamgia.Dock = DockStyle.None;
            uc_hoadon.Location = new Point(3, 15);
            uc_hoadon.Dock = DockStyle.None;
            pnl_Show.Controls.Clear();  


            pnl_Show.Controls.Add(uc_hoadon);
            pnl_Show.Controls.Add(uc_giamgia);
            pnl_Show.Controls.Add(uc_theloai);
            pnl_Show.Controls.Add(uc_nguoidung);
            pnl_Show.Controls.Add(uc_sanpham);
            uc_hoadon.Hide();
            uc_giamgia.Hide();
            uc_nguoidung.Hide();
            uc_theloai.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            uc_hoadon.Hide();
            uc_giamgia.Hide();
            uc_nguoidung.Hide();
            uc_theloai.Show();
            uc_sanpham.Hide();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            uc_hoadon.Hide();
            uc_giamgia.Hide();
            uc_nguoidung.Hide();
            uc_theloai.Hide();
            uc_sanpham.Show();

        }

        private void btn_GiamGia_Click(object sender, EventArgs e)
        {
            uc_hoadon.Hide();
            uc_giamgia.Show();
            uc_nguoidung.Hide();
            uc_theloai.Hide();
            uc_sanpham.Hide();

        }

        private void btn_NguoiDung_Click(object sender, EventArgs e)
        {
            uc_hoadon.Hide();
            uc_giamgia.Hide();
            uc_nguoidung.Show();
            uc_theloai.Hide();
            uc_sanpham.Hide();

        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            uc_hoadon.Show();
            uc_giamgia.Hide();
            uc_nguoidung.Hide();
            uc_theloai.Hide();
            uc_sanpham.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
