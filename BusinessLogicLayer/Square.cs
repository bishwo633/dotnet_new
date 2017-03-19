using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Square:Shape
    {
        public void SetLength(int length)
        {
            Height = length;
            Width = length;
        }

        public void FunctionInSquareOnly()
        {
            Console.WriteLine("This function is in square only");
        }
    }
}
