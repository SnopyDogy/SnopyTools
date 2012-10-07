namespace Font_Builder
{
    partial class FontTextureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_oFontPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_oFontPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_oFontPictureBox
            // 
            this.m_oFontPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.m_oFontPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_oFontPictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_oFontPictureBox.Name = "m_oFontPictureBox";
            this.m_oFontPictureBox.Size = new System.Drawing.Size(778, 514);
            this.m_oFontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_oFontPictureBox.TabIndex = 0;
            this.m_oFontPictureBox.TabStop = false;
            // 
            // FontTextureControl
            // 
            this.AutoHidePortion = 0.2D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 514);
            this.Controls.Add(this.m_oFontPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "FontTextureControl";
            this.TabText = "Font Texture";
            ((System.ComponentModel.ISupportInitialize)(this.m_oFontPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_oFontPictureBox;
    }
}
