using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;   // Constant
            Random random = new Random(); // Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
