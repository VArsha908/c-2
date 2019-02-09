using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class DeveloperSalary : Employee
    { 
        public override void Salary_Calculate(int Experience)
        {

            int sal2 = 8000 + (2000 * Experience);
            Console.WriteLine("The salary of the HR is:" + sal2);
        }
    }
}
