namespace _3.Bài_1
{
    partial class FrmBai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSoluong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTienMat = new System.Windows.Forms.RadioButton();
            this.rdChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Hàng ";
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cbbTenHang.Location = new System.Drawing.Point(238, 31);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(200, 21);
            this.cbbTenHang.TabIndex = 4;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đơn giá: ";
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(238, 76);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(200, 20);
            this.txbDonGia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng: ";
            // 
            // txbSoluong
            // 
            this.txbSoluong.Location = new System.Drawing.Point(238, 122);
            this.txbSoluong.Name = "txbSoluong";
            this.txbSoluong.Size = new System.Drawing.Size(200, 20);
            this.txbSoluong.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTienMat);
            this.groupBox1.Controls.Add(this.rdChuyenKhoan);
            this.groupBox1.Location = new System.Drawing.Point(238, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán ";
            // 
            // rdTienMat
            // 
            this.rdTienMat.AutoSize = true;
            this.rdTienMat.Location = new System.Drawing.Point(7, 66);
            this.rdTienMat.Name = "rdTienMat";
            this.rdTienMat.Size = new System.Drawing.Size(66, 17);
            this.rdTienMat.TabIndex = 1;
            this.rdTienMat.Text = "Tiền mặt";
            this.rdTienMat.UseVisualStyleBackColor = true;
            // 
            // rdChuyenKhoan
            // 
            this.rdChuyenKhoan.AutoSize = true;
            this.rdChuyenKhoan.Checked = true;
            this.rdChuyenKhoan.Location = new System.Drawing.Point(7, 32);
            this.rdChuyenKhoan.Name = "rdChuyenKhoan";
            this.rdChuyenKhoan.Size = new System.Drawing.Size(142, 17);
            this.rdChuyenKhoan.TabIndex = 0;
            this.rdChuyenKhoan.TabStop = true;
            this.rdChuyenKhoan.Text = "Hình thức chuyển khoản";
            this.rdChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(265, 292);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(122, 36);
            this.btnTinhtien.TabIndex = 10;
            this.btnTinhtien.Text = "Tính Tiền ";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số tiền thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // FrmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbSoluong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenHang);
            this.Controls.Add(this.label1);
            this.Name = "FrmBai2";
            this.Text = "FrmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSoluong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTienMat;
        private System.Windows.Forms.RadioButton rdChuyenKhoan;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}