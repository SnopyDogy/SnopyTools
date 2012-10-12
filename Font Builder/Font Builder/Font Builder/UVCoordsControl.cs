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
    public partial class UVCoordsControl : DockContent
    {

        #region Properties

        public ListBox UVCoordsListBox
        {
            get
            {
                return m_oUVCoordsListBox;
            }
        }

        public Font DataSource
        {
            set
            {
                m_oUVCoordsListBox.DataSource = value.Characters;
                m_oUVCoordPropertyGrid.SelectedObject = m_oUVCoordsListBox.SelectedItem;
            }
        }


        public PropertyGrid UVCoordPropertyGrid
        {
            get
            {
                return m_oUVCoordPropertyGrid;
            }
        }

        public object SelectedUVCoord
        {
            get
            {
                return m_oUVCoordsListBox.SelectedItem; // We always pull from the selected item box for our selected property.
            }
            set
            {
                // set in both the list box and the prioperty grid:
                m_oUVCoordPropertyGrid.SelectedObject = value;
                m_oUVCoordsListBox.SelectedItem = value;
            }
        }

        #endregion


        public UVCoordsControl()
        {
            InitializeComponent();
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
            {
                this.AllowEndUserDocking = false;
            }
        }

        private void m_oUVCoordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_oUVCoordPropertyGrid.SelectedObject = m_oUVCoordsListBox.SelectedItem;
        }
    }
}
