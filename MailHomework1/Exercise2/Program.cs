using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter the number n: ");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; (i* i < number); i++)
            {
                Console.WriteLine("{0}", i * i);
            }

            Console.ReadKey();
        }
    }
}
