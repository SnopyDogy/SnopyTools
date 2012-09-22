namespace Font_Builder
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.FontPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.MonoSpacedCheckBox = new System.Windows.Forms.CheckBox();
            this.FontDataExprotButton = new System.Windows.Forms.Button();
            this.GenFontBitmapButton = new System.Windows.Forms.Button();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AACheckBox = new System.Windows.Forms.CheckBox();
            this.MaxCharTextBox = new System.Windows.Forms.TextBox();
            this.MinCharTextBox = new System.Windows.Forms.TextBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.TextColorButton);
            this.splitContainer1.Panel2.Controls.Add(this.MonoSpacedCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.FontDataExprotButton);
            this.splitContainer1.Panel2.Controls.Add(this.GenFontBitmapButton);
            this.splitContainer1.Panel2.Controls.Add(this.FontComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.StyleComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.SizeComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.SampleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.AACheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.MaxCharTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MinCharTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 620);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FontPictureBox);
            this.splitContainer2.Size = new System.Drawing.Size(1169, 450);
            this.splitContainer2.SplitterDistance = 1006;
            this.splitContainer2.TabIndex = 0;
            // 
            // FontPictureBox
            // 
            this.FontPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FontPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FontPictureBox.Name = "FontPictureBox";
            this.FontPictureBox.Size = new System.Drawing.Size(1006, 450);
            this.FontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FontPictureBox.TabIndex = 0;
            this.FontPictureBox.TabStop = false;
            this.FontPictureBox.Click += new System.EventHandler(this.FontPictureBox_Click);
            this.FontPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.FontPictureBox_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Text Color";
            // 
            // TextColorButton
            // 
            this.TextColorButton.BackColor = System.Drawing.Color.White;
            this.TextColorButton.Location = new System.Drawing.Point(610, 46);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(28, 23);
            this.TextColorButton.TabIndex = 20;
            this.TextColorButton.UseVisualStyleBackColor = false;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // MonoSpacedCheckBox
            // 
            this.MonoSpacedCheckBox.AutoSize = true;
            this.MonoSpacedCheckBox.Checked = true;
            this.MonoSpacedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MonoSpacedCheckBox.Location = new System.Drawing.Point(543, 30);
            this.MonoSpacedCheckBox.Name = "MonoSpacedCheckBox";
            this.MonoSpacedCheckBox.Size = new System.Drawing.Size(84, 17);
            this.MonoSpacedCheckBox.TabIndex = 19;
            this.MonoSpacedCheckBox.Text = "MonoSpace";
            this.MonoSpacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // FontDataExprotButton
            // 
            this.FontDataExprotButton.Location = new System.Drawing.Point(692, 8);
            this.FontDataExprotButton.Name = "FontDataExprotButton";
            this.FontDataExprotButton.Size = new System.Drawing.Size(114, 23);
            this.FontDataExprotButton.TabIndex = 18;
            this.FontDataExprotButton.Text = "Export Font Data";
            this.FontDataExprotButton.UseVisualStyleBackColor = true;
            this.FontDataExprotButton.Click += new System.EventHandler(this.FontDataExprotButton_Click);
            // 
            // GenFontBitmapButton
            // 
            this.GenFontBitmapButton.Location = new System.Drawing.Point(341, 24);
            this.GenFontBitmapButton.Name = "GenFontBitmapButton";
            this.GenFontBitmapButton.Size = new System.Drawing.Size(196, 23);
            this.GenFontBitmapButton.TabIndex = 17;
            this.GenFontBitmapButton.Text = "Gen Font Bitmap";
            this.GenFontBitmapButton.UseVisualStyleBackColor = true;
            this.GenFontBitmapButton.Click += new System.EventHandler(this.GenFontBitmapButton_Click);
            // 
            // FontComboBox
            // 
            this.FontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(13, 24);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(175, 137);
            this.FontComboBox.TabIndex = 16;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Style:";
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StyleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold, Italic"});
            this.StyleComboBox.Location = new System.Drawing.Point(194, 24);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(75, 137);
            this.StyleComboBox.TabIndex = 14;
            this.StyleComboBox.Text = "Regular";
            this.StyleComboBox.SelectedIndexChanged += new System.EventHandler(this.StyleComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size:";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SizeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Items.AddRange(new object[] {
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
            this.SizeComboBox.Location = new System.Drawing.Point(275, 24);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(60, 139);
            this.SizeComboBox.TabIndex = 12;
            this.SizeComboBox.Text = "11";
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            this.SizeComboBox.TextUpdate += new System.EventHandler(this.SizeComboBox_TextUpdate);
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoEllipsis = true;
            this.SampleLabel.Location = new System.Drawing.Point(338, 46);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(213, 108);
            this.SampleLabel.TabIndex = 11;
            this.SampleLabel.Text = "The quick brown fox jumped over the LAZY camel";
            this.SampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MaxChar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MinChar";
            // 
            // AACheckBox
            // 
            this.AACheckBox.AutoSize = true;
            this.AACheckBox.Checked = true;
            this.AACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AACheckBox.Location = new System.Drawing.Point(543, 7);
            this.AACheckBox.Name = "AACheckBox";
            this.AACheckBox.Size = new System.Drawing.Size(77, 17);
            this.AACheckBox.TabIndex = 8;
            this.AACheckBox.Text = "Antialiased";
            this.AACheckBox.UseVisualStyleBackColor = true;
            // 
            // MaxCharTextBox
            // 
            this.MaxCharTextBox.Location = new System.Drawing.Point(495, 5);
            this.MaxCharTextBox.Name = "MaxCharTextBox";
            this.MaxCharTextBox.Size = new System.Drawing.Size(42, 20);
            this.MaxCharTextBox.TabIndex = 7;
            this.MaxCharTextBox.Text = "0x7F";
            // 
            // MinCharTextBox
            // 
            this.MinCharTextBox.Location = new System.Drawing.Point(390, 5);
            this.MinCharTextBox.Name = "MinCharTextBox";
            this.MinCharTextBox.Size = new System.Drawing.Size(44, 20);
            this.MinCharTextBox.TabIndex = 6;
            this.MinCharTextBox.Text = "0x20";
            // 
            // ColorDialog
            // 
            this.ColorDialog.SolidColorOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Font Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FontPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox FontPictureBox;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AACheckBox;
        private System.Windows.Forms.TextBox MaxCharTextBox;
        private System.Windows.Forms.TextBox MinCharTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.Button GenFontBitmapButton;
        private System.Windows.Forms.Button FontDataExprotButton;
        private System.Windows.Forms.CheckBox MonoSpacedCheckBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.Label label5;
    }
}

