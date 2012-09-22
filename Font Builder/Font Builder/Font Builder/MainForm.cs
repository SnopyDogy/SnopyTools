using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Imaging;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace Font_Builder
{
    public partial class MainForm : Form
    {
        Bitmap globalBitmap;
        Graphics globalGraphics;
        System.Drawing.Font font;
        string fontError;
        Font_Builder.Font oFontData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalBitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            globalGraphics = Graphics.FromImage(globalBitmap);

            foreach (FontFamily font in FontFamily.Families)
                FontComboBox.Items.Add(font.Name);

            FontComboBox.Text = "Comic Sans MS";
        }

        /// <summary>
        /// When the font selection changes, create a new Font
        /// instance and update the preview text label.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        void SelectionChanged()
        {
            try
            {
                // Parse the size selection.
                float size;

                if (!float.TryParse(SizeComboBox.Text, out size) || (size <= 0))
                {
                    fontError = "Invalid font size '" + SizeComboBox.Text + "'";
                    return;
                }

                // Parse the font style selection.
                FontStyle style;
                

                try
                {
                    style = (FontStyle)Enum.Parse(typeof(FontStyle), StyleComboBox.Text);
                }
                catch
                {
                    fontError = "Invalid font style '" + StyleComboBox.Text + "'";
                    return;
                }

                // Create the new font.
                System.Drawing.Font newFont = new System.Drawing.Font(FontComboBox.Text, size, style);

                if (font != null)
                    font.Dispose();

                SampleLabel.Font = font = newFont;

                fontError = null;
            }
            catch (Exception exception)
            {
                fontError = exception.Message;
            }
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void SizeComboBox_TextUpdate(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        /// <summary>
        /// Event handler for when the user clicks on the Gen Font Bitmap button.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void GenFontBitmapButton_Click(object sender, EventArgs e)
        {
            // Create New Font Class
            oFontData = new Font_Builder.Font();

            try
            {
                // If the current font is invalid, report that to the user.
                if (fontError != null)
                    throw new ArgumentException(fontError);

                // Convert the character range from string to integer,
                // and validate it.
                int minChar = ParseHex(MinCharTextBox.Text);
                int maxChar = ParseHex(MaxCharTextBox.Text);

                if ((minChar >= maxChar) ||
                    (minChar < 0) || (minChar > 0xFFFF) ||
                    (maxChar < 0) || (maxChar > 0xFFFF))
                {
                    throw new ArgumentException("Invalid character range " +
                                                MinCharTextBox.Text + " - " + MaxCharTextBox.Text);
                }

                // Choose the output file.
                SaveFileDialog fileSelector = new SaveFileDialog();

                fileSelector.Title = "Export Font";
                fileSelector.DefaultExt = "bmp";
                fileSelector.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";

                if (fileSelector.ShowDialog() == DialogResult.OK)
                {
                    oFontData.Texture = fileSelector.FileName;

                    // Build up a list of all the glyphs to be output.
                    List<Bitmap> bitmaps = new List<Bitmap>();
                    List<int> xPositions = new List<int>();
                    List<int> yPositions = new List<int>();

                    try
                    {
                        const int padding = 8;

                        int width = padding;
                        int height = padding;
                        int lineWidth = padding;
                        int lineHeight = padding;
                        int count = 0;

                        // Rasterize each character in turn,
                        // and add it to the output list.
                        for (char ch = (char)minChar; ch < maxChar; ch++)
                        {
                            Bitmap bitmap = RasterizeCharacter(ch);
                            Character oCharacter = new Character();
                            oCharacter.Char = ch.ToString();

                            bitmaps.Add(bitmap);

                            xPositions.Add(lineWidth);
                            yPositions.Add(height);

                            oCharacter.Umin = (float)lineWidth;
                            oCharacter.Vmin = (float)height;
                            oCharacter.Umax = (float)(lineWidth + bitmap.Width);
                            oCharacter.Vmax = (float)(height + bitmap.Height);

                            lineWidth += bitmap.Width + padding;
                            lineHeight = Math.Max(lineHeight, bitmap.Height + padding);

                            // Output 16 glyphs per line, then wrap to the next line.
                            if ((++count == 16) || (ch == maxChar - 1))
                            {
                                width = Math.Max(width, lineWidth);
                                height += lineHeight;
                                lineWidth = padding;
                                lineHeight = padding;
                                count = 0;
                            }

                            // Add char to font data:
                            oFontData.Characters.Add(oCharacter);
                        }

                        using (Bitmap bitmap = new Bitmap(width, height,
                                                          PixelFormat.Format32bppArgb))
                        {
                            // Arrage all the glyphs onto a single larger bitmap.
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.Clear(Color.MidnightBlue);
                                graphics.CompositingMode = CompositingMode.SourceCopy;

                                for (int i = 0; i < bitmaps.Count; i++)
                                {
                                    graphics.DrawImage(bitmaps[i], xPositions[i],
                                                                   yPositions[i]);
                                }

                                graphics.Flush();
                            }

                            // Set Proper UV Coords:
                            oFontData.ConvertUVCoords(bitmap.Width, bitmap.Height);

                            // Save out the combined bitmap.
                            bitmap.Save(fileSelector.FileName, ImageFormat.Bmp);
                            //set pitcure box to bitmap:
                            FontPictureBox.ImageLocation = fileSelector.FileName;
                        }
                    }
                    finally
                    {
                        // Clean up temporary objects.
                        foreach (Bitmap bitmap in bitmaps)
                            bitmap.Dispose();
                    }
                }
            }
            catch (Exception exception)
            {
                // Report any errors to the user.
                MessageBox.Show(exception.Message, Text + " Error");
            }
        }


        /// <summary>
        /// Helper for rendering out a single font character
        /// into a System.Drawing bitmap.
        /// </summary>
        private Bitmap RasterizeCharacter(char ch)
        {
            string text = ch.ToString();

            SizeF size = globalGraphics.MeasureString(text, font);

            int width = (int)Math.Ceiling(size.Width);
            int height = (int)Math.Ceiling(size.Height);

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                if (AACheckBox.Checked)
                {
                    graphics.TextRenderingHint =
                        TextRenderingHint.AntiAliasGridFit;
                }
                else
                {
                    graphics.TextRenderingHint =
                        TextRenderingHint.SingleBitPerPixelGridFit;
                }

                graphics.Clear(Color.Transparent);

                using (Brush brush = new SolidBrush(TextColorButton.BackColor))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Near;

                    graphics.DrawString(text, font, brush, 0, 0, format);
                }

                graphics.Flush();
            }

            if (MonoSpacedCheckBox.Checked)
            {
                return bitmap;
            }

            return CropCharacter(bitmap);
        }


        /// <summary>
        /// Helper for cropping ununsed space from the sides of a bitmap.
        /// </summary>
        private static Bitmap CropCharacter(Bitmap bitmap)
        {
            int cropLeft = 0;
            int cropRight = bitmap.Width - 1;

            // Remove unused space from the left.
            while ((cropLeft < cropRight) && (BitmapIsEmpty(bitmap, cropLeft)))
                cropLeft++;

            // Remove unused space from the right.
            while ((cropRight > cropLeft) && (BitmapIsEmpty(bitmap, cropRight)))
                cropRight--;

            // Don't crop if that would reduce the glyph down to nothing at all!
            if (cropLeft == cropRight)
                return bitmap;

            // Add some padding back in.
            cropLeft = Math.Max(cropLeft - 1, 0);
            cropRight = Math.Min(cropRight + 1, bitmap.Width - 1);

            int width = cropRight - cropLeft + 1;

            // Crop the glyph.
            Bitmap croppedBitmap = new Bitmap(width, bitmap.Height, bitmap.PixelFormat);

            using (Graphics graphics = Graphics.FromImage(croppedBitmap))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;

                graphics.DrawImage(bitmap, 0, 0,
                                   new Rectangle(cropLeft, 0, width, bitmap.Height),
                                   GraphicsUnit.Pixel);

                graphics.Flush();
            }

            bitmap.Dispose();

            return croppedBitmap;
        }


        /// <summary>
        /// Helper for testing whether a column of a bitmap is entirely empty.
        /// </summary>
        private static bool BitmapIsEmpty(Bitmap bitmap, int x)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                if (bitmap.GetPixel(x, y).A != 0)
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Helper for converting strings to integer.
        /// </summary>
        static int ParseHex(string text)
        {
            NumberStyles style;

            if (text.StartsWith("0x"))
            {
                style = NumberStyles.HexNumber;
                text = text.Substring(2);
            }
            else
            {
                style = NumberStyles.Integer;
            }

            int result;

            if (!int.TryParse(text, style, null, out result))
                return -1;

            return result;
        }

        private void FontPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void FontPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (oFontData == null)
            {
                return;
            }

            foreach (Character oChar in oFontData.Characters)
            {
                Rectangle oRect = new Rectangle((int)(oChar.Umin * FontPictureBox.Width), 
                                                (int)(oChar.Vmin * FontPictureBox.Height), 
                                                (int)(oChar.Umax * FontPictureBox.Width) - (int)(oChar.Umin * FontPictureBox.Width),
                                                (int)(oChar.Vmax * FontPictureBox.Height) - (int)(oChar.Vmin * FontPictureBox.Height));
                e.Graphics.DrawRectangle(System.Drawing.Pens.AntiqueWhite, oRect);
            }
        }

        private void FontDataExprotButton_Click(object sender, EventArgs e)
        {
            // Choose the output file.
            SaveFileDialog fileSelector = new SaveFileDialog();

            fileSelector.Title = "Export Font Data";
            fileSelector.DefaultExt = "xml";
            fileSelector.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer ser = new XmlSerializer(typeof(Font_Builder.Font));
                StreamWriter writer = new StreamWriter(fileSelector.FileName);
                ser.Serialize(writer, oFontData);
                writer.Close();
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                TextColorButton.BackColor = ColorDialog.Color;
            }
        }
    }
}
