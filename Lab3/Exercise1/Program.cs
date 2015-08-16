using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

    }
    //first sub class of shape1
    class Rectangle : Shape1
    {
        public void setRectangle(float len, float bre)
        {
            L = len;
            B = bre;
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }
    //Second sub class of shape1
    class Circle : Shape1
    {
        public void setCircle(float rad)
        {
            R = rad;
        }
        public override float Area()
        {
            return (float)Math.PI * R * R;
        }
        public override float Circumference()
        {
            return 2 * (float)Math.PI * R;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ret = new Rectangle();
            Circle cir = new Circle();

            float len, bre, rad;
            //Get input data and setup the value in object
            //Then calculate and diplay result using calculate method
            Console.Write("Please enter the Length: ");
            len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Breath: ");
            bre = Convert.ToInt32(Console.ReadLine());
            ret.setRectangle(len, bre);
            Calculate(ret);

            Console.Write("Please enter the Radius: ");
            rad = Convert.ToInt32(Console.ReadLine());
            cir.setCircle(rad);
            Calculate(cir);

            Console.ReadKey();
        }
        //Method used to calcualte and display the results
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }
    }
}



