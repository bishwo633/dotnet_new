using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace ConsoleApplication2
{
    class Program
    {
        public class Dog
        {
            //details not filled in for sake of simplicity
        }
        static void Main(string[] args)
        {
            //1. Simple inheritance
            /*
            Rectangle r = new Rectangle();
            r.Height = 10;
            r.Width = 15;
            int area = r.GetArea();
            Console.WriteLine("Area of rectangle is: " + area);

            Square s = new Square();
            s.Height = 10;
            s.Width = 10;
            int areaOfSquare = s.GetArea();
            Console.WriteLine("Area of square is: " + areaOfSquare);

            //Is the following possible? ==> Yes
            Shape shape = new Shape();
            shape.Height = 100;
            shape.Width = 200;
            int areaOfShape = shape.GetArea();
            Console.WriteLine("Area of shape is: " + areaOfShape);
            */

            Rectangle r = new Rectangle();
            r.SetWidth(10);
            r.SetHeight(15);
            int area = r.GetArea();
            Console.WriteLine("Area of rectangle is: " + area);
            r.FunctionInRectangleOnly();

            Square s = new Square();
            s.SetLength(10);
            int areaOfSquare = s.GetArea();
            Console.WriteLine("Area of square is: " + areaOfSquare);
            s.FunctionInSquareOnly();

            Console.Read();
        }
    }
}
