namespace _3.Bài_1
{
    partial class FrmBai3
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.rdTinhtong = new System.Windows.Forms.RadioButton();
            this.btnKq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số a =";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(269, 58);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(168, 20);
            this.txtSoA.TabIndex = 4;
            this.txtSoA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số b =";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(269, 118);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(168, 20);
            this.txtSoB.TabIndex = 6;
            this.txtSoB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số n =";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(269, 178);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(168, 20);
            this.txtSoN.TabIndex = 8;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTinhtong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(186, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán ";
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTongN.Location = new System.Drawing.Point(39, 75);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(99, 23);
            this.rdTongN.TabIndex = 1;
            this.rdTongN.Text = "Tính tổng N";
            this.rdTongN.UseVisualStyleBackColor = true;
            // 
            // rdTinhtong
            // 
            this.rdTinhtong.AutoSize = true;
            this.rdTinhtong.Checked = true;
            this.rdTinhtong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTinhtong.Location = new System.Drawing.Point(39, 37);
            this.rdTinhtong.Name = "rdTinhtong";
            this.rdTinhtong.Size = new System.Drawing.Size(135, 23);
            this.rdTinhtong.TabIndex = 0;
            this.rdTinhtong.TabStop = true;
            this.rdTinhtong.Text = "Tính tổng của a, b";
            this.rdTinhtong.UseVisualStyleBackColor = true;
            // 
            // btnKq
            // 
            this.btnKq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKq.Location = new System.Drawing.Point(253, 348);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(107, 33);
            this.btnKq.TabIndex = 10;
            this.btnKq.Text = "Xem kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kết quả :";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.Location = new System.Drawing.Point(275, 404);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(17, 19);
            this.lblKq.TabIndex = 12;
            this.lblKq.Text = "0";
            // 
            // FrmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label1);
            this.Name = "FrmBai3";
            this.Text = "FrmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.RadioButton rdTinhtong;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKq;
    }
}