using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{

    class Program
    {
        static void Main(string[] args) {
            EmployeeTable table = new EmployeeTable();
            Process ps;

            Console.Clear();
            EmployeeTable.Menu();
            for (;;) {
                Console.Write("=>");
                if(Enum.TryParse(Console.ReadLine(), out ps) != true) {
                    Console.WriteLine("Invalid operation, please try again");
                    continue;
                }

                switch (ps) {
                    case Process.Delete:
                        table.Delete();
                        break;

                    case Process.Insert:
                        table.Insert();
                        break;

                    case Process.Update:
                        table.Update();
                        break;

                    case Process.Print:
                        table.Print();
                        break;

                    case Process.Exit:
                        Console.WriteLine("Press any key to terminat the process");
                        Console.ReadKey();
                        return;
                }
            }

        }
    }
}
