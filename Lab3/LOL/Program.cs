using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL
{
    class Program
    {
        static void Main(string[] args)
        {
            Wtf haha = new Wtf();
            haha.Kata = 5;
            Console.WriteLine("Kata: {0}", haha.Kata);

            haha.Malz = 10;
            Console.WriteLine("Malz: {0}", haha.Malz);


            haha._Annie(10);
        }
    }
    class Wtf
    {
        public int Kata;
        public int Malz { get; set; }
        private int Lux;
        private int Annie;

        public void _Annie(int a)
        {
            Annie = a;
        }
    }
}
