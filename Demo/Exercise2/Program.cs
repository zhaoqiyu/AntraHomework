using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise2
{
    public class Arithmetic
    {
        int a;
        int b;//Variables for +_*%

        //Constructer
        public Arithmetic(int inputA, int inputB)
        {
            a = inputA;
            b = inputB;
        }
        //Arithmetics to calculate +_*% arithmetic and return the result
        public int Addition()
        {
            return a + b;
        }
        public int Subtraction()
        {
            return a - b;
        }
        public int Multiplication()
        {
            return a * b;
        }
        public float Division()
        {
            return (float)a / (float)b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int inputA;
            int inputB; //accept input data
            //int result; //store output data
            string arithmetic;  //decide which arithmetic to use

            //Get input datas
            Console.Write("Please input the first number: ");
            inputA = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease input the second number: ");
            inputB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease input the arithmetic you want to compute: ");
            Console.WriteLine("\nInput A for addition, S for subtraction, D for division, M for multiplication");

            arithmetic = Console.ReadLine();
            
            
            Arithmetic buf = new Arithmetic(inputA, inputB); //Create an instance of Arithmetic
            //Use switch to decide which operation to do
            switch (arithmetic)
            {
                case "A":
                    Console.WriteLine("{0}", buf.Addition());
                    break;
                case "S":
                    Console.WriteLine("{0}", buf.Subtraction());
                    break;
                case "D":
                    Console.WriteLine("{0}", buf.Division());
                    break;
                case "M":
                    Console.WriteLine("{0}", buf.Multiplication());
                    break;
                default:
                    Console.WriteLine("Incorrect input, please try again");
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        
        }
    }
}
