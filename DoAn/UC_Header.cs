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
    public partial class UC_Header : UserControl
    {
        private Form previousForm;
        user_ userset=null;

        public UC_Header()
        {
            InitializeComponent();
        }



        private void lbl_Nam_Click(object sender, EventArgs e)
        {
            FTimKiem ftimkiemNam = new FTimKiem(userset,1);
            ftimkiemNam.Show();
            this.FindForm().Close();
            

        }

        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DangKi_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
            
        }

        private void UC_Header_Load(object sender, EventArgs e)
        {

        }

        public void SetUser(user_ userlogin)
        {
            user_ user = new user_();
            user = userlogin;
            userset = userlogin;
            lbl_User.Text = user.fullname;
            if (user.role != 1)
            {
                lbl_Admin.Hide();
            }
        }

        private void lbl_Admin_Click(object sender, EventArgs e)
        {
            FAdmin fAdmin = new FAdmin();
            fAdmin.ShowDialog();
        }

        private void lbl_Nu_Click(object sender, EventArgs e)
        {
            FTimKiem ftimkiemNam = new FTimKiem(userset,0);
            ftimkiemNam.Show();
            this.FindForm().Close();

        }

        private void lbl_GiamGia_Click(object sender, EventArgs e)
        {
            FTimKiem ftimkiemNam = new FTimKiem(userset,true);
            ftimkiemNam.Show();
            this.FindForm().Close();
        }

        private void lbl_TrangChu_Click(object sender, EventArgs e)
        {
            FTrangChu fTrangChu = new FTrangChu(userset);
            fTrangChu.Show();
            this.FindForm().Close();
        }
    }
}
