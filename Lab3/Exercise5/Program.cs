using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise5
{ 
    class ComplexNumber
    {
        public int real { get;  set; }
        public int imagin { get; set; }

        public ComplexNumber(int Real, int Imagin)
        {
            real = Real;
            imagin = Imagin;
        }
        public override string ToString()
        {
            string a;
            string b;

            a = Convert.ToString(real);
            b = Convert.ToString(imagin);

            return ("(" + a + "," + b + ")");
        }
        public double GetMagnitude()
        {
            return (Math.Sqrt(real * real + imagin * imagin));
        }
        public void Add (ComplexNumber c1)
        {
            this.real = this.real + c1.real;
            this.imagin = this.imagin + c1.imagin;
            
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.imagin = -3;
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    }
}
