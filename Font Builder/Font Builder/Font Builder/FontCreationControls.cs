using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Font_Builder
{
    public partial class FontCreationControls : DockContent
    {

        #region Properties

        public ComboBox FontComboBox
        {
            get
            {
                return m_oFontComboBox;
            }
        }

        public ComboBox StyleComboBox
        {
            get
            {
                return m_oStyleComboBox;
            }
        }

        public ComboBox SizeComboBox
        {
            get
            {
                return m_oSizeComboBox;
            }
        }

        public string MinChar
        {
            get
            {
                return m_oMinCharTextBox.Text;
            }
        }

        public string MaxChar
        {
            get
            {
                return m_oMaxCharTextBox.Text;
            }
        }

        public bool AntiAliased
        {
            get
            {
                return m_oAACheckBox.Checked;
            }
        }

        public bool MonoSpace
        {
            get
            {
                return m_oMonoSpaceCheckBox.Checked;
            }
        }

        public Color FontColor
        {
            get
            {
                return m_oColotButton.BackColor;
            }
        }

        public Label SampleLabel
        {
            get
            {
                return m_oSampleLabel;
            }
        }

        public Button FontDataExportButton
        {
            get
            {
                return m_oFontDataExportButton;
            }
        }

        public Button GenFontTextureButton
        {
            get
            {
                return m_oGenFontTextureButton;
            }
        }

        #endregion
        

        public FontCreationControls()
        {
            InitializeComponent();
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
            {
                this.AllowEndUserDocking = false;
            }
        }

        private void m_oColotButton_Click(object sender, EventArgs e)
        {
            m_oColorDialog.ShowDialog();
            m_oColotButton.BackColor = m_oColorDialog.Color;
        }
    }
}
