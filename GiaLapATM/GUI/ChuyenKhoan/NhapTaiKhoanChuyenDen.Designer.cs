namespace GiaLapATM.GUI
{
    partial class NhapTaiKhoanChuyenDen
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
            this.txtNhapLieu = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn hãy nhập tài khoản chuyển đến của bạn:\r\n";
            // 
            // txtNhapLieu
            // 
            this.txtNhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLieu.Location = new System.Drawing.Point(133, 127);
            this.txtNhapLieu.Name = "txtNhapLieu";
            this.txtNhapLieu.Size = new System.Drawing.Size(490, 26);
            this.txtNhapLieu.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(552, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 52);
            this.button6.TabIndex = 20;
            this.button6.Text = "Trở lại";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(552, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 52);
            this.button5.TabIndex = 19;
            this.button5.Text = "Tiếp Tục";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // NhapTaiKhoanChuyenDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiaLapATM.Properties.Resources.biz_masthead_large;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtNhapLieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapTaiKhoanChuyenDen";
            this.Text = "NhapTaiKhoanChuyenDen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapLieu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}