using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CompoundGraphic : Graphic
    {
        private List<Graphic> _children = new List<Graphic>();

        public CompoundGraphic():base()
        {
        }
        public void Add(Graphic g)
        {
            Console.WriteLine("ADD");

            _children.Add(g);

        }
        public void Remove(Graphic g)
        {
            Console.WriteLine("REMOVE");

            _children.Remove(g);

        }
        public override void Move(int x, int y)
        {
            Console.WriteLine("MOVE");
        }

        public override void Draw()
        {
            Console.WriteLine("DRAW");

        }

        
    }
}
