namespace Products_Management.PL
{
    partial class FRM_PREVIEW
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
            this.imgView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgView
            // 
            this.imgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgView.Location = new System.Drawing.Point(0, 0);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(641, 571);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgView.TabIndex = 0;
            this.imgView.TabStop = false;
            // 
            // FRM_PREVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 571);
            this.Controls.Add(this.imgView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PREVIEW";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض صورة المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox imgView;
    }
}