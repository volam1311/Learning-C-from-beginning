using System;
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape { Width= 100, Height = 100 });
            shapes.Add(new Shape { Height= 100, Width= 100 });
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}