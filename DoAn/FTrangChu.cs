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
    public partial class FTrangChu : Form
    {
        private user_ user;
        public FTrangChu()
        {
            InitializeComponent();
        }

        public FTrangChu(user_ userlogin)
        {
            InitializeComponent();
            this.user = userlogin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uC_Header1_Load(object sender, EventArgs e)
        {

        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            uC_Header1.SetUser(user);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
