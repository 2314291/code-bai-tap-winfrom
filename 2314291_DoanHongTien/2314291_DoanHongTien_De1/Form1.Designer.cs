namespace _2314291_DoanHongTien_De1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb1 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            mtSTD = new MaskedTextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            btnMacDinh = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            rbTheoSDT = new RadioButton();
            rbTheoTen = new RadioButton();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            MaKhachHang = new ColumnHeader();
            TenKhachHang = new ColumnHeader();
            STD = new ColumnHeader();
            DiaChi = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(12, 21);
            lb1.Name = "lb1";
            lb1.Size = new Size(92, 15);
            lb1.TabIndex = 0;
            lb1.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại ";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(125, 13);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(214, 23);
            txtMaKH.TabIndex = 3;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(125, 60);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(214, 23);
            txtTenKH.TabIndex = 4;
            // 
            // mtSTD
            // 
            mtSTD.Location = new Point(125, 103);
            mtSTD.Mask = "000000000";
            mtSTD.Name = "mtSTD";
            mtSTD.Size = new Size(214, 23);
            mtSTD.TabIndex = 5;
            mtSTD.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 21);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ giao hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(470, 49);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ScrollBars = ScrollBars.Vertical;
            txtDiaChi.Size = new Size(326, 82);
            txtDiaChi.TabIndex = 7;
            // 
            // btnMacDinh
            // 
            btnMacDinh.Location = new Point(258, 150);
            btnMacDinh.Name = "btnMacDinh";
            btnMacDinh.Size = new Size(81, 43);
            btnMacDinh.TabIndex = 8;
            btnMacDinh.Text = "Mặc Định";
            btnMacDinh.UseVisualStyleBackColor = true;
            btnMacDinh.Click += btnMacDinh_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(461, 155);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(87, 43);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(rbTheoSDT);
            groupBox1.Controls.Add(rbTheoTen);
            groupBox1.Location = new Point(307, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 111);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(154, 72);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(87, 33);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(245, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(220, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // rbTheoSDT
            // 
            rbTheoSDT.AutoSize = true;
            rbTheoSDT.Location = new Point(138, 35);
            rbTheoSDT.Name = "rbTheoSDT";
            rbTheoSDT.Size = new Size(73, 19);
            rbTheoSDT.TabIndex = 1;
            rbTheoSDT.TabStop = true;
            rbTheoSDT.Text = "Theo SDT";
            rbTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rbTheoTen
            // 
            rbTheoTen.AutoSize = true;
            rbTheoTen.Location = new Point(33, 35);
            rbTheoTen.Name = "rbTheoTen";
            rbTheoTen.Size = new Size(72, 19);
            rbTheoTen.TabIndex = 0;
            rbTheoTen.TabStop = true;
            rbTheoTen.Text = "Theo Tên";
            rbTheoTen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 222);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Khách Hàng";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { MaKhachHang, TenKhachHang, STD, DiaChi });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(805, 194);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MaKhachHang
            // 
            MaKhachHang.Text = "Mã khách hàng";
            MaKhachHang.Width = 200;
            // 
            // TenKhachHang
            // 
            TenKhachHang.Text = "Tên khách hàng";
            TenKhachHang.Width = 200;
            // 
            // STD
            // 
            STD.Text = "SDT";
            STD.Width = 200;
            // 
            // DiaChi
            // 
            DiaChi.Text = "Địa chỉ giao hàng";
            DiaChi.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 575);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuu);
            Controls.Add(btnMacDinh);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(mtSTD);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Label label1;
        private Label label2;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private MaskedTextBox mtSTD;
        private Label label3;
        private TextBox txtDiaChi;
        private Button btnMacDinh;
        private Button btnLuu;
        private GroupBox groupBox1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private RadioButton rbTheoSDT;
        private RadioButton rbTheoTen;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader MaKhachHang;
        private ColumnHeader TenKhachHang;
        private ColumnHeader STD;
        private ColumnHeader DiaChi;
    }
}
