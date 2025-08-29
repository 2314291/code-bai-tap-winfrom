namespace _3.Bài_3
{
    partial class frmBai2
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
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhN = new System.Windows.Forms.RadioButton();
            this.rdTong = new System.Windows.Forms.RadioButton();
            this.btnTinhKq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập một số nguyên dương N: ";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(420, 45);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(247, 20);
            this.txtNhapN.TabIndex = 2;
            this.txtNhapN.TextChanged += new System.EventHandler(this.txtNhapN_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhN);
            this.groupBox1.Controls.Add(this.rdTong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdTinhN
            // 
            this.rdTinhN.AutoSize = true;
            this.rdTinhN.Location = new System.Drawing.Point(38, 100);
            this.rdTinhN.Name = "rdTinhN";
            this.rdTinhN.Size = new System.Drawing.Size(161, 24);
            this.rdTinhN.TabIndex = 1;
            this.rdTinhN.Text = "Tính N giai thừa (N)";
            this.rdTinhN.UseVisualStyleBackColor = true;
            // 
            // rdTong
            // 
            this.rdTong.AutoSize = true;
            this.rdTong.Checked = true;
            this.rdTong.Location = new System.Drawing.Point(38, 44);
            this.rdTong.Name = "rdTong";
            this.rdTong.Size = new System.Drawing.Size(197, 24);
            this.rdTong.TabIndex = 0;
            this.rdTong.TabStop = true;
            this.rdTong.Text = "Tính Tổng 1+ 2 + . . . + N";
            this.rdTong.UseVisualStyleBackColor = true;
            // 
            // btnTinhKq
            // 
            this.btnTinhKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhKq.Location = new System.Drawing.Point(420, 296);
            this.btnTinhKq.Name = "btnTinhKq";
            this.btnTinhKq.Size = new System.Drawing.Size(114, 47);
            this.btnTinhKq.TabIndex = 4;
            this.btnTinhKq.Text = "Xem kết quả";
            this.btnTinhKq.UseVisualStyleBackColor = true;
            this.btnTinhKq.Click += new System.EventHandler(this.btnTinhKq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết quả: ";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.Location = new System.Drawing.Point(494, 379);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(13, 20);
            this.lblKq.TabIndex = 6;
            this.lblKq.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinhKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhN;
        private System.Windows.Forms.RadioButton rdTong;
        private System.Windows.Forms.Button btnTinhKq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKq;
    }
}