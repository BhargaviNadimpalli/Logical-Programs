using System;
using System.Collections.Generic;
using System.Text;

namespace logical_Programs
{
    class StopWatch
    {
        public static void display()
        {
            
            string start = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine("enter the starting time : "+ start);
            Console.WriteLine("press any key to stop time");
            Console.Read();
            
            string end = DateTime.Now.ToString(Console.ReadLine());
            Console.WriteLine("Enter the ending time : " + end);

            TimeSpan elapsed = DateTime.Parse(end).Subtract(DateTime.Parse(start));
            Console.WriteLine("The elapsed time is : " + elapsed);
        }
        }
}
