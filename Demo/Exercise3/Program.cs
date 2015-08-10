using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input string
            Console.WriteLine("Please enter the string you want to reverse");
            string str = Console.ReadLine();
            Console.WriteLine("Reversed String: ");
            //Reversly output
            for(int i = (str.Length - 1); i >= 0; i--)
            {
                Console.Write("{0}", str[i]);
            }
            //Hold the result
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
