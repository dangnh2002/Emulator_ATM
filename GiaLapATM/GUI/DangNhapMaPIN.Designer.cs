namespace GiaLapATM.GUI
{
    partial class DangNhapMaPIN
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập số PIN";
            // 
            // txtNhapLieu
            // 
            this.txtNhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLieu.Location = new System.Drawing.Point(453, 171);
            this.txtNhapLieu.Name = "txtNhapLieu";
            this.txtNhapLieu.PasswordChar = '*';
            this.txtNhapLieu.Size = new System.Drawing.Size(227, 26);
            this.txtNhapLieu.TabIndex = 1;
            this.txtNhapLieu.TextChanged += new System.EventHandler(this.txtSoPIN_TextChanged);
            this.txtNhapLieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapLieu_KeyPress);
            this.txtNhapLieu.Leave += new System.EventHandler(this.txtSoPIN_Leave);
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
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(176, 247);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(408, 37);
            this.lbl_alert.TabIndex = 7;
            this.lbl_alert.Text = "Sai mã pin. Vui lòng thử lại!";
            this.lbl_alert.Visible = false;
            // 
            // DangNhapMaPIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiaLapATM.Properties.Resources.biz_masthead_large;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNhapLieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhapMaPIN";
            this.Text = "DangNhapMaPIN";
            this.Load += new System.EventHandler(this.DangNhapMaPIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapLieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_alert;
    }
}