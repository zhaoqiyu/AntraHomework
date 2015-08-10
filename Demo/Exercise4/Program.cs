using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowBound;
            int upBound;

            int dig1 = 0;
            int dig2 = 0;
            int dig3 = 0;
            int dig4 = 0;

            //Get input value
            Console.WriteLine("Please enter first number: ");
            lowBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter sencond number: ");
            upBound = Convert.ToInt32(Console.ReadLine());
            //Check the validity of input
            if((lowBound > upBound) || (upBound > 9999))
            {
                Console.WriteLine("Please input value smaller than 9999 and first number should smaller than second one");
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
                return;
            }
            //Find Armstrong value

            Console.WriteLine("Armstrong Values are: ");
            for(int i = lowBound; i <= upBound; i++)
            {   
                //Get each digits
                dig1 = i % 10;
                dig2 = (i % 100) / 10;
                dig3 = (i % 1000) / 100;
                dig4 = i / 1000;

                //Judge if this is a armstrong value
                if ((int)(Math.Pow(dig1,3) + Math.Pow(dig2, 3) + Math.Pow(dig3, 3) + Math.Pow(dig4, 3)) == i)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            //Hold the result
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
