using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class EmployeeTable : Modify
    {
        private List<EmployeeTableColumn> table = new List<EmployeeTableColumn>(); 

        public void Delete() {
            int id;
            int count = 0;
            Console.WriteLine("Enter the Employee ID to delete: ");
            id = Convert.ToInt32(Console.ReadLine());
            EmployeeTableColumn[] tableArray;
            tableArray = table.ToArray();
            foreach (EmployeeTableColumn row in tableArray ) {
                if(row.EmpID == id) {
                    table.Remove(row);
                    count++;
                }
            }
            Console.WriteLine("{0} row is removed!", count);
        }


        public void Insert() {
            int id, sal, dept;
            string name, job, comm;
            EmployeeTableColumn row = new EmployeeTableColumn();
            Console.WriteLine("Enter the ID of employee: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of employee: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the job of employee: ");
            job = Console.ReadLine();
            Console.WriteLine("Enter the comm of employee: ");
            comm = Console.ReadLine();
            Console.WriteLine("Enter the salary of employee: ");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the department number of employee: ");
            dept = Convert.ToInt32(Console.ReadLine());


            row.EmpID = id;
            row.Ename = name;
            row.Job = job;
            row.Salary = sal;
            row.Comm = comm;
            row.DeptNo = dept;
            table.Add(row);
        }

        public void Print() {
            Console.WriteLine("ID \t Name \t Job \t Comm \t Salary \t DepartmentNumber");

            foreach (EmployeeTableColumn row in table) {

                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", row.EmpID, row.Ename, row.Job, row.Comm, row.Salary, row.DeptNo);
            }
        }

        public void Update() {
            int id, sal, dept;
            string name, job, comm;
            Console.WriteLine("Enter the Employee ID to update: ");
            id = Convert.ToInt32(Console.ReadLine());
            EmployeeTableColumn[] tableArray;
            tableArray = table.ToArray();

            foreach (EmployeeTableColumn row in tableArray) {
                if (row.EmpID == id) {
                    Console.WriteLine("Enter the name of employee: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the job of employee: ");
                    job = Console.ReadLine();
                    Console.WriteLine("Enter the comm of employee: ");
                    comm = Console.ReadLine();
                    Console.WriteLine("Enter the salary of employee: ");
                    sal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the department number of employee: ");
                    dept = Convert.ToInt32(Console.ReadLine());
               
                    row.Ename = name;
                    row.Job = job;
                    row.Salary = sal;
                    row.Comm = comm;
                    row.DeptNo = dept;
                }
            }
        }

        public static void Menu() {
            string[] items = Enum.GetNames(typeof(Process));
            Console.WriteLine("Select Any option");
            for (int i = 0; i < items.Length; i++) {
                Console.WriteLine(items[i]);

            }

        }
    }
}
