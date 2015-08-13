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
            for(int i = 1; i < 100; i++)
            {
               if(isPrime(i))
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }

        static bool isPrime(int n)
        {
            if ( n <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
