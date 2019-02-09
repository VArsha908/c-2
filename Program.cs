using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Employee
{
    class Program
    {


        public static void Main(string[] args)
        {
            HRSalary sal1 = new HRSalary();
            DeveloperSalary sal2 = new DeveloperSalary();

            Console.WriteLine("Enter the Designation:");
            string Designation = Console.ReadLine();

            if (Designation == "HR")
            {
                Console.WriteLine("Enter the Experience:");
                sal1.Experience = int.Parse(Console.ReadLine());
                sal1.Salary_Calculate(sal1.Experience);
            }
            else if (Designation == "Developer")
            {
                Console.WriteLine("Enter the Experience:");
                sal2.Experience = int.Parse(Console.ReadLine());
                sal2.Salary_Calculate(sal2.Experience);
            }
            else
            {
                Console.WriteLine("The Salary of the Employee is: 8000");
            }

        }

    }
}
