namespace GiaLapATM.GUI
{
    partial class DangNhapSoTheATM
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
            this.txtNhapLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhapLieu
            // 
            this.txtNhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLieu.Location = new System.Drawing.Point(423, 128);
            this.txtNhapLieu.Name = "txtNhapLieu";
            this.txtNhapLieu.Size = new System.Drawing.Size(227, 26);
            this.txtNhapLieu.TabIndex = 13;
            this.txtNhapLieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapLieu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vui lòng nhập số thẻ ATM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(81, 211);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(542, 37);
            this.lbl_alert.TabIndex = 14;
            this.lbl_alert.Text = "Số thẻ không tồn tại. Vui lòng thử lại!";
            this.lbl_alert.Visible = false;
            // 
            // DangNhapSoTheATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiaLapATM.Properties.Resources.biz_masthead_large;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.txtNhapLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhapSoTheATM";
            this.Text = "DangNhapSoTheATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_alert;
    }
}