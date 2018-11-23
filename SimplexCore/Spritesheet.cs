﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace SimplexCore
{
    public class Spritesheet
    {
        public string Name { get; set; }
        public int CellWidth { get; set; }
        public int CellHeight { get; set; }
        public int Rows { get; set; }
        public Texture2D Texture { get; set; }
    }
}