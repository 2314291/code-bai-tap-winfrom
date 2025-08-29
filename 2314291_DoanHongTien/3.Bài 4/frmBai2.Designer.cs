namespace _3.Bài_4
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
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemTH = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập điểm lý thuyết:";
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Location = new System.Drawing.Point(316, 47);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(234, 20);
            this.txtDiemLT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Điểm Thực Hành:";
            // 
            // txtDiemTH
            // 
            this.txtDiemTH.Location = new System.Drawing.Point(337, 102);
            this.txtDiemTH.Name = "txtDiemTH";
            this.txtDiemTH.Size = new System.Drawing.Size(213, 20);
            this.txtDiemTH.TabIndex = 5;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.Location = new System.Drawing.Point(316, 158);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(122, 37);
            this.btnXepLoai.TabIndex = 6;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả sếp loại: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(337, 222);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(13, 19);
            this.lblkq.TabIndex = 8;
            this.lblkq.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtDiemTH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiemLT);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemTH;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkq;
    }
}