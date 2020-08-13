using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Graphic
    {
        public abstract void Move(int x, int y);
        public abstract void Draw();
    }
}
