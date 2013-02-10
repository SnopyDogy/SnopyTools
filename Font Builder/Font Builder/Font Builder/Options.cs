using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Font_Builder
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            // set up options according to saved settings:
            if (Font_Builder.Properties.Settings.Default.UVCoordSystem == UV_COORDS_SYSTEMS.DIRECTX)
            {
                OpenGLCoordSystemRadioButton.Checked = false;
                DirectXCoordSystemRadioButton.Checked = true;
            }
            else
            {
                OpenGLCoordSystemRadioButton.Checked = true;
                DirectXCoordSystemRadioButton.Checked = false;
            }

            if (Font_Builder.Properties.Settings.Default.MaxLineWidthStyle == BITMAP_WIDTH_CAP_STYLE.CAP_BY_NO_OF_PIXELS)
            {
                m_oWidthInCharsRadioButton.Checked = false;
                m_oWidthInCharsNumericUpDown.Enabled = false;
                m_oWidthInPixelsRadioButton.Checked = true;
                m_oWidthInPixelsNumericUpDown.Enabled = true;
            }
            else
            {
                m_oWidthInCharsRadioButton.Checked = true;
                m_oWidthInCharsNumericUpDown.Enabled = true;
                m_oWidthInPixelsRadioButton.Checked = false;
                m_oWidthInPixelsNumericUpDown.Enabled = false;
            }

            m_oWidthInPixelsNumericUpDown.Value = Font_Builder.Properties.Settings.Default.MaxLineWidthInPixels;
            m_oWidthInCharsNumericUpDown.Value = Font_Builder.Properties.Settings.Default.MaxLineWidthInChars;
            m_oPaddingBetweenCharsNumericUpDown.Value = Font_Builder.Properties.Settings.Default.BitmatPaddingBetweenChars;

            if (Font_Builder.Properties.Settings.Default.PadBitmapToNextPowerOfTwo == true)
            {
                m_oPadBitmatToPowOf2CheckBox.Checked = true;
            }
            else
            {
                m_oPadBitmatToPowOf2CheckBox.Checked = false;
            }

            if (Font_Builder.Properties.Settings.Default.BitmapBackgroundColor == Color.Transparent)
            {
                m_oColorButton.BackColor = Color.Transparent;
                m_oColorButton.Enabled = false;
                m_oColourTransparentRadioButton.Checked = true;
                m_oColourCustomRadioButton.Checked = false;
            }
            else
            {
                m_oColorButton.BackColor = Font_Builder.Properties.Settings.Default.BitmapBackgroundColor;
                m_oColorButton.Enabled = true;
                m_oColourTransparentRadioButton.Checked = false;
                m_oColourCustomRadioButton.Checked = true;
            }
        }


        #region Private Methods

        void SaveSettings()
        {
            if (DirectXCoordSystemRadioButton.Checked)
            {
                Font_Builder.Properties.Settings.Default.UVCoordSystem = UV_COORDS_SYSTEMS.DIRECTX;
            }
            else
            {
                Font_Builder.Properties.Settings.Default.UVCoordSystem = UV_COORDS_SYSTEMS.OPENGL;
            }

            if (m_oWidthInCharsRadioButton.Checked)
            {
                Font_Builder.Properties.Settings.Default.MaxLineWidthStyle = BITMAP_WIDTH_CAP_STYLE.CAP_BY_NO_OF_CHARS;
            }
            else
            {
                Font_Builder.Properties.Settings.Default.MaxLineWidthStyle = BITMAP_WIDTH_CAP_STYLE.CAP_BY_NO_OF_PIXELS;
            }

            Font_Builder.Properties.Settings.Default.MaxLineWidthInPixels = (int)m_oWidthInPixelsNumericUpDown.Value;
            Font_Builder.Properties.Settings.Default.MaxLineWidthInChars = (int)m_oWidthInCharsNumericUpDown.Value;
            Font_Builder.Properties.Settings.Default.BitmatPaddingBetweenChars = (int)m_oPaddingBetweenCharsNumericUpDown.Value;

            if (m_oPadBitmatToPowOf2CheckBox.Checked)
            {
                Font_Builder.Properties.Settings.Default.PadBitmapToNextPowerOfTwo = true;
            }
            else
            {
                Font_Builder.Properties.Settings.Default.PadBitmapToNextPowerOfTwo = false;
            }

            if (m_oColourTransparentRadioButton.Checked)
            {
                Font_Builder.Properties.Settings.Default.BitmapBackgroundColor = Color.Transparent;
            }
            else
            {
                Font_Builder.Properties.Settings.Default.BitmapBackgroundColor = m_oColorButton.BackColor;
            }
        }


        #endregion

        private void m_oOKButton_Click(object sender, EventArgs e)
        {
            SaveSettings(); // save the settings.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void m_oCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void m_oApplyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void m_oWidthInCharsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_oWidthInCharsRadioButton.Checked)
            {
                m_oWidthInPixelsNumericUpDown.Enabled = false;
                m_oWidthInPixelsRadioButton.Checked = false;
                m_oWidthInCharsNumericUpDown.Enabled = true;
            }
        }

        private void m_oWidthInPixelsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_oWidthInPixelsRadioButton.Checked)
            {
                m_oWidthInPixelsNumericUpDown.Enabled = true;
                m_oWidthInCharsRadioButton.Checked = false;
                m_oWidthInCharsNumericUpDown.Enabled = false;
            }
        }

        private void OpenGLCoordSystemRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OpenGLCoordSystemRadioButton.Checked)
            {
                DirectXCoordSystemRadioButton.Checked = false;
            }
        }

        private void DirectXCoordSystemRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DirectXCoordSystemRadioButton.Checked)
            {
                OpenGLCoordSystemRadioButton.Checked = false;
            }
        }

        private void m_oColourTransparentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_oColourTransparentRadioButton.Checked)
            {
                m_oColourCustomRadioButton.Checked = false;
                m_oColorButton.Enabled = false;
                m_oColorButton.BackColor = Color.Transparent;
            }
        }

        private void m_oColourCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_oColourCustomRadioButton.Checked)
            {
                m_oColourTransparentRadioButton.Checked = false;
                m_oColorButton.Enabled = true;
            }
        }

        private void m_oColorButton_Click(object sender, EventArgs e)
        {
            if (m_oColorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_oColorButton.BackColor = m_oColorDialog.Color;
            }
        }
    }
}
