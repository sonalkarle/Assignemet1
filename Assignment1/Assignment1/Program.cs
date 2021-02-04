using System;

namespace EmpWage
{
    class Program
    {


        public const int IS_PART_TIME = 1;   // Constant
        public const int IS_FULL_TIME = 2;   //Constant
        public const int EMP_HR_PER_RATE = 20;       //Constant
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(String[] args)
        {
            int empHr = 0;            //Variable
            int empwage = 0;          //Variable
            int totalEmpwage = 0;  //Variable
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random(); // Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                empwage = (EMP_HR_PER_RATE * empHr);
                totalEmpwage += empwage;
                Console.WriteLine("Daily employee wage: " + empwage);
            }
            Console.WriteLine("Total Emp Wage: " + totalEmpwage);
        }

    }
}
