using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";

            Employee emp1= new Employee();
            Employee emp2= new Employee();
            Employee emp3= new Employee();
            Employee emp4= new Employee();

            emp1.empId = 101;
            emp1.empName = "saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "B";

            emp2.empId = 102;
            emp2.empName = "peter";
            emp2.empSalary = 7000;
            emp2.empPerformance = "A";

            emp3.empId = 103;
            emp3.empName = "kim";
            emp3.empSalary = 4000;
            emp3.empPerformance = "c";

            Console.WriteLine(emp1.empId);
            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp3.empId);

            emp1.AllocateBonus();
            emp2.AllocateBonus();
            emp3.AllocateBonus();

            emp1.DisplayEployeeDetail();
            emp2.DisplayEployeeDetail();
            emp3.DisplayEployeeDetail();




        }
    }
}
