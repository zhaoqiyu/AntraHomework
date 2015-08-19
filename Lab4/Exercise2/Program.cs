using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        Point p = new Point { X = 3, Y = 99 };

    }

    class Program
    {
        static void Main(string[] args) {
            Customer c = new Customer(1) { Name = "Maria Anders", City = "Berlin" };
            Console.WriteLine(c);




            Console.ReadKey();
        }


        
    }
}
