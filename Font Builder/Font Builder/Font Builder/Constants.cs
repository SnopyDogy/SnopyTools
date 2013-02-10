using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Font_Builder
{
    [Serializable]
    public enum UV_COORDS_SYSTEMS
    {
        OPENGL = 1,
        DIRECTX = 2
    }  // Font_Builder.UV_COORDS_SYSTEMS

    [Serializable]
    public enum BITMAP_WIDTH_CAP_STYLE
    {
        CAP_BY_NO_OF_CHARS = 1,
        CAP_BY_NO_OF_PIXELS = 2
    }  // Font_Builder.BITMAP_WIDTH_CAP_STYLE

    static public class Constants
    {
        
    }
}
