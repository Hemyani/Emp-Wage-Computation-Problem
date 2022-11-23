using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Wage_Computation_Problem
{
    internal class UC2
    {
        public static void EmpWage()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int emphr = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                emphr = 8;
            }
            else
            {
                emphr = 0;
            }
            empwage = emphr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage=" + empwage);

        }
    }
}
