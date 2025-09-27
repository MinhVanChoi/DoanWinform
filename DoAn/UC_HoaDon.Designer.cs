namespace DoAn
{
    partial class UC_HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.lbl_NguoiDung = new System.Windows.Forms.Label();
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_soluongNguoimua = new System.Windows.Forms.TextBox();
            this.txt_Doanhthu = new System.Windows.Forms.TextBox();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chitiethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btn_LamMoi);
            this.panel1.Controls.Add(this.dtgv_chitiethoadon);
            this.panel1.Controls.Add(this.lbl_NguoiDung);
            this.panel1.Controls.Add(this.dtgv_hoadon);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 386);
            this.panel1.TabIndex = 4;
            // 
            // dtgv_chitiethoadon
            // 
            this.dtgv_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chitiethoadon.Location = new System.Drawing.Point(436, 78);
            this.dtgv_chitiethoadon.Name = "dtgv_chitiethoadon";
            this.dtgv_chitiethoadon.RowHeadersWidth = 51;
            this.dtgv_chitiethoadon.RowTemplate.Height = 24;
            this.dtgv_chitiethoadon.Size = new System.Drawing.Size(492, 254);
            this.dtgv_chitiethoadon.TabIndex = 3;
            // 
            // lbl_NguoiDung
            // 
            this.lbl_NguoiDung.AutoSize = true;
            this.lbl_NguoiDung.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NguoiDung.Location = new System.Drawing.Point(3, 17);
            this.lbl_NguoiDung.Name = "lbl_NguoiDung";
            this.lbl_NguoiDung.Size = new System.Drawing.Size(225, 33);
            this.lbl_NguoiDung.TabIndex = 1;
            this.lbl_NguoiDung.Text = "Quản lý hóa đơn";
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Location = new System.Drawing.Point(21, 78);
            this.dtgv_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.RowHeadersWidth = 51;
            this.dtgv_hoadon.RowTemplate.Height = 24;
            this.dtgv_hoadon.Size = new System.Drawing.Size(400, 254);
            this.dtgv_hoadon.TabIndex = 0;
            this.dtgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hoadon_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btn_ThanhToan);
            this.panel2.Controls.Add(this.txt_Username);
            this.panel2.Controls.Add(this.txt_Status);
            this.panel2.Controls.Add(this.txt_soluongNguoimua);
            this.panel2.Controls.Add(this.txt_Doanhthu);
            this.panel2.Controls.Add(this.txt_totalPrice);
            this.panel2.Controls.Add(this.txt_Id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 280);
            this.panel2.TabIndex = 5;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ThanhToan.Location = new System.Drawing.Point(412, 202);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(163, 54);
            this.btn_ThanhToan.TabIndex = 5;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(143, 230);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(243, 31);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(146, 163);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(243, 31);
            this.txt_Status.TabIndex = 2;
            // 
            // txt_soluongNguoimua
            // 
            this.txt_soluongNguoimua.Enabled = false;
            this.txt_soluongNguoimua.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluongNguoimua.Location = new System.Drawing.Point(736, 79);
            this.txt_soluongNguoimua.Name = "txt_soluongNguoimua";
            this.txt_soluongNguoimua.Size = new System.Drawing.Size(160, 31);
            this.txt_soluongNguoimua.TabIndex = 2;
            // 
            // txt_Doanhthu
            // 
            this.txt_Doanhthu.Enabled = false;
            this.txt_Doanhthu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Doanhthu.Location = new System.Drawing.Point(653, 33);
            this.txt_Doanhthu.Name = "txt_Doanhthu";
            this.txt_Doanhthu.Size = new System.Drawing.Size(243, 31);
            this.txt_Doanhthu.TabIndex = 2;
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Enabled = false;
            this.txt_totalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPrice.Location = new System.Drawing.Point(146, 97);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.Size = new System.Drawing.Size(243, 31);
            this.txt_totalPrice.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(146, 38);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(243, 31);
            this.txt_Id.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng đã mua\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(805, 17);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(107, 33);
            this.btn_LamMoi.TabIndex = 6;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(940, 770);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chitiethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_NguoiDung;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private System.Windows.Forms.DataGridView dtgv_chitiethoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_totalPrice;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.TextBox txt_soluongNguoimua;
        private System.Windows.Forms.TextBox txt_Doanhthu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}
