using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;   // Constant
            int EMP_HR_PER_RATE = 20;       //Constant
            int empHr = 0;            //Variable
            int empwage = 0;          //Variable
            Random random = new Random(); // Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
                empHr = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr = 0;
            }
            empwage = (EMP_HR_PER_RATE * empHr);
            Console.WriteLine("Daily employee wage: " + empwage);

        }
    }
}
