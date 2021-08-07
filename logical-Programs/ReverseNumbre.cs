using System;
using System.Collections.Generic;
using System.Text;

namespace logical_Programs
{
    class ReverseNumbre
    {
        public static void display()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            for (int i = 0; i < number; i++)
            {
                int lastDigit = number % 10;
                Reverse = (Reverse * 10) + lastDigit;
                number = number / 10;
                
            }
            Console.WriteLine("The reverse number is : " + Reverse);
        }
    }
}
