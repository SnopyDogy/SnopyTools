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

        public Character()
        {
        }

        override public string ToString()
        {
            return Char.ToString() + ": (" + Umin.ToString() + ", " + Umax.ToString() + ") (" + Vmin.ToString() + ", " + Vmax.ToString() + ")";
        }
    }
}
