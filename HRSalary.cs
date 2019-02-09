using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class HRSalary : Employee
    {
        public override void Salary_Calculate(int Experience)
        {

            int sal1 = 8000 + (1000 * Experience);
            Console.WriteLine("The salary of the Developer is:" +sal1);
        }
    }
}
