using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();

            if (p.IsLeapYear(inputYear))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }

        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            } 
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
