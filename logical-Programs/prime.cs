using System;
using System.Collections.Generic;
using System.Text;

namespace logical_Programs
{
    class prime
    {
        public static void display()
        {
           
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + "Is not prime number");
                   
                    break;
                }
                if (flag == 0)
                {
                    Console.WriteLine(number + "Is prime number");
                    break;
                }
            }
        }
            }
}
