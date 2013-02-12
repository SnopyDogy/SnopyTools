namespace Font_Builder
{
    partial class Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BitmapTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_oColourCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oColourTransparentRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oColorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_oPadBitmatToPowOf2CheckBox = new System.Windows.Forms.CheckBox();
            this.m_oWidthInPixelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_oWidthInCharsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_oPaddingBetweenCharsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_oWidthInPixelsRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oWidthInCharsRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DataFileTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DirectXCoordSystemRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenGLCoordSystemRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oColorDialog = new System.Windows.Forms.ColorDialog();
            this.m_oCancelButton = new System.Windows.Forms.Button();
            this.m_oApplyButton = new System.Windows.Forms.Button();
            this.m_oOKButton = new System.Windows.Forms.Button();
            this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.BitmapTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_oWidthInPixelsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_oWidthInCharsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_oPaddingBetweenCharsNumericUpDown)).BeginInit();
            this.DataFileTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.BitmapTabPage);
            this.tabControl1.Controls.Add(this.DataFileTabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // BitmapTabPage
            // 
            this.BitmapTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.BitmapTabPage.Controls.Add(this.groupBox3);
            this.BitmapTabPage.Controls.Add(this.groupBox2);
            this.BitmapTabPage.Location = new System.Drawing.Point(4, 22);
            this.BitmapTabPage.Name = "BitmapTabPage";
            this.BitmapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BitmapTabPage.Size = new System.Drawing.Size(385, 418);
            this.BitmapTabPage.TabIndex = 1;
            this.BitmapTabPage.Text = "Bitmap";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_oColourCustomRadioButton);
            this.groupBox3.Controls.Add(this.m_oColourTransparentRadioButton);
            this.groupBox3.Controls.Add(this.m_oColorButton);
            this.groupBox3.Location = new System.Drawing.Point(9, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Background Colour";
            // 
            // m_oColourCustomRadioButton
            // 
            this.m_oColourCustomRadioButton.AutoSize = true;
            this.m_oColourCustomRadioButton.Location = new System.Drawing.Point(9, 42);
            this.m_oColourCustomRadioButton.Name = "m_oColourCustomRadioButton";
            this.m_oColourCustomRadioButton.Size = new System.Drawing.Size(60, 17);
            this.m_oColourCustomRadioButton.TabIndex = 4;
            this.m_oColourCustomRadioButton.TabStop = true;
            this.m_oColourCustomRadioButton.Text = "Custom";
            this.m_ToolTip.SetToolTip(this.m_oColourCustomRadioButton, "Make the background of the bitmap a custom colour.");
            this.m_oColourCustomRadioButton.UseVisualStyleBackColor = true;
            this.m_oColourCustomRadioButton.CheckedChanged += new System.EventHandler(this.m_oColourCustomRadioButton_CheckedChanged);
            // 
            // m_oColourTransparentRadioButton
            // 
            this.m_oColourTransparentRadioButton.AutoSize = true;
            this.m_oColourTransparentRadioButton.Location = new System.Drawing.Point(9, 20);
            this.m_oColourTransparentRadioButton.Name = "m_oColourTransparentRadioButton";
            this.m_oColourTransparentRadioButton.Size = new System.Drawing.Size(82, 17);
            this.m_oColourTransparentRadioButton.TabIndex = 3;
            this.m_oColourTransparentRadioButton.TabStop = true;
            this.m_oColourTransparentRadioButton.Text = "Transparent";
            this.m_ToolTip.SetToolTip(this.m_oColourTransparentRadioButton, "Make the background of the bitmap 100% transparent.");
            this.m_oColourTransparentRadioButton.UseVisualStyleBackColor = true;
            this.m_oColourTransparentRadioButton.CheckedChanged += new System.EventHandler(this.m_oColourTransparentRadioButton_CheckedChanged);
            // 
            // m_oColorButton
            // 
            this.m_oColorButton.BackColor = System.Drawing.Color.Black;
            this.m_oColorButton.Location = new System.Drawing.Point(118, 19);
            this.m_oColorButton.Name = "m_oColorButton";
            this.m_oColorButton.Size = new System.Drawing.Size(75, 41);
            this.m_oColorButton.TabIndex = 2;
            this.m_ToolTip.SetToolTip(this.m_oColorButton, "Select the Custom background colour of the array.");
            this.m_oColorButton.UseVisualStyleBackColor = false;
            this.m_oColorButton.Click += new System.EventHandler(this.m_oColorButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_oPadBitmatToPowOf2CheckBox);
            this.groupBox2.Controls.Add(this.m_oWidthInPixelsNumericUpDown);
            this.groupBox2.Controls.Add(this.m_oWidthInCharsNumericUpDown);
            this.groupBox2.Controls.Add(this.m_oPaddingBetweenCharsNumericUpDown);
            this.groupBox2.Controls.Add(this.m_oWidthInPixelsRadioButton);
            this.groupBox2.Controls.Add(this.m_oWidthInCharsRadioButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitmap Padding";
            // 
            // m_oPadBitmatToPowOf2CheckBox
            // 
            this.m_oPadBitmatToPowOf2CheckBox.AutoSize = true;
            this.m_oPadBitmatToPowOf2CheckBox.Location = new System.Drawing.Point(10, 98);
            this.m_oPadBitmatToPowOf2CheckBox.Name = "m_oPadBitmatToPowOf2CheckBox";
            this.m_oPadBitmatToPowOf2CheckBox.Size = new System.Drawing.Size(166, 17);
            this.m_oPadBitmatToPowOf2CheckBox.TabIndex = 6;
            this.m_oPadBitmatToPowOf2CheckBox.Text = "Pad Bitmat to next Power of 2";
            this.m_ToolTip.SetToolTip(this.m_oPadBitmatToPowOf2CheckBox, "Forces the resulting texture to have a resolution of a power of two. This overrid" +
        "es the \"Width in Pixels\" option above.");
            this.m_oPadBitmatToPowOf2CheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oWidthInPixelsNumericUpDown
            // 
            this.m_oWidthInPixelsNumericUpDown.Location = new System.Drawing.Point(137, 71);
            this.m_oWidthInPixelsNumericUpDown.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.m_oWidthInPixelsNumericUpDown.Name = "m_oWidthInPixelsNumericUpDown";
            this.m_oWidthInPixelsNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.m_oWidthInPixelsNumericUpDown.TabIndex = 5;
            this.m_ToolTip.SetToolTip(this.m_oWidthInPixelsNumericUpDown, "width of the resulting texture in pixels.");
            // 
            // m_oWidthInCharsNumericUpDown
            // 
            this.m_oWidthInCharsNumericUpDown.Location = new System.Drawing.Point(137, 45);
            this.m_oWidthInCharsNumericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.m_oWidthInCharsNumericUpDown.Name = "m_oWidthInCharsNumericUpDown";
            this.m_oWidthInCharsNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.m_oWidthInCharsNumericUpDown.TabIndex = 4;
            this.m_ToolTip.SetToolTip(this.m_oWidthInCharsNumericUpDown, "the number of characters per line.");
            // 
            // m_oPaddingBetweenCharsNumericUpDown
            // 
            this.m_oPaddingBetweenCharsNumericUpDown.Location = new System.Drawing.Point(137, 19);
            this.m_oPaddingBetweenCharsNumericUpDown.Name = "m_oPaddingBetweenCharsNumericUpDown";
            this.m_oPaddingBetweenCharsNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.m_oPaddingBetweenCharsNumericUpDown.TabIndex = 3;
            this.m_ToolTip.SetToolTip(this.m_oPaddingBetweenCharsNumericUpDown, "Padding (in Pixels) between each Character and the edge of the Bitmap.");
            // 
            // m_oWidthInPixelsRadioButton
            // 
            this.m_oWidthInPixelsRadioButton.AutoSize = true;
            this.m_oWidthInPixelsRadioButton.Location = new System.Drawing.Point(10, 74);
            this.m_oWidthInPixelsRadioButton.Name = "m_oWidthInPixelsRadioButton";
            this.m_oWidthInPixelsRadioButton.Size = new System.Drawing.Size(98, 17);
            this.m_oWidthInPixelsRadioButton.TabIndex = 2;
            this.m_oWidthInPixelsRadioButton.TabStop = true;
            this.m_oWidthInPixelsRadioButton.Text = "Width In Pixels:";
            this.m_oWidthInPixelsRadioButton.UseVisualStyleBackColor = true;
            this.m_oWidthInPixelsRadioButton.CheckedChanged += new System.EventHandler(this.m_oWidthInPixelsRadioButton_CheckedChanged);
            // 
            // m_oWidthInCharsRadioButton
            // 
            this.m_oWidthInCharsRadioButton.AutoSize = true;
            this.m_oWidthInCharsRadioButton.Location = new System.Drawing.Point(10, 45);
            this.m_oWidthInCharsRadioButton.Name = "m_oWidthInCharsRadioButton";
            this.m_oWidthInCharsRadioButton.Size = new System.Drawing.Size(97, 17);
            this.m_oWidthInCharsRadioButton.TabIndex = 1;
            this.m_oWidthInCharsRadioButton.TabStop = true;
            this.m_oWidthInCharsRadioButton.Text = "Width in Chars:";
            this.m_oWidthInCharsRadioButton.UseVisualStyleBackColor = true;
            this.m_oWidthInCharsRadioButton.CheckedChanged += new System.EventHandler(this.m_oWidthInCharsRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Padding Between Chars:";
            // 
            // DataFileTabPage
            // 
            this.DataFileTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.DataFileTabPage.Controls.Add(this.groupBox1);
            this.DataFileTabPage.Location = new System.Drawing.Point(4, 22);
            this.DataFileTabPage.Name = "DataFileTabPage";
            this.DataFileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DataFileTabPage.Size = new System.Drawing.Size(385, 418);
            this.DataFileTabPage.TabIndex = 0;
            this.DataFileTabPage.Text = "Data File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DirectXCoordSystemRadioButton);
            this.groupBox1.Controls.Add(this.OpenGLCoordSystemRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UV Coord System";
            // 
            // DirectXCoordSystemRadioButton
            // 
            this.DirectXCoordSystemRadioButton.AutoSize = true;
            this.DirectXCoordSystemRadioButton.Location = new System.Drawing.Point(6, 42);
            this.DirectXCoordSystemRadioButton.Name = "DirectXCoordSystemRadioButton";
            this.DirectXCoordSystemRadioButton.Size = new System.Drawing.Size(151, 17);
            this.DirectXCoordSystemRadioButton.TabIndex = 1;
            this.DirectXCoordSystemRadioButton.TabStop = true;
            this.DirectXCoordSystemRadioButton.Text = "DirectX Coordinate System";
            this.m_ToolTip.SetToolTip(this.DirectXCoordSystemRadioButton, "Use the DirectX coordinate system for the UV Coordinates (-1,-1 = top right).");
            this.DirectXCoordSystemRadioButton.UseVisualStyleBackColor = true;
            this.DirectXCoordSystemRadioButton.CheckedChanged += new System.EventHandler(this.DirectXCoordSystemRadioButton_CheckedChanged);
            // 
            // OpenGLCoordSystemRadioButton
            // 
            this.OpenGLCoordSystemRadioButton.AutoSize = true;
            this.OpenGLCoordSystemRadioButton.Location = new System.Drawing.Point(6, 19);
            this.OpenGLCoordSystemRadioButton.Name = "OpenGLCoordSystemRadioButton";
            this.OpenGLCoordSystemRadioButton.Size = new System.Drawing.Size(156, 17);
            this.OpenGLCoordSystemRadioButton.TabIndex = 0;
            this.OpenGLCoordSystemRadioButton.TabStop = true;
            this.OpenGLCoordSystemRadioButton.Text = "OpenGL Coordinate System";
            this.m_ToolTip.SetToolTip(this.OpenGLCoordSystemRadioButton, "Use the OpenGL coordinate system for the UV Coordinates (0,0 = bottom left).");
            this.OpenGLCoordSystemRadioButton.UseVisualStyleBackColor = true;
            this.OpenGLCoordSystemRadioButton.CheckedChanged += new System.EventHandler(this.OpenGLCoordSystemRadioButton_CheckedChanged);
            // 
            // m_oColorDialog
            // 
            this.m_oColorDialog.AnyColor = true;
            this.m_oColorDialog.FullOpen = true;
            // 
            // m_oCancelButton
            // 
            this.m_oCancelButton.Location = new System.Drawing.Point(224, 453);
            this.m_oCancelButton.Name = "m_oCancelButton";
            this.m_oCancelButton.Size = new System.Drawing.Size(75, 23);
            this.m_oCancelButton.TabIndex = 1;
            this.m_oCancelButton.Text = "Cancel";
            this.m_ToolTip.SetToolTip(this.m_oCancelButton, "Cancel Changes.");
            this.m_oCancelButton.UseVisualStyleBackColor = true;
            this.m_oCancelButton.Click += new System.EventHandler(this.m_oCancelButton_Click);
            // 
            // m_oApplyButton
            // 
            this.m_oApplyButton.Location = new System.Drawing.Point(305, 453);
            this.m_oApplyButton.Name = "m_oApplyButton";
            this.m_oApplyButton.Size = new System.Drawing.Size(75, 23);
            this.m_oApplyButton.TabIndex = 2;
            this.m_oApplyButton.Text = "Apply";
            this.m_ToolTip.SetToolTip(this.m_oApplyButton, "Apply Changes.");
            this.m_oApplyButton.UseVisualStyleBackColor = true;
            this.m_oApplyButton.Click += new System.EventHandler(this.m_oApplyButton_Click);
            // 
            // m_oOKButton
            // 
            this.m_oOKButton.Location = new System.Drawing.Point(143, 453);
            this.m_oOKButton.Name = "m_oOKButton";
            this.m_oOKButton.Size = new System.Drawing.Size(75, 23);
            this.m_oOKButton.TabIndex = 3;
            this.m_oOKButton.Text = "OK";
            this.m_ToolTip.SetToolTip(this.m_oOKButton, "Apply Changes and close the options window.");
            this.m_oOKButton.UseVisualStyleBackColor = true;
            this.m_oOKButton.Click += new System.EventHandler(this.m_oOKButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 488);
            this.Controls.Add(this.m_oOKButton);
            this.Controls.Add(this.m_oApplyButton);
            this.Controls.Add(this.m_oCancelButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tabControl1.ResumeLayout(false);
            this.BitmapTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_oWidthInPixelsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_oWidthInCharsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_oPaddingBetweenCharsNumericUpDown)).EndInit();
            this.DataFileTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataFileTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DirectXCoordSystemRadioButton;
        private System.Windows.Forms.RadioButton OpenGLCoordSystemRadioButton;
        private System.Windows.Forms.TabPage BitmapTabPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox m_oPadBitmatToPowOf2CheckBox;
        private System.Windows.Forms.NumericUpDown m_oWidthInPixelsNumericUpDown;
        private System.Windows.Forms.NumericUpDown m_oWidthInCharsNumericUpDown;
        private System.Windows.Forms.NumericUpDown m_oPaddingBetweenCharsNumericUpDown;
        private System.Windows.Forms.RadioButton m_oWidthInPixelsRadioButton;
        private System.Windows.Forms.RadioButton m_oWidthInCharsRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog m_oColorDialog;
        private System.Windows.Forms.Button m_oColorButton;
        private System.Windows.Forms.Button m_oCancelButton;
        private System.Windows.Forms.Button m_oApplyButton;
        private System.Windows.Forms.Button m_oOKButton;
        private System.Windows.Forms.RadioButton m_oColourCustomRadioButton;
        private System.Windows.Forms.RadioButton m_oColourTransparentRadioButton;
        private System.Windows.Forms.ToolTip m_ToolTip;
    }
}