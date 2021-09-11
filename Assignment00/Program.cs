using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            try
            {
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
            catch (FormatException e)
            {
                throw new FormatException("Please write a number");
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            
            
            
        }

        public bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentException("Please write a year later than or equal to 1582");
            }
            else
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
}
