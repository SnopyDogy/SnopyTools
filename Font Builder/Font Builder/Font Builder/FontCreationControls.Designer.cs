namespace Font_Builder
{
    partial class FontCreationControls
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
            this.m_oFontComboBox = new System.Windows.Forms.ComboBox();
            this.m_oStyleComboBox = new System.Windows.Forms.ComboBox();
            this.m_oSizeComboBox = new System.Windows.Forms.ComboBox();
            this.m_oMinCharTextBox = new System.Windows.Forms.TextBox();
            this.m_oMaxCharTextBox = new System.Windows.Forms.TextBox();
            this.m_oCropCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oAACheckBox = new System.Windows.Forms.CheckBox();
            this.m_oColotButton = new System.Windows.Forms.Button();
            this.m_oGenFontTextureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinCharLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_oFontDataExportButton = new System.Windows.Forms.Button();
            this.m_oSampleLabel = new System.Windows.Forms.Label();
            this.m_oColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // m_oFontComboBox
            // 
            this.m_oFontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.m_oFontComboBox.FormattingEnabled = true;
            this.m_oFontComboBox.Location = new System.Drawing.Point(3, 26);
            this.m_oFontComboBox.Name = "m_oFontComboBox";
            this.m_oFontComboBox.Size = new System.Drawing.Size(121, 163);
            this.m_oFontComboBox.TabIndex = 0;
            // 
            // m_oStyleComboBox
            // 
            this.m_oStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.m_oStyleComboBox.FormattingEnabled = true;
            this.m_oStyleComboBox.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold, Italic"});
            this.m_oStyleComboBox.Location = new System.Drawing.Point(130, 26);
            this.m_oStyleComboBox.Name = "m_oStyleComboBox";
            this.m_oStyleComboBox.Size = new System.Drawing.Size(76, 163);
            this.m_oStyleComboBox.TabIndex = 1;
            this.m_oStyleComboBox.Text = "Regular";
            // 
            // m_oSizeComboBox
            // 
            this.m_oSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.m_oSizeComboBox.FormattingEnabled = true;
            this.m_oSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "23",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72",
            "100",
            "144"});
            this.m_oSizeComboBox.Location = new System.Drawing.Point(212, 25);
            this.m_oSizeComboBox.Name = "m_oSizeComboBox";
            this.m_oSizeComboBox.Size = new System.Drawing.Size(53, 163);
            this.m_oSizeComboBox.TabIndex = 2;
            this.m_oSizeComboBox.Text = "72";
            // 
            // m_oMinCharTextBox
            // 
            this.m_oMinCharTextBox.Location = new System.Drawing.Point(275, 82);
            this.m_oMinCharTextBox.Name = "m_oMinCharTextBox";
            this.m_oMinCharTextBox.Size = new System.Drawing.Size(41, 20);
            this.m_oMinCharTextBox.TabIndex = 3;
            this.m_oMinCharTextBox.Text = "0x20";
            // 
            // m_oMaxCharTextBox
            // 
            this.m_oMaxCharTextBox.Location = new System.Drawing.Point(275, 108);
            this.m_oMaxCharTextBox.Name = "m_oMaxCharTextBox";
            this.m_oMaxCharTextBox.Size = new System.Drawing.Size(41, 20);
            this.m_oMaxCharTextBox.TabIndex = 4;
            this.m_oMaxCharTextBox.Text = "0x7F";
            // 
            // m_oCropCheckBox
            // 
            this.m_oCropCheckBox.AutoSize = true;
            this.m_oCropCheckBox.Location = new System.Drawing.Point(275, 59);
            this.m_oCropCheckBox.Name = "m_oCropCheckBox";
            this.m_oCropCheckBox.Size = new System.Drawing.Size(78, 17);
            this.m_oCropCheckBox.TabIndex = 5;
            this.m_oCropCheckBox.Text = "Crop Chars";
            this.m_oCropCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oAACheckBox
            // 
            this.m_oAACheckBox.AutoSize = true;
            this.m_oAACheckBox.Location = new System.Drawing.Point(275, 36);
            this.m_oAACheckBox.Name = "m_oAACheckBox";
            this.m_oAACheckBox.Size = new System.Drawing.Size(77, 17);
            this.m_oAACheckBox.TabIndex = 6;
            this.m_oAACheckBox.Text = "Antialiased";
            this.m_oAACheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oColotButton
            // 
            this.m_oColotButton.BackColor = System.Drawing.Color.White;
            this.m_oColotButton.Location = new System.Drawing.Point(275, 7);
            this.m_oColotButton.Name = "m_oColotButton";
            this.m_oColotButton.Size = new System.Drawing.Size(26, 23);
            this.m_oColotButton.TabIndex = 7;
            this.m_oColotButton.UseVisualStyleBackColor = false;
            this.m_oColotButton.Click += new System.EventHandler(this.m_oColotButton_Click);
            // 
            // m_oGenFontTextureButton
            // 
            this.m_oGenFontTextureButton.Location = new System.Drawing.Point(275, 134);
            this.m_oGenFontTextureButton.Name = "m_oGenFontTextureButton";
            this.m_oGenFontTextureButton.Size = new System.Drawing.Size(105, 23);
            this.m_oGenFontTextureButton.TabIndex = 8;
            this.m_oGenFontTextureButton.Text = "Gen Font Texture";
            this.m_oGenFontTextureButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Font Colour";
            // 
            // MinCharLabel
            // 
            this.MinCharLabel.AutoSize = true;
            this.MinCharLabel.Location = new System.Drawing.Point(322, 85);
            this.MinCharLabel.Name = "MinCharLabel";
            this.MinCharLabel.Size = new System.Drawing.Size(46, 13);
            this.MinCharLabel.TabIndex = 13;
            this.MinCharLabel.Text = "MinChar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MacChar";
            // 
            // m_oFontDataExportButton
            // 
            this.m_oFontDataExportButton.Location = new System.Drawing.Point(275, 163);
            this.m_oFontDataExportButton.Name = "m_oFontDataExportButton";
            this.m_oFontDataExportButton.Size = new System.Drawing.Size(105, 23);
            this.m_oFontDataExportButton.TabIndex = 15;
            this.m_oFontDataExportButton.Text = "Exprot Font Data";
            this.m_oFontDataExportButton.UseVisualStyleBackColor = true;
            // 
            // m_oSampleLabel
            // 
            this.m_oSampleLabel.Location = new System.Drawing.Point(386, 7);
            this.m_oSampleLabel.Name = "m_oSampleLabel";
            this.m_oSampleLabel.Size = new System.Drawing.Size(296, 181);
            this.m_oSampleLabel.TabIndex = 16;
            this.m_oSampleLabel.Text = "The quick brown fox jumped over the LAZY camel";
            // 
            // m_oColorDialog
            // 
            this.m_oColorDialog.AnyColor = true;
            this.m_oColorDialog.Color = System.Drawing.Color.White;
            this.m_oColorDialog.FullOpen = true;
            // 
            // FontCreationControls
            // 
            this.AutoHidePortion = 0.3D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 194);
            this.Controls.Add(this.m_oSampleLabel);
            this.Controls.Add(this.m_oFontDataExportButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinCharLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_oGenFontTextureButton);
            this.Controls.Add(this.m_oColotButton);
            this.Controls.Add(this.m_oAACheckBox);
            this.Controls.Add(this.m_oCropCheckBox);
            this.Controls.Add(this.m_oMaxCharTextBox);
            this.Controls.Add(this.m_oMinCharTextBox);
            this.Controls.Add(this.m_oSizeComboBox);
            this.Controls.Add(this.m_oStyleComboBox);
            this.Controls.Add(this.m_oFontComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.MinimumSize = new System.Drawing.Size(710, 232);
            this.Name = "FontCreationControls";
            this.TabText = "Font Creation";
            this.Text = "Font Creation";
            this.ToolTipText = "Font Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_oFontComboBox;
        private System.Windows.Forms.ComboBox m_oStyleComboBox;
        private System.Windows.Forms.ComboBox m_oSizeComboBox;
        private System.Windows.Forms.TextBox m_oMinCharTextBox;
        private System.Windows.Forms.TextBox m_oMaxCharTextBox;
        private System.Windows.Forms.CheckBox m_oCropCheckBox;
        private System.Windows.Forms.CheckBox m_oAACheckBox;
        private System.Windows.Forms.Button m_oColotButton;
        private System.Windows.Forms.Button m_oGenFontTextureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MinCharLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button m_oFontDataExportButton;
        private System.Windows.Forms.Label m_oSampleLabel;
        private System.Windows.Forms.ColorDialog m_oColorDialog;
    }
}
