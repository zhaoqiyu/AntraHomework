
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

    }
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My Age is {0} years old.", age);
        }

    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

    }

    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Student s1 = new Student();
            Teacher t1 = new Teacher();
            p1.Greet();
            s1.SetAge(21);
            s1.Greet();
            s1.ShowAge();
            t1.SetAge(30);
            t1.Greet();
            t1.Explain();

            Console.ReadKey();
        }
    }
}
