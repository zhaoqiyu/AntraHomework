using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    interface Modify
    {
        void Insert();
        void Update();
        void Delete();
        void Print();
    }

    enum Process
    {
        Insert,
        Update,
        Delete,
        Print,
        Exit
    }

    class EmployeeTableColumn
    {
        public int EmpID { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public string Comm { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
    }
}
