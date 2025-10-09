namespace _2314291_DoanHongTien_De1
{
    partial class Form2
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            domainUpDown1 = new DomainUpDown();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/yyyy/mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(69, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Ngày xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 23);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Khách Hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 344);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "chi tiet bán hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(6, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 233);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên hàng";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lương";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "đơn giá";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Thành tiền";
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 303);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Tổng tiền";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 303);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "%Giảm giá";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(399, 300);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 303);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 9;
            label5.Text = "%";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(633, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 302);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 10;
            label6.Text = "Phải trả";
            // 
            // button1
            // 
            button1.Location = new Point(384, 470);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(488, 470);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 6;
            button2.Text = "Hủy hóa đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(603, 470);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 7;
            button3.Text = "chọn HĐ đã bán";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(713, 19);
            button4.Name = "button4";
            button4.Size = new Size(39, 23);
            button4.TabIndex = 8;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}