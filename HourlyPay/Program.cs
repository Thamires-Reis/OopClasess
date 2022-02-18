using System;

namespace HourlyPay
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hourly pay rate ");
            double hourly = double.Parse(Console.ReadLine());
            if (hourly == 7.5)
            {
                Console.WriteLine("The hourly pay rate is correct:");
            }

            else if (hourly > 49)
            {
                Console.WriteLine("Incorrect rate");
            }
            if (hourly < 7.5)
            {
                Console.WriteLine("Incorrect rate");
            }
            
            }
        }
    }

