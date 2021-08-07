using System;
using System.Collections.Generic;
using System.Text;

namespace logical_Programs
{
    class CouponNumber
    {
        public static void display()
        {
            Random rand = new Random();

            int noOfRandomValues = 10;

            int[] arr = new int[noOfRandomValues];

            for (int i = 0; i < noOfRandomValues; i++)

            {
                arr[i] = rand.Next(1, 100);
                Console.WriteLine("random number is : " + arr[i]);
            }

            Console.WriteLine("Enter the number :");

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {

                if (arr[i] == number)
                {
                    Console.WriteLine("The coupon number is :" + i);
                }

            }


        }
    }
}
        
