using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Rectangle:Shape
    {
        //setwidth has access to Width of Shape
        public void SetWidth(int width)
        {
            Width = width;
        }

        public void SetHeight(int height)
        {
            Height = height;
        }

        //let's override the function GetArea
        public override int GetArea()
        {
            //Console.WriteLine("GetArea is called from Rectangle");
            return Height*Width;
        }

        public void FunctionInRectangleOnly()
        {
            //Console.WriteLine("This function is only in rectangle");
        }

    }
}
