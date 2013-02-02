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
    public partial class FontBuilderForm : Form
    {
        FontTextureControl m_oTexturePanel = new FontTextureControl();
        FontCreationControls m_oControlsPanel = new FontCreationControls();
        UVCoordsControl m_oUVCoordsPanel = new UVCoordsControl();

        Bitmap globalBitmap;
        Graphics globalGraphics;
        System.Drawing.Font font;
        string fontError;
        Font_Builder.Font m_oFontData;

        float m_fZoom = 1;
        float m_fOffsetX = 0;
        float m_fOffsetY = 0;

        bool m_bPanning = false;
        int m_iPrevMousePosX = 0;
        int m_iPrevMousePosY = 0;


        Bitmap m_oFontTexture;

        public FontBuilderForm()
        {
            InitializeComponent();

            // Detect if running on mono:
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
            {
                MainDockPanel.AllowEndUserDocking = false;
                MainDockPanel.AllowEndUserNestedDocking = false;
                MainDockPanel.SupportDeeplyNestedContent = false;
            }

            MainDockPanel.DockBottomPortion = 0.4;
        }

        private void FontBuilderForm_Load(object sender, EventArgs e)
        {
            // Display Docking Panels:
            m_oTexturePanel.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            m_oControlsPanel.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            m_oUVCoordsPanel.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            // Create Bitmap and Graphics for creating Font Texture:
            globalBitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            globalGraphics = Graphics.FromImage(globalBitmap);

            // Populate Font Combo Box.
            foreach (FontFamily font in FontFamily.Families)
                m_oControlsPanel.FontComboBox.Items.Add(font.Name);

            m_oControlsPanel.FontComboBox.Text = "Comic Sans MS";

            // Add even handlers to Controls:
            m_oControlsPanel.FontComboBox.SelectedIndexChanged += new EventHandler(FontComboBox_SelectedIndexChanged);
            m_oControlsPanel.SizeComboBox.SelectedIndexChanged += new EventHandler(SizeComboBox_SelectedIndexChanged);
            m_oControlsPanel.SizeComboBox.TextUpdate += new EventHandler(SizeComboBox_TextUpdate);
            m_oControlsPanel.StyleComboBox.SelectedIndexChanged += new EventHandler(StyleComboBox_SelectedIndexChanged);
            m_oControlsPanel.FontDataExportButton.Click += new EventHandler(FontDataExportButton_Click);
            m_oControlsPanel.GenFontTextureButton.Click += new EventHandler(GenFontTextureButton_Click);
            m_oTexturePanel.FontPictureBox.Paint += new PaintEventHandler(FontPictureBox_Paint);
            m_oTexturePanel.MouseWheel += new MouseEventHandler(FontPictureBox_MouseWheel);
            m_oTexturePanel.FontPictureBox.MouseDown += new MouseEventHandler(FontPictureBox_MouseDown);
            m_oTexturePanel.FontPictureBox.MouseUp += new MouseEventHandler(m_oTexturePanel_MouseUp);
            m_oTexturePanel.FontPictureBox.MouseMove += new MouseEventHandler(m_oTexturePanel_MouseMove);
            //m_oTexturePanel.FontPaintPanel.Paint += new PaintEventHandler(FontPictureBox_Paint);
            m_oUVCoordsPanel.UVCoordsListBox.SelectedIndexChanged += new EventHandler(UVCoordsListBox_SelectedIndexChanged);
        }

        #region EventHandlers

        private void fontTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_oTexturePanel.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        }

        private void fontCreationControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_oControlsPanel.Show(MainDockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontSelectionChanged();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontSelectionChanged();
        }

        private void SizeComboBox_TextUpdate(object sender, EventArgs e)
        {
            FontSelectionChanged();
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontSelectionChanged();
        }

        void UVCoordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_oTexturePanel.Repaint();
        }

        void FontPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // modify zoom value on mouse wheel:
            if (e.Delta >= 120)
            {
                m_fZoom += 0.1f;
            }
            else if (e.Delta <= -120)
            {
                m_fZoom -= 0.1f;
            }

            // and redraw:
            m_oTexturePanel.Repaint();
        }

        void FontPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // on right click save mouse coords
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                m_bPanning = true;
                //Point pCurPos = m_oTexturePanel.FontPictureBox
                m_iPrevMousePosX = e.Location.X;
                m_iPrevMousePosX = e.Location.Y;
            }
        }

        void m_oTexturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // if right click, modify offset.
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                m_fOffsetX += e.Location.X - m_iPrevMousePosX;
                m_fOffsetY += e.Location.Y - m_iPrevMousePosY;

                m_iPrevMousePosX = e.Location.X;
                m_iPrevMousePosY = e.Location.Y;

                m_oTexturePanel.Repaint();
            }
        }

        void m_oTexturePanel_MouseUp(object sender, MouseEventArgs e)
        {
            m_bPanning = false;
            m_iPrevMousePosX = 0;
            m_iPrevMousePosY = 0;
        }

        private void FontPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // safty check:
            if (m_oFontData == null || m_oFontTexture == null)
            {
                return;
            }

            System.Drawing.Pen oHighlightPen = new Pen(Color.Yellow);
            if (m_fZoom < 1)
            {
                oHighlightPen.Width = 2;
            }
            
            // draw the image at the correct position:
            e.Graphics.DrawImage(   m_oFontTexture, 
                                    m_fOffsetX, m_fOffsetY, 
                                    m_oFontTexture.Width * m_fZoom, 
                                    m_oFontTexture.Height * m_fZoom); 

            // go through and draw the rectangles:
            foreach (Character oChar in m_oFontData.Characters)
            {
                Rectangle oRect = new Rectangle((int)((oChar.Umin * m_oFontTexture.Width * m_fZoom) + m_fOffsetX),
                                                (int)((oChar.Vmin * m_oFontTexture.Height * m_fZoom) + m_fOffsetY),
                                                (int)(oChar.Umax * m_oFontTexture.Width * m_fZoom) - (int)(oChar.Umin * m_oFontTexture.Width * m_fZoom),
                                                (int)(oChar.Vmax * m_oFontTexture.Height * m_fZoom) - (int)(oChar.Vmin * m_oFontTexture.Height * m_fZoom));
                if (oChar != m_oUVCoordsPanel.UVCoordsListBox.SelectedItem)
                {
                    e.Graphics.DrawRectangle(System.Drawing.Pens.White, oRect);
                }
                else
                {
                    // draw the selected item as yesllow:
                    e.Graphics.DrawRectangle(oHighlightPen, oRect);
                }
            }
        }

        private void FontDataExportButton_Click(object sender, EventArgs e)
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
                ser.Serialize(writer, m_oFontData);
                writer.Close();
            }
        }

        /// <summary>
        /// Event handler for when the user clicks on the Gen Font Bitmap button.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void GenFontTextureButton_Click(object sender, EventArgs e)
        {
            // Create New Font Class
            m_oFontData = new Font_Builder.Font();

            try
            {
                // If the current font is invalid, report that to the user.
                if (fontError != null)
                    throw new ArgumentException(fontError);

                // Convert the character range from string to integer,
                // and validate it.
                int minChar = ParseHex(m_oControlsPanel.MinChar);
                int maxChar = ParseHex(m_oControlsPanel.MaxChar);

                if ((minChar >= maxChar) ||
                    (minChar < 0) || (minChar > 0xFFFF) ||
                    (maxChar < 0) || (maxChar > 0xFFFF))
                {
                    throw new ArgumentException("Invalid character range " +
                                                m_oControlsPanel.MinChar + " - " + m_oControlsPanel.MaxChar);
                }

                // Choose the output file.
                SaveFileDialog fileSelector = new SaveFileDialog();

                fileSelector.Title = "Export Font";
                fileSelector.DefaultExt = "bmp";
                fileSelector.Filter = "PNG Files (*.png)|*.png|All files (*.*)|*.*";

                if (fileSelector.ShowDialog() == DialogResult.OK)
                {
                    m_oFontData.Texture = "./" + Path.GetFileName(fileSelector.FileName);

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
                            m_oFontData.Characters.Add(oCharacter);
                        }

                        // Make sure our texture is sized to a power of 2:
                        width = NextPowOf2(width);
                        height = NextPowOf2(height);

                        m_oFontTexture = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                        // Arrage all the glyphs onto a single larger bitmap.
                        Graphics graphics = Graphics.FromImage(m_oFontTexture);

                        graphics.Clear(Color.Transparent);
                        graphics.CompositingMode = CompositingMode.SourceCopy;

                        for (int i = 0; i < bitmaps.Count; i++)
                        {
                            graphics.DrawImage(bitmaps[i], xPositions[i],
                                                           yPositions[i]);
                        }

                        graphics.Flush();

                        //Set Proper UV Coords:
                        m_oFontData.ConvertUVCoords(m_oFontTexture.Width, m_oFontTexture.Height);

                        // Save out the combined bitmap.
                        ImageCodecInfo PngEncoder = PngEncoder = ImageCodecInfo.GetImageEncoders()[4]; // Built-in PNG Codec
                        System.Drawing.Imaging.Encoder PngEncoderQL = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters pngEncoderParameters = new EncoderParameters(1);
                        EncoderParameter PngEncoderParam = new EncoderParameter(PngEncoderQL, 50L);
                        pngEncoderParameters.Param[0] = PngEncoderParam;

                        m_oFontTexture.Save(fileSelector.FileName, PngEncoder, pngEncoderParameters);
                        //set pitcure box to bitmap:
                        //m_oTexturePanel.FontPictureBox.ImageLocation = fileSelector.FileName;
                        //m_oTexturePanel.FontPictureBox.Image = m_oFontTexture;

                        // update prop values:
                        m_oFontData.UpdateProportions();

                        // bind Font Class to Controls
                        m_oUVCoordsPanel.DataSource = m_oFontData;
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

            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom12p5_Click(object sender, EventArgs e)
        {
            m_fZoom = 0.125f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom25_Click(object sender, EventArgs e)
        {
            m_fZoom = 0.25f;
            m_oTexturePanel.Repaint();
        }

        private void toolStriZoom50_Click(object sender, EventArgs e)
        {
            m_fZoom = 0.50f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom100_Click(object sender, EventArgs e)
        {
            m_fZoom = 1.0f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom200_Click(object sender, EventArgs e)
        {
            m_fZoom = 2.0f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom400_Click(object sender, EventArgs e)
        {
            m_fZoom = 4.0f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom800_Click(object sender, EventArgs e)
        {
            m_fZoom = 8.0f;
            m_oTexturePanel.Repaint();
        }

        private void toolStripZoom1200_Click(object sender, EventArgs e)
        {
            m_fZoom = 12.0f;
            m_oTexturePanel.Repaint();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelector = new OpenFileDialog();

            fileSelector.Title = "Inport Font Data";
            fileSelector.DefaultExt = "xml";
            fileSelector.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer ser = new XmlSerializer(typeof(Font_Builder.Font));
                FileStream reader = new FileStream(fileSelector.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                // Stream reader = new Stream( //  (fileSelector.FileName);
                m_oFontData = ser.Deserialize(reader) as Font_Builder.Font;
                reader.Close();

                // bind Font Class to Controls:
                m_oUVCoordsPanel.DataSource = m_oFontData;

                // Set Current Directpory to be the Font files location, this allows us to use relative paths:
                Environment.CurrentDirectory = System.IO.Path.GetDirectoryName(fileSelector.FileName);

                // load Image:
                m_oFontTexture = new Bitmap(m_oFontData.Texture);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// When the font selection changes, create a new Font
        /// instance and update the preview text label.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        void FontSelectionChanged()
        {
            try
            {
                // Parse the size selection.
                float size;

                if (!float.TryParse(m_oControlsPanel.SizeComboBox.Text, out size) || (size <= 0))
                {
                    fontError = "Invalid font size '" + m_oControlsPanel.SizeComboBox.Text + "'";
                    return;
                }

                // Parse the font style selection.
                FontStyle style;


                try
                {
                    style = (FontStyle)Enum.Parse(typeof(FontStyle), m_oControlsPanel.StyleComboBox.Text);
                }
                catch
                {
                    fontError = "Invalid font style '" + m_oControlsPanel.StyleComboBox.Text + "'";
                    return;
                }

                // Create the new font.
                System.Drawing.Font newFont = new System.Drawing.Font(m_oControlsPanel.FontComboBox.Text, size, style);

                if (font != null)
                    font.Dispose();

                m_oControlsPanel.SampleLabel.Font = font = newFont;

                fontError = null;
            }
            catch (Exception exception)
            {
                fontError = exception.Message;
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
                if (m_oControlsPanel.AntiAliased)
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

                using (Brush brush = new SolidBrush(m_oControlsPanel.FontColor))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Near;

                    graphics.DrawString(text, font, brush, 0, 0, format);
                }

                graphics.Flush();
            }

            if (m_oControlsPanel.MonoSpace)
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

        private int NextPowOf2(int a_iInput)
        {
            int iPowOf2 = 1;
            while (iPowOf2 < a_iInput)
            {
                iPowOf2 = iPowOf2 << 1;
            }

            return iPowOf2;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Makes a relative path. </summary>
        /// <exception cref="ArgumentNullException">    Thrown when one or more required arguments are
        ///                                             null. </exception>
        /// <param name="fromPath"> Full pathname of from file, the returned path will be relative to this path </param>
        /// <param name="toPath">   Full pathname of to file, this is the path which will be made relative. </param>
        /// <returns> a relative path. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static String MakeRelativePath(String fromPath, String toPath)
        {
            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");

            try
            {
                Uri fromUri = new Uri(fromPath);
                Uri toUri = new Uri(toPath);

                Uri relativeUri = fromUri.MakeRelativeUri(toUri);
                return Uri.UnescapeDataString(relativeUri.ToString());
            }
            catch /*(System.UriFormatException e)*/
            {
                // if there is a format exception in the to or from path then (most likly the to path).
                // then we will assume that the path is already correct.
                return toPath;
            }

            //return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }

        #endregion
    }
}
