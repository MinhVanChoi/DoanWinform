namespace DoAn
{
    partial class UC_SanPhamBan
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ThemVaoGioHang = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.ptb_SanPham = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.btn_ThemVaoGioHang);
            this.panel5.Controls.Add(this.lbl_Price);
            this.panel5.Controls.Add(this.lbl_Gender);
            this.panel5.Controls.Add(this.lbl_Amount);
            this.panel5.Controls.Add(this.lbl_Discount);
            this.panel5.Controls.Add(this.lbl_Type);
            this.panel5.Controls.Add(this.lbl_Code);
            this.panel5.Controls.Add(this.lbl_Name);
            this.panel5.Controls.Add(this.ptb_SanPham);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 422);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btn_ThemVaoGioHang
            // 
            this.btn_ThemVaoGioHang.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemVaoGioHang.Location = new System.Drawing.Point(157, 374);
            this.btn_ThemVaoGioHang.Name = "btn_ThemVaoGioHang";
            this.btn_ThemVaoGioHang.Size = new System.Drawing.Size(170, 31);
            this.btn_ThemVaoGioHang.TabIndex = 2;
            this.btn_ThemVaoGioHang.Text = "Thêm vào giỏ hàng";
            this.btn_ThemVaoGioHang.UseVisualStyleBackColor = true;
            this.btn_ThemVaoGioHang.Click += new System.EventHandler(this.btn_ThemVaoGioHang_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Price.Location = new System.Drawing.Point(2, 374);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(149, 33);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "1000000 đ";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Gender.Location = new System.Drawing.Point(3, 297);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(51, 23);
            this.lbl_Gender.TabIndex = 1;
            this.lbl_Gender.Text = "Nam";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(127, 223);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(150, 23);
            this.lbl_Amount.TabIndex = 1;
            this.lbl_Amount.Text = "Số lượng còn lại:";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(3, 335);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(87, 23);
            this.lbl_Discount.TabIndex = 1;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(3, 257);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(53, 23);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.Location = new System.Drawing.Point(3, 223);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(59, 23);
            this.lbl_Code.TabIndex = 1;
            this.lbl_Code.Text = "CODE";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(3, 187);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(228, 23);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Giày thể thao nam Adidas";
            // 
            // ptb_SanPham
            // 
            this.ptb_SanPham.Location = new System.Drawing.Point(3, 3);
            this.ptb_SanPham.Name = "ptb_SanPham";
            this.ptb_SanPham.Size = new System.Drawing.Size(339, 181);
            this.ptb_SanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_SanPham.TabIndex = 0;
            this.ptb_SanPham.TabStop = false;
            // 
            // UC_SanPhamBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "UC_SanPhamBan";
            this.Size = new System.Drawing.Size(345, 425);
            this.Load += new System.EventHandler(this.UC_SanPhamBan_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ThemVaoGioHang;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox ptb_SanPham;
    }
}
