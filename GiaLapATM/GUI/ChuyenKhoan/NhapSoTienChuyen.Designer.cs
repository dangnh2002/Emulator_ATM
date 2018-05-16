namespace GiaLapATM.GUI
{
    partial class NhapSoTienChuyen
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNhapLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.lbl_alert2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(552, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 52);
            this.button6.TabIndex = 25;
            this.button6.Text = "Trở lại";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(552, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 52);
            this.button5.TabIndex = 24;
            this.button5.Text = "Tiếp tục";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtNhapLieu
            // 
            this.txtNhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLieu.Location = new System.Drawing.Point(196, 125);
            this.txtNhapLieu.Name = "txtNhapLieu";
            this.txtNhapLieu.Size = new System.Drawing.Size(351, 26);
            this.txtNhapLieu.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bạn hãy nhập số tiền:";
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(92, 193);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(580, 37);
            this.lbl_alert.TabIndex = 26;
            this.lbl_alert.Text = "Số tiền còn lại phải lớn hơn 50,000VNĐ";
            this.lbl_alert.Visible = false;
            // 
            // lbl_alert2
            // 
            this.lbl_alert2.AutoSize = true;
            this.lbl_alert2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert2.Location = new System.Drawing.Point(71, 243);
            this.lbl_alert2.Name = "lbl_alert2";
            this.lbl_alert2.Size = new System.Drawing.Size(616, 37);
            this.lbl_alert2.TabIndex = 27;
            this.lbl_alert2.Text = "Số tiền giao dịch phải lớn hơn 20,000VNĐ";
            this.lbl_alert2.Visible = false;
            // 
            // NhapSoTienChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiaLapATM.Properties.Resources.biz_masthead_large;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.lbl_alert2);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtNhapLieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapSoTienChuyen";
            this.Text = "NhapSoTienChuyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNhapLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.Label lbl_alert2;
    }
}