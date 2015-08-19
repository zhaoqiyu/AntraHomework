using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Account
    {
        public int Number { get; set; }
        public int Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Amount { get; set; }
    }
    enum Process
    {
        Insert,
        Display,
        Search,
        Delete,
        Modify,
        Normalize,
        Sort,
        Exit
    }

    class HouseholdAccounts
    {

        List<Account> table = new List<Account>();

        public static void Menu() {
            string[] items = Enum.GetNames(typeof(Process));
            Console.WriteLine("Select Any option");
            for (int i = 0; i < items.Length; i++) {
                Console.WriteLine(items[i]);

            }

        }

        

        //constructor
        public void Insert ()
        {
            int Date;
            string Descr;
            string Cate;
            int Amount;

            //Add a new row
            Account row = new Account();

            begin:

            Console.WriteLine("Please enter the date of transaction: ");
            Date = Convert.ToInt32(Console.ReadLine());
            
            //Check if the input date is valid
            if (!CheckValidDate(Date))
            {
                Console.WriteLine("Invalid date input, try again...");
                goto begin;
            }
            //Check if the description is empty

            second:
            Console.WriteLine("Please enter the descripition of transaction: ");
            Descr = Console.ReadLine();

            if (Descr.Length == 0)
            {
                Console.WriteLine("Description cannot be empty, try again...");
                goto second;
            }

            Console.WriteLine("Please enter the category of transaction: ");
            Cate = Console.ReadLine();

            Console.WriteLine("Please enter the amount of transaction: ");
            Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of transaction: ");
            row.Number = Convert.ToInt32(Console.ReadLine());

            row.Date = Date;
            row.Description = Descr;
            row.Category = Cate;
            row.Amount = Amount;
            table.Add(row);

            Console.WriteLine("New statement created successfully!");
        }

        //Display
        public void Display() {
            int sDate;
            int lDate;
            int count = 0;

            begin:
            Console.WriteLine("Please enter the starting date: ");
            sDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the ending date: ");
            lDate = Convert.ToInt32(Console.ReadLine());

            if (!CheckValidDate(sDate) || !CheckValidDate(lDate)) {
                Console.WriteLine("Invalid date input, try again...");
                goto begin;

            }
            if(sDate >= lDate) {
                Console.WriteLine("Ending date eralier than starting date, try again...");
                goto begin; 
            }

            
            Console.WriteLine("Number \t Date \t Deascription \t Category \t Amount");

            foreach (Account row in table) {
                if (row.Date > sDate && row.Date < lDate) {

                    Console.WriteLine("{0} \t ({1}) \t ({2}) \t ({3}) \t {4}", row.Number, row.Date, row.Description, row.Category, row.Amount.ToString("f2") );
                    count++;
                }
            }
            Console.WriteLine("{0} records founded.", count);
        }

        public void Search() {
            string text;
            

            Console.WriteLine("Please enter the string to looking for.");
            text = Console.ReadLine().ToLower();

            Console.WriteLine("Number \t Date \t Deascription \t Category \t Amount");
            foreach (Account row in table) {
                if (row.Description.ToLower().IndexOf(text) != -1) {
                    Console.WriteLine("{0} \t ({1}) \t ({2}) \t ({3}) \t {4}", row.Number, row.Date, row.Description, row.Category, row.Amount.ToString("f2"));

                } else if (row.Category.ToLower().IndexOf(text) != -1) {
                     
                    Console.WriteLine("{0} \t ({1}) \t ({2}) \t ({3}) \t {4}", row.Number, row.Date, row.Description, row.Category, row.Amount.ToString("f2"));
                    
                }
            }
        }
        
        public void Modify() {
            int choise;
            Console.WriteLine("Please enter the number of row to modify: ");
            choise = Convert.ToInt32(Console.ReadLine());

            Account[] _table = table.ToArray();

            foreach(Account row in _table) {
                if(row.Number == choise) {
                    Console.WriteLine("Please enter jthe values you want to input there");
                    int Number = row.Number;
                    table.Remove(row);

                    int Date;
                    string Descr;
                    string Cate;
                    int Amount;

                    begin:

                    Console.WriteLine("Please enter the date of transaction: ");
                    Date = Convert.ToInt32(Console.ReadLine());

                    //Check if the input date is valid
                    if (!CheckValidDate(Date)) {
                        Console.WriteLine("Invalid date input, try again...");
                        goto begin;
                    }
                    //Check if the description is empty

                    second:
                    Console.WriteLine("Please enter the descripition of transaction: ");
                    Descr = Console.ReadLine();

                    if (Descr.Length == 0) {
                        Console.WriteLine("Description cannot be empty, try again...");
                        goto second;
                    }

                    Console.WriteLine("Please enter the category of transaction: ");
                    Cate = Console.ReadLine();

                    Console.WriteLine("Please enter the amount of transaction: ");
                    Amount = Convert.ToInt32(Console.ReadLine());

                    row.Date = Date;
                    row.Description = Descr;
                    row.Category = Cate;
                    row.Amount = Amount;
                    table.Add(row);

                }
            }            
        }

        public void Delete() {
            int number;
            Console.WriteLine("Please enter the number of row you want to delete: ");
            number = Convert.ToInt32(Console.ReadLine());
            foreach (Account row in table) {
                if (row.Number == number) {
                    Console.WriteLine("This row of data will be deleted: ");
                    Console.WriteLine("{0} \t ({1}) \t ({2}) \t ({3}) \t {4}", row.Number, row.Date, row.Description, row.Category, row.Amount.ToString("f2"));
                }
                table.Remove(row);
            }
        }

        public void Sort() {
            table.Sort(new RowCompare());

        }
        

        public void Normalize() {
            Console.WriteLine("The Descripitions of this account will be normalized");
            foreach(Account row in table) {
                row.Description = row.Description.Trim();
                if (IsAllUpper(row.Description)) {
                    row.Description = row.Description.ToLower();
                    char[] a = row.Description.ToCharArray();
                    a[0] = char.ToUpper(a[0]);
                    row.Description = new string(a);
                }
            }
        }

        //Method to check if a string is fully Upcases;
        bool IsAllUpper(string input) {
            for (int i = 0; i < input.Length; i++) {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

        //Method to check if the input data is valid;
        private bool CheckValidDate(int Date)
        {
            int year;
            int month;
            int day;
            //Get year, month and day
            year = Date / 10000;
            month = (Date % 10000) / 100;
            day = Date % 100;

            //Check validity
            if ((year > 1000) && (year < 3000))
            {
                if ((month >= 01) && (month <= 12))
                {
                    if ((day >= 01) && (day <= 31))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }


    //Implimentation of Comaprer interface.
    class RowCompare : IComparer<Account>
    {
        public int Compare(Account x, Account y) {
            if (x.Date > y.Date) {
                return 1;
            } else if (x.Date < y.Date) {
                return -1;
            } else {
                return x.Description.CompareTo(y.Description);
            }

        }
    }
}



    

