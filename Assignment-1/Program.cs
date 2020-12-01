using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Neha" ,10002,10);
            Console.WriteLine(emp.EMPNO);
            Console.WriteLine(emp.NAME);
            Console.WriteLine(emp.BASIC);
            Console.WriteLine(emp.GetNetSalary());
            Console.WriteLine(emp.DEPTNO);
          
            Employee emp1 = new Employee("Amrita",10000, 20);
            Console.WriteLine(emp1.EMPNO);
            Console.WriteLine(emp1.NAME);
            Console.WriteLine(emp1.BASIC);
            Console.WriteLine(emp1.GetNetSalary());
            Console.WriteLine(emp.DEPTNO);

            Employee emp2 = new Employee("janvi",30000,30);
            Console.WriteLine(emp2.EMPNO);
            Console.WriteLine(emp2.NAME);
            Console.WriteLine(emp1.BASIC);
            Console.WriteLine(emp1.GetNetSalary());

            Console.WriteLine(emp2.EMPNO);
            Console.WriteLine(emp1.EMPNO);
            Console.WriteLine(emp.EMPNO);
        }
    }
    public class Employee
    {
        #region PROPERTIES

        //read only access
        public int empNo;
        public int EMPNO
        {
            get
            {
                return empNo;
            }

        }

        private string name;
        public string NAME
        {
            set { 
                if (value == " ")
                    Console.WriteLine("Invalid Name");
                else
                    name = value;
            }
            get {return name;}
        }

        private decimal basic;
        public decimal BASIC
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }
        private int deptNo;
        public int DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
            }
            get
            {
                return deptNo;
            }
        }
        #endregion

        private static int no = 0;
        public Employee(string name=null, decimal basic=0 , int deptno=0)
        {
            no++;
            empNo = no;
            NAME = name;
            BASIC = basic;
            DEPTNO = deptno;
        }
        public decimal GetNetSalary()
        {
            decimal salary;
            if (BASIC > 0 && BASIC <= 10000)
            {
                salary = BASIC + (BASIC * 20) / 100;
                return salary;
            }
            else if(BASIC > 10001 && BASIC <= 20000 )
            {
                salary = BASIC + (BASIC * 25) / 100;
                return salary;
            }
            else
            {
                salary = BASIC + (BASIC * 30) / 100;
                return salary;
            }
        }
    }
}
