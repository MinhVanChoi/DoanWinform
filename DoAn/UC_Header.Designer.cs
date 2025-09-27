namespace DoAn
{
    partial class UC_Header
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Header));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Thoat = new System.Windows.Forms.Label();
            this.lbl_TrangChu = new System.Windows.Forms.Label();
            this.lbl_Nam = new System.Windows.Forms.Label();
            this.lbl_Nu = new System.Windows.Forms.Label();
            this.lbl_GiamGia = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Thoat
            // 
            this.lbl_Thoat.AutoSize = true;
            this.lbl_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Thoat.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thoat.Location = new System.Drawing.Point(1089, 15);
            this.lbl_Thoat.Name = "lbl_Thoat";
            this.lbl_Thoat.Size = new System.Drawing.Size(53, 22);
            this.lbl_Thoat.TabIndex = 1;
            this.lbl_Thoat.Text = "Thoát";
            this.lbl_Thoat.Click += new System.EventHandler(this.lbl_DangKi_Click);
            // 
            // lbl_TrangChu
            // 
            this.lbl_TrangChu.AutoSize = true;
            this.lbl_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_TrangChu.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangChu.Location = new System.Drawing.Point(266, 15);
            this.lbl_TrangChu.Name = "lbl_TrangChu";
            this.lbl_TrangChu.Size = new System.Drawing.Size(80, 22);
            this.lbl_TrangChu.TabIndex = 1;
            this.lbl_TrangChu.Text = "Trang chủ";
            this.lbl_TrangChu.Click += new System.EventHandler(this.lbl_TrangChu_Click);
            // 
            // lbl_Nam
            // 
            this.lbl_Nam.AutoSize = true;
            this.lbl_Nam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nam.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nam.Location = new System.Drawing.Point(378, 15);
            this.lbl_Nam.Name = "lbl_Nam";
            this.lbl_Nam.Size = new System.Drawing.Size(45, 22);
            this.lbl_Nam.TabIndex = 1;
            this.lbl_Nam.Text = "Nam";
            this.lbl_Nam.Click += new System.EventHandler(this.lbl_Nam_Click);
            // 
            // lbl_Nu
            // 
            this.lbl_Nu.AutoSize = true;
            this.lbl_Nu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nu.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nu.Location = new System.Drawing.Point(455, 15);
            this.lbl_Nu.Name = "lbl_Nu";
            this.lbl_Nu.Size = new System.Drawing.Size(33, 22);
            this.lbl_Nu.TabIndex = 1;
            this.lbl_Nu.Text = "Nữ";
            this.lbl_Nu.Click += new System.EventHandler(this.lbl_Nu_Click);
            // 
            // lbl_GiamGia
            // 
            this.lbl_GiamGia.AutoSize = true;
            this.lbl_GiamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_GiamGia.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiamGia.Location = new System.Drawing.Point(523, 15);
            this.lbl_GiamGia.Name = "lbl_GiamGia";
            this.lbl_GiamGia.Size = new System.Drawing.Size(147, 22);
            this.lbl_GiamGia.TabIndex = 1;
            this.lbl_GiamGia.Text = "Đang giảm giá HOT";
            this.lbl_GiamGia.Click += new System.EventHandler(this.lbl_GiamGia_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_User.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(924, 16);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(44, 22);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "User";
            this.lbl_User.Click += new System.EventHandler(this.lbl_DangNhap_Click);
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin.Location = new System.Drawing.Point(695, 16);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(56, 21);
            this.lbl_Admin.TabIndex = 2;
            this.lbl_Admin.Text = "Admin";
            this.lbl_Admin.Click += new System.EventHandler(this.lbl_Admin_Click);
            // 
            // UC_Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_Admin);
            this.Controls.Add(this.lbl_Thoat);
            this.Controls.Add(this.lbl_GiamGia);
            this.Controls.Add(this.lbl_Nu);
            this.Controls.Add(this.lbl_Nam);
            this.Controls.Add(this.lbl_TrangChu);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_Header";
            this.Size = new System.Drawing.Size(1200, 50);
            this.Load += new System.EventHandler(this.UC_Header_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Thoat;
        private System.Windows.Forms.Label lbl_TrangChu;
        private System.Windows.Forms.Label lbl_Nam;
        private System.Windows.Forms.Label lbl_Nu;
        private System.Windows.Forms.Label lbl_GiamGia;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Admin;
    }
}
