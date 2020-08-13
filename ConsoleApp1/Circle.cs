using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Circle : Graphic
    {
        public int radius { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Circle(int x, int y, int r)
        {
            x = x;
            y = y;
            radius = r;
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine("Move");
        }

        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
