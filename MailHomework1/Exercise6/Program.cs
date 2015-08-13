using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args) {
            string input;
            char[] buf;
            int value;
            int len;
            int sum = 0;
            Console.WriteLine("Please enter the input number: ");
            input = Console.ReadLine();
            len = input.Length;
            buf = input.ToCharArray();
            value = Convert.ToInt32(input);


            for(int i = 0; i < len; i++) {
                int temp = (int)Char.GetNumericValue(buf[i]);
                
                sum += temp * temp * temp;
            }
            
            if(sum == value) {
                Console.WriteLine("This is an Armstrong number");
            } else {
                Console.WriteLine("This is NOT an Armstrong number");
            }
            Console.ReadKey();

        }
    }
}
