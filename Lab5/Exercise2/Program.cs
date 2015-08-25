using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class a {
        protected int n=1;
        public a()
        {
            n++;
            Console.WriteLine("n =" +n.ToString());
        }
    }
    class b : a
    {
        public b() {
            n = 10;
            Console.WriteLine("n =" + n.ToString());
        }
    }
    class mainclass {
        [STAThread]
        static void Main(string[] args) {
            a a = new b();
            Console.ReadKey();
        }
    }
}

/* The output of this code will be 
n = 2
n = 10
*/