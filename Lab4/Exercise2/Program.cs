﻿using System;
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
    public class Customer
    {
        public string CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int ID) {
            CustomerID = ID.ToString();
        }

        public override string ToString() {
            return Name + "\t" + City + "\t" + CustomerID;
        }
    }




    class Program
    {
        static void Main(string[] args) {
            List<Customer> customers = CreateCustomers();

            Console.WriteLine("Customers:\n");
            foreach (Customer c in customers)
                Console.WriteLine(c);
        }

        static List<Customer> CreateCustomers() {
            return new List<Customer> {
            new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
            new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
            new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
            new Customer(4) { Name = "Ann Devon",        City = "London"    },
            new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
            new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
            new Customer(7) { Name = "Simon Crowther",   City = "London"    },
            new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
            };
        }
    }
}
        
    
        

    

