﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public enum ShapeType
    {
        Circle,
        Rectangle
    }
    public enum Position
    {
        X,
        Y
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }
    }
}
