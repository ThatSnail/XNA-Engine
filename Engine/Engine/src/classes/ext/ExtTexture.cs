﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
    class ExtTexture
    {
        public static Texture2D CopyTexture(Texture2D src)
        {
            Texture2D tex=new Texture2D(src.GraphicsDevice,src.Width,src.Height);
            Color[] col=new Color[src.Width*src.Height];
            src.GetData<Color>(col);
            tex.SetData<Color>(col);
            return tex;
        }
        public static Texture2D ColorTexture(Texture2D src, Color color)
        {
            Texture2D tex = new Texture2D(src.GraphicsDevice, src.Width, src.Height);
            Color[] col = new Color[src.Width * src.Height];
            tex.GetData<Color>(col);
            for (uint i = 0; i < col.Length; i++)
            {
                col[i] = Color.White * col[i].A;
            }
            tex.SetData<Color>(col);
            return tex;
        }
    }
}
