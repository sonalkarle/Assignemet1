using System;

namespace EmpWage
{
    class Program
    {


        public const int IS_PART_TIME = 1;   // Constant
        public const int IS_FULL_TIME = 2;   //Constant
        public const int EMP_HR_PER_RATE = 20;       //Constant
        public const int NUM_OF_WORKING_DAYS = 2; //Constant
        public const int MAX_HR_MONTH = 10; //Constant
        static void Main(String[] args)
        {
            int empHr = 0;            //Variable
            int totalEmpHr = 0;          //Variable
            int totalworkingDays = 0;  //Variable
            while (totalEmpHr <= MAX_HR_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS)
            {
                totalworkingDays++;
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

                totalEmpHr += empHr;
                Console.WriteLine("Day= " + totalworkingDays + "EmpHRS= " + empHr);
            }
            int totalEmpwage = (EMP_HR_PER_RATE * empHr);
            Console.WriteLine("Total Emp Wage: " + totalEmpwage);
        }

    }
}
