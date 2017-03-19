using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    //Shape is our base class
    public abstract class Shape
    {
        protected int Height { get; set; }
        protected int Width { get; set; }

        public virtual int GetArea()
        {
            return Height * Width;
        }

        public string Test()
        {
            return "Just for test";
        }

    }
}
