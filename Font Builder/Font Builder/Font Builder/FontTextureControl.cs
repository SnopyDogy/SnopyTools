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
    public partial class FontTextureControl : DockContent
    {

        public PictureBox FontPictureBox
        {
            get
            {
                return m_oFontPictureBox;
            }
        }

        //public Panel FontPaintPanel
        //{
        //    get
        //    {
        //        return m_oPaintPanel;
        //    }
        //}


        public FontTextureControl()
        {
            InitializeComponent();
        }


        public void Repaint()
        {
            //m_oPaintPanel.Invalidate();
            m_oFontPictureBox.Invalidate();
        }
    }
}
