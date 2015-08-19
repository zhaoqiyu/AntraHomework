using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args) {
            HouseholdAccounts account = new HouseholdAccounts();
            Process ps;

            Console.Clear();
            HouseholdAccounts.Menu();
            for (;;) {
                Console.Write("=>");
                if (Enum.TryParse(Console.ReadLine(), out ps) != true) {
                    Console.WriteLine("Invalid operation, please try again");
                    continue;
                }

                switch (ps) {
                    case Process.Delete:
                        account.Delete();
                        break;

                    case Process.Insert:
                        account.Insert();
                        break;

                    case Process.Modify:
                        account.Modify();
                        break;

                    case Process.Display:
                        account.Display();
                        break;

                    case Process.Sort:
                        account.Sort();
                        break;
                    case Process.Search:
                        account.Search();
                        break;
                    case Process.Normalize:
                        account.Normalize();
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
