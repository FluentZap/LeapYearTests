using System;

namespace LeapYearTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }






    public class LeapYear
    {

        public bool IsLeapYear(int year)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
				if (year % 4 == 0)
				{
					return true;
				}                
            }
            return false;
        }


    }
}
