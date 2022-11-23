using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Wage_Computation_Problem
{
    internal class UC4
    {
        public static void EmpWages()
        {

            //Constant
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 0;
            const int EMP_RATE_PER_HOUR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;

                case IS_PART_TIME:
                    emphrs = 4;
                    break;

                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage Is=" + empwage);
        }
    }
}
