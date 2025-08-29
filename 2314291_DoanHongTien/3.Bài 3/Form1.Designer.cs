namespace _3.Bài_3
{
    partial class Form1
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
            this.frmbt1 = new System.Windows.Forms.Button();
            this.frm2 = new System.Windows.Forms.Button();
            this.frm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmbt1
            // 
            this.frmbt1.Location = new System.Drawing.Point(97, 53);
            this.frmbt1.Name = "frmbt1";
            this.frmbt1.Size = new System.Drawing.Size(75, 38);
            this.frmbt1.TabIndex = 2;
            this.frmbt1.Text = "Bài 1";
            this.frmbt1.UseVisualStyleBackColor = true;
            this.frmbt1.Click += new System.EventHandler(this.frmbt1_Click);
            // 
            // frm2
            // 
            this.frm2.Location = new System.Drawing.Point(261, 53);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(75, 38);
            this.frm2.TabIndex = 3;
            this.frm2.Text = "Bài 2";
            this.frm2.UseVisualStyleBackColor = true;
            this.frm2.Click += new System.EventHandler(this.frm2_Click);
            // 
            // frm3
            // 
            this.frm3.Location = new System.Drawing.Point(428, 53);
            this.frm3.Name = "frm3";
            this.frm3.Size = new System.Drawing.Size(75, 38);
            this.frm3.TabIndex = 4;
            this.frm3.Text = "Bài 3";
            this.frm3.UseVisualStyleBackColor = true;
            this.frm3.Click += new System.EventHandler(this.frm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 159);
            this.Controls.Add(this.frm3);
            this.Controls.Add(this.frm2);
            this.Controls.Add(this.frmbt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frmbt1;
        private System.Windows.Forms.Button frm2;
        private System.Windows.Forms.Button frm3;
    }
}

