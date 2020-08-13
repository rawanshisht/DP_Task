using System;
using Composite;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            CompoundGraphic root = new CompoundGraphic();
            root.Add(new Dot(0,0));
            root.Add(new Dot(1,1));
            root.Move(2, 2);

            CompoundGraphic comp = new CompoundGraphic();
            comp.Add(new Dot(3,3));
            comp.Add(new Dot(4,4));
            root.Add(comp);
            root.Add(new Dot(5,5));

            CompoundGraphic circleComp = new CompoundGraphic();
            circleComp.Add(new Circle(3,3, 3));
            circleComp.Draw(); //not draw circle why?

            Dot d = new Dot(6,6);
            root.Add(d);
            root.Remove(d);

        }
    }
}
