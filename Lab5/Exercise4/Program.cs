using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise4
{
    /*Exercise 4 
    *the output of this code shoulb be
    *n =2
    *n =3
    *Because int n is a static member in the class
    */

    /*Exercise 5
    *the output of this code would be
    *begin
    *begin
    *end
    *end
    */

    /*Exercise 6
    *The using statement in the second example will ensure that the
    *connection is altumatically closed as soon as the program is get ou of
    *the using block. But in the first example the connection will not be 
    *closed until the method is returned.
    */
    

    //Exercise 7

    class Program
    {
        static void Main() {
            double input = Convert.ToDouble(Console.ReadLine());
            int output = (int)(input + 0.5);
            Console.WriteLine("The output of Round is : {0}", output);
        }
    }

    
    /*Exercise 8
    * AS operator can only used to convert object and this object should be
    *nullable. but int is neither an object nor nullable. So en error occoured
    *there
    */

    /*Exercise 9
    *we can use lambda expression or LINQ to specify what to compare in the array.
    *Then we can sort it.
    */
   
}

