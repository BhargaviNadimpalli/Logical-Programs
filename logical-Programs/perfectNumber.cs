using System;
using System.Collections.Generic;
using System.Text;

namespace logical_Programs
{
    class perfectNumber
    {
        public static void display()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + "is perfect number");
            }
            else
            {
                Console.WriteLine(number + "is not perfect number");
            }
        }
    }
}
