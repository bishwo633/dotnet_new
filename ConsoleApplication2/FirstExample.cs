using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class FirstExample
    {
        public void RunnableCode()
        {
            //Variable declaration
            List<string> daysList;
            /*
            //other examples of variable declaration
            int x;
            float y;
            string z;
            Dog d;
            */

            //Variable initialization
            /*
            x = 2;
            y = (float) 2.5;
            z = "Test";
            d = new Dog();
            */
            daysList = new List<string>();

            /* ---Commented, kept here for your reference
            //variable declaration and initialization combined
            int x1 = 2;
            float y1 = (float) 2.5;
            string z1 = "Test1";
            Dog d1 = new Dog();
            List<string> daysList2 = new List<string>();
            */

            //Let's add days to daysList
            daysList.Add("Sunday");
            daysList.Add("Monday");
            daysList.Add("Tuesday");
            daysList.Add("Wednesday");
            daysList.Add("Thursday");
            daysList.Add("Friday");
            daysList.Add("Saturday");

            /* --short way of creating array
            var days = new[] {"Sunday", "Monday"};
            */

            //-----------------Loops------------------
            //1. for loop
            Console.WriteLine("Displaying using for loop");
            Console.WriteLine("Total items: " + daysList.Count);
            for (int i = 0; i < daysList.Count; i++)
            {
                Console.WriteLine((i + 1) + " : " + daysList[i]);
            }

            //2. while loop
            Console.WriteLine("Displaying using while loop");
            int j = 0;
            while (j < daysList.Count)
            {
                Console.WriteLine((j + 1) + " : " + daysList[j]);
                j++;
            }

            //3. do-while loop
            Console.WriteLine("Displaying using do-while loop");
            int k = 0;
            do
            {
                Console.WriteLine((k + 1) + " : " + daysList[k]);
                k++;
            } while (k < daysList.Count);

            //4. foreach loop
            Console.WriteLine("Displaying using foreach loop");
            int l = 1;
            foreach (string day in daysList)
            {
                Console.WriteLine(l + ":" + day);
                l++;
            }


            Console.Read();
        }
    }
}
