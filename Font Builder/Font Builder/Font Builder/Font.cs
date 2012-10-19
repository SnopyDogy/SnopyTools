using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Font_Builder
{
    public class Font
    {
        [XmlAttribute("texture")]
        public string Texture { get; set; }

        private BindingList<Character> m_lChars = new BindingList<Character>();

        [XmlElement("Character")]
        public BindingList<Character> Characters 
        {
            get
            {
                return m_lChars;
            }
        }

        public Font()
        {
        }

        public void ConvertUVCoords(int width, int height)
        {
            foreach (Character Char in m_lChars)
            {
                Char.Umin = Char.Umin / width;
                Char.Umax = Char.Umax / width;
                Char.Vmin = Char.Vmin / height;
                Char.Vmax = Char.Vmax / height;
            }
        }

        public void UpdateProportions()
        {
            // first find the space character:
            Character oSpace = null;
            foreach (Character Char in m_lChars)
            {
                if (Char.Char == " ")
                {
                    oSpace = Char;
                    break;
                }
            }

            // make space's prop. values = 1:
            oSpace.XProportion = 1.0f;
            oSpace.YProportion = 1.0f;

            // create working vars:
            float fSpaceWidth = oSpace.Umax - oSpace.Umin;
            float fSpaceHeight = oSpace.Vmax - oSpace.Vmin;

            // now go though the list and update the proportional Values:
            foreach (Character Char in m_lChars)
            {
                // skip space:
                if (Char == oSpace)
                {
                    continue;
                }

                // update values:
                Char.XProportion = (Char.Umax - Char.Umin) / fSpaceWidth;
                Char.YProportion = (Char.Vmax - Char.Vmin) / fSpaceHeight;
            }
        }
    }

    public class Character
    {
        [XmlAttribute("Umin"),
        Category("Coords"),
        Description("The Minium U Value"),
        Browsable(true),
        ReadOnly(false)]
        public float Umin { get; set; }

        [XmlAttribute("Umax"),
        Category("Coords"),
        Description("The Maximum U Value"),
        Browsable(true),
        ReadOnly(false)]
        public float Umax { get; set; }

        [XmlAttribute("Vmin"),
        Category("Coords"),
        Description("The Minium V Value"),
        Browsable(true),
        ReadOnly(false)]
        public float Vmin { get; set; }

        [XmlAttribute("Vmax"),
        Category("Coords"),
        Description("The Maximum V Value"),
        Browsable(true),
        ReadOnly(false)]
        public float Vmax { get; set; }

        [XmlAttribute("Char"),
        Category("Character"),
        Description("The character enclosed by these UV coords"),
        Browsable(true),
        ReadOnly(false)]
        public string Char { get; set; }

        [XmlAttribute("XProportion"),
        Category("Proportions"),
        Description("The size of this character in X porportional to the Space character. Space will always be 1"),
        Browsable(true),
        ReadOnly(true)]
        public float XProportion { get; set; }

        [XmlAttribute("YProportion"),
        Category("Proportions"),
        Description("The size of this character in Y porportional to the Space character. Space will always be 1"),
        Browsable(true),
        ReadOnly(true)]
        public float YProportion { get; set; }

        public Character()
        {
        }

        override public string ToString()
        {
            return Char.ToString() + ": (" + Umin.ToString() + ", " + Umax.ToString() + ") (" + Vmin.ToString() + ", " + Vmax.ToString() + ")";
        }
    }
}
