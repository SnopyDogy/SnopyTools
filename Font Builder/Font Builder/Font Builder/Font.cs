using System;
using System.Collections.Generic;
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

        private List<Character> m_lChars = new List<Character>();

        [XmlElement("Character")]
        public List<Character> Characters 
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
        [XmlAttribute("Umin")]
        public float Umin { get; set; }

        [XmlAttribute("Umax")]
        public float Umax { get; set; }

        [XmlAttribute("Vmin")]
        public float Vmin { get; set; }

        [XmlAttribute("Vmax")]
        public float Vmax { get; set; }

        [XmlAttribute("Char")]
        public string Char { get; set; }

        public Character()
        {
        }
    }
}
