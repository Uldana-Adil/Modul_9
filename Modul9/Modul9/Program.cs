using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    public class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        public Employee(string name, int age, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary:C}");
        }
        public decimal CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Adil Uldana", 30, 50000);

            Console.WriteLine("Employee Information:");
            employee.GetInfo();

            decimal annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Annual Salary: {annualSalary:C}");
        }
    }
}