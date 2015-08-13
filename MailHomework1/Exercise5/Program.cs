using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args) {
            string origin;
            string reverse;
            

            Console.WriteLine("Please enter the number for check: ");
            origin = Console.ReadLine();

            char[] buf = origin.ToCharArray();
            Array.Reverse(buf);
            reverse = new string(buf);
            

            if (origin == reverse) {
                Console.WriteLine("This is palindrome number");
            } else {
                Console.WriteLine("This is NOT palindrome number");
            }
            Console.ReadKey();

        }
    }
}
