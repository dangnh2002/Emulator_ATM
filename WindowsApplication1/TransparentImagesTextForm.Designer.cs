namespace WindowsApplication1
{
    partial class TransparentImagesTextForm
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
            this.broculosDrawing1 = new BroculosDrawing();
            this.SuspendLayout();
            // 
            // broculosDrawing1
            // 
            this.broculosDrawing1.Location = new System.Drawing.Point(12, 12);
            this.broculosDrawing1.Name = "broculosDrawing1";
            this.broculosDrawing1.Size = new System.Drawing.Size(207, 205);
            this.broculosDrawing1.TabIndex = 0;
            // 
            // TransparentImagesTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.broculosDrawing1);
            this.Name = "TransparentImagesTextForm";
            this.Text = "Transparent Images and Text";
            this.ResumeLayout(false);

        }

        #endregion

        private BroculosDrawing broculosDrawing1;

    }
}