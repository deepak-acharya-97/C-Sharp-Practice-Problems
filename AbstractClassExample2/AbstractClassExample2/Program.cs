using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseEmployee FTEEmployee = new FullTimeEmployee() {EmployeeId="3062990", EmployeeName="Tilak", EmployeeAddress="#1-46/3 Near Jomlu WaterFalls Road, Hebri, Karnataka,India" };
            Console.WriteLine(FTEEmployee.CalculateSalary(500));
            Console.ReadLine();
        }
        abstract class BaseEmployee
        {
            public string EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeAddress { get; set; }

            abstract public string CalculateSalary(int HoursOfWork);
            
        }
        class FullTimeEmployee : BaseEmployee
        {
            public override string CalculateSalary(int HoursOfWork)
            {
                float salary = HoursOfWork * 20 + 5000;
                return String.Format("The Salary Amount Is {0:N}", salary);
            }
        }
        class ContractEmployee : BaseEmployee
        {
            public override string CalculateSalary(int HoursOfWork)
            {
                double salary = HoursOfWork * 12;
                return String.Format("The Salary Amount Is {0:N}", salary);
            }
        }
    }
}
