using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Mainclass {

        static  void f(string s)

              {

            s+= "world";

        }

        [STAThread]

        static void Main (string[] args)

                  {

            string s = "Hello";

            f(s);

            Console.WriteLine(s);
            Console.ReadKey();

        }

    }
}

/*The output of this program will still be hello. Since the parameter 
passing into methond f is passed by value, so any change made to it will not influence the original value*/
