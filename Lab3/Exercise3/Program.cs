using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class HouseholdAccounts
    {
        protected int date;
        protected string description;
        protected string categoty;
        protected int amount;

        //constructor
        public HouseholdAccounts(int Date, string Descr, string Cate, int Amount)
        {
            //Check if the input date is valid
            if (!CheckValidDate(Date))
            {
                Console.WriteLine("Invalid date input, aborting...");
                return;
            }
            //Check if the description is empty
            if (Descr.Length == 0)
            {
                Console.WriteLine("Description cannot be empty, aborting...");
                return;
            }
            this.date = Date;
            this.description = Descr;
            this.categoty = Cate;
            this.amount = Amount;
            Console.WriteLine("New statement created successfully!");
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

		

		//
    }

class dad{
	static abstract void  print();

	}
class son : dad{
	static override void print(){
		Console.Writeline
		}
}

    class Program
    {
        static void Main(string[] args)
        {
       
        }
    }
}
