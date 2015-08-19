using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLanguageFeatures
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int ID) {
            CustomerID = ID;
        }

        public override string ToString() {
            return Name + "\t" + City + "\t" + CustomerID;
        }

    }

    class Program
    {
        static void Main(string[] args) {
            Customer c = new Customer(1);
            c.Name = "Maria Anders";
            c.City = "Berlin";
  

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}


