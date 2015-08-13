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
            int Base;
            int Power;
            int temp;
            Console.WriteLine("Please enter the base value: ");
            Base = Convert.ToInt32(Console.ReadLine());
            temp = Base;
            Console.WriteLine("Please enter the power value: ");
            Power = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < Power; i++) {
                temp *= Base;
            }

            Console.WriteLine("Output is : {0}", temp);
            Console.ReadKey();

        }
    }
}
