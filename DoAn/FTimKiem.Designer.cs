namespace DoAn
{
    partial class FTimKiem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Product = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uC_SanPhamBan1 = new DoAn.UC_SanPhamBan();
            this.uC_Header1 = new DoAn.UC_Header();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cmb_TheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_GiaTienTu = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_GiaTienDen = new System.Windows.Forms.ComboBox();
            this.ltv_SanPham = new System.Windows.Forms.ListView();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaGiay = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Product.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lbl_Gender);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 128);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.cmb_GiaTienDen);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_GiaTienTu);
            this.panel2.Controls.Add(this.cmb_TheLoai);
            this.panel2.Location = new System.Drawing.Point(13, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 345);
            this.panel2.TabIndex = 1;
            // 
            // pnl_Product
            // 
            this.pnl_Product.AutoScroll = true;
            this.pnl_Product.Controls.Add(this.uC_SanPhamBan1);
            this.pnl_Product.Location = new System.Drawing.Point(273, 285);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(897, 556);
            this.pnl_Product.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lbl_TongTien);
            this.panel4.Controls.Add(this.txt_Name);
            this.panel4.Controls.Add(this.btn_XoaGiay);
            this.panel4.Controls.Add(this.btn_TaoHoaDon);
            this.panel4.Controls.Add(this.ltv_SanPham);
            this.panel4.Location = new System.Drawing.Point(273, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 204);
            this.panel4.TabIndex = 4;
            // 
            // uC_SanPhamBan1
            // 
            this.uC_SanPhamBan1.Location = new System.Drawing.Point(38, 18);
            this.uC_SanPhamBan1.Name = "uC_SanPhamBan1";
            this.uC_SanPhamBan1.Size = new System.Drawing.Size(345, 425);
            this.uC_SanPhamBan1.TabIndex = 0;
            // 
            // uC_Header1
            // 
            this.uC_Header1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_Header1.Location = new System.Drawing.Point(-9, 0);
            this.uC_Header1.Name = "uC_Header1";
            this.uC_Header1.Size = new System.Drawing.Size(1200, 50);
            this.uC_Header1.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(144, 285);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 37);
            this.btn_TimKiem.TabIndex = 0;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cmb_TheLoai
            // 
            this.cmb_TheLoai.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TheLoai.FormattingEnabled = true;
            this.cmb_TheLoai.Location = new System.Drawing.Point(3, 46);
            this.cmb_TheLoai.Name = "cmb_TheLoai";
            this.cmb_TheLoai.Size = new System.Drawing.Size(249, 23);
            this.cmb_TheLoai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thể loại giày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(-1, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mức giá";
            // 
            // cmb_GiaTienTu
            // 
            this.cmb_GiaTienTu.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GiaTienTu.FormattingEnabled = true;
            this.cmb_GiaTienTu.Location = new System.Drawing.Point(3, 170);
            this.cmb_GiaTienTu.Name = "cmb_GiaTienTu";
            this.cmb_GiaTienTu.Size = new System.Drawing.Size(249, 23);
            this.cmb_GiaTienTu.TabIndex = 0;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Gender.Location = new System.Drawing.Point(0, 49);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(85, 40);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Nam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến:";
            // 
            // cmb_GiaTienDen
            // 
            this.cmb_GiaTienDen.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GiaTienDen.FormattingEnabled = true;
            this.cmb_GiaTienDen.Location = new System.Drawing.Point(3, 233);
            this.cmb_GiaTienDen.Name = "cmb_GiaTienDen";
            this.cmb_GiaTienDen.Size = new System.Drawing.Size(249, 23);
            this.cmb_GiaTienDen.TabIndex = 2;
            // 
            // ltv_SanPham
            // 
            this.ltv_SanPham.HideSelection = false;
            this.ltv_SanPham.Location = new System.Drawing.Point(3, 3);
            this.ltv_SanPham.Name = "ltv_SanPham";
            this.ltv_SanPham.Size = new System.Drawing.Size(552, 198);
            this.ltv_SanPham.TabIndex = 0;
            this.ltv_SanPham.UseCompatibleStateImageBehavior = false;
            this.ltv_SanPham.SelectedIndexChanged += new System.EventHandler(this.ltv_SanPham_SelectedIndexChanged);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(757, 148);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(121, 40);
            this.btn_TaoHoaDon.TabIndex = 1;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // btn_XoaGiay
            // 
            this.btn_XoaGiay.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaGiay.Location = new System.Drawing.Point(757, 102);
            this.btn_XoaGiay.Name = "btn_XoaGiay";
            this.btn_XoaGiay.Size = new System.Drawing.Size(121, 40);
            this.btn_XoaGiay.TabIndex = 2;
            this.btn_XoaGiay.Text = "Xóa giày";
            this.btn_XoaGiay.UseVisualStyleBackColor = true;
            this.btn_XoaGiay.Click += new System.EventHandler(this.btn_XoaGiay_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(561, 33);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(333, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TongTien.Location = new System.Drawing.Point(558, 73);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(95, 23);
            this.lbl_TongTien.TabIndex = 4;
            this.lbl_TongTien.Text = "Tổng tiền:";
            // 
            // FTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Product);
            this.Controls.Add(this.uC_Header1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTimKiem";
            this.Load += new System.EventHandler(this.FTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Product.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Product;
        private System.Windows.Forms.Panel panel4;
        private UC_SanPhamBan uC_SanPhamBan1;
        private UC_Header uC_Header1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_GiaTienTu;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_GiaTienDen;
        private System.Windows.Forms.ListView ltv_SanPham;
        private System.Windows.Forms.Button btn_XoaGiay;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_TongTien;
    }
}