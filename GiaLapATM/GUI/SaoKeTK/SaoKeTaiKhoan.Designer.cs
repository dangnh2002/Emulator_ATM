namespace GiaLapATM.GUI
{
    partial class SaoKeTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_sodu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_saoke = new System.Windows.Forms.DataGridView();
            this.logDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_saoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(552, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 52);
            this.button5.TabIndex = 19;
            this.button5.Text = "Không";
            this.button5.UseVisualStyleBackColor = false;
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
            this.button1.TabIndex = 18;
            this.button1.Text = "Có";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_sodu
            // 
            this.lbl_sodu.AutoSize = true;
            this.lbl_sodu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sodu.Location = new System.Drawing.Point(265, 125);
            this.lbl_sodu.Name = "lbl_sodu";
            this.lbl_sodu.Size = new System.Drawing.Size(98, 25);
            this.lbl_sodu.TabIndex = 16;
            this.lbl_sodu.Text = "123 VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bạn có muốn thực hiện giao dịch khác không?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số dư:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sao kê tài khoản";
            // 
            // Grid_saoke
            // 
            this.Grid_saoke.AllowUserToAddRows = false;
            this.Grid_saoke.AllowUserToDeleteRows = false;
            this.Grid_saoke.AutoGenerateColumns = false;
            this.Grid_saoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_saoke.DataSource = this.logDTOBindingSource;
            this.Grid_saoke.Location = new System.Drawing.Point(12, 153);
            this.Grid_saoke.Name = "Grid_saoke";
            this.Grid_saoke.ReadOnly = true;
            this.Grid_saoke.Size = new System.Drawing.Size(519, 196);
            this.Grid_saoke.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(552, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "In hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SaoKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GiaLapATM.Properties.Resources.biz_masthead_large;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Grid_saoke);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_sodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaoKeTaiKhoan";
            this.Text = "SaoKeTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_saoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_sodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_saoke;
        private System.Windows.Forms.BindingSource logDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}