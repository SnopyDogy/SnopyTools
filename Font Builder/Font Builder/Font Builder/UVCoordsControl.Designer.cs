namespace Font_Builder
{
    partial class UVCoordsControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_oUVCoordsListBox = new System.Windows.Forms.ListBox();
            this.m_oUVCoordPropertyGrid = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.m_oUVCoordsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_oUVCoordPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(215, 477);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 0;
            // 
            // m_oUVCoordsListBox
            // 
            this.m_oUVCoordsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_oUVCoordsListBox.FormattingEnabled = true;
            this.m_oUVCoordsListBox.Location = new System.Drawing.Point(0, 0);
            this.m_oUVCoordsListBox.Name = "m_oUVCoordsListBox";
            this.m_oUVCoordsListBox.Size = new System.Drawing.Size(215, 126);
            this.m_oUVCoordsListBox.TabIndex = 0;
            this.m_oUVCoordsListBox.SelectedIndexChanged += new System.EventHandler(this.m_oUVCoordsListBox_SelectedIndexChanged);
            // 
            // m_oUVCoordPropertyGrid
            // 
            this.m_oUVCoordPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_oUVCoordPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.m_oUVCoordPropertyGrid.Name = "m_oUVCoordPropertyGrid";
            this.m_oUVCoordPropertyGrid.Size = new System.Drawing.Size(215, 347);
            this.m_oUVCoordPropertyGrid.TabIndex = 0;
            // 
            // UVCoordsControl
            // 
            this.AutoHidePortion = 0.2D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 477);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "UVCoordsControl";
            this.TabText = "UV Coords";
            this.Text = "UV Coords";
            this.ToolTipText = "UV Coord Controls";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox m_oUVCoordsListBox;
        private System.Windows.Forms.PropertyGrid m_oUVCoordPropertyGrid;
    }
}
