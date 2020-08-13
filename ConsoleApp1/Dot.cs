using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Dot : Graphic
    {
        public int x { get; set; }
        public int y { get; set; }

        public Dot(int x, int y)
        {
            x = x;
            y = y;
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine("move");
        }

        public override void Draw()
        {
            Console.WriteLine("draw");
        }
    }
}
