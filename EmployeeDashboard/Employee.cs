using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public  class Employee
    {
        private int empId;
        public string empName;
        public double empSalary;
        public string empPerformance;
        public  static string companyName;

        private int EmpId
        {
            get
            {
                return empId;

            }
            set
            {
                if (value > 100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine("Currently employee id is  0 Please provide value more than 100");
                }
            }
        }
        public string EmpPerf
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C")) ;
                {
                    empPerformance = value;
                }
                {
                    Console.WriteLine("Performance value should be A, B or C");
                }
            }
        }


        public void DisplayEployeeDetail()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine( "Employee Name: " + empName);
            Console.WriteLine( "Employee salary: " + empSalary);
            Console.WriteLine( "Employee Perfomance: " + empPerformance);
            Console.WriteLine( " Company Name: " + Employee.companyName);
            Console.WriteLine("------------------------");
        }
        
    public void AllocateBonus()
        {
            if (empPerformance != null) 
            {
                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else if (empPerformance.Equals("C"))
                {
                    empSalary = empSalary + 100;
                }
            }
           
        }





    }
}
