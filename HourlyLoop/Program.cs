using System;

namespace HourlyLoop
{

    namespace HourlyPay
    {
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Enter a hourly pay rate ");
                double hourly = double.Parse(Console.ReadLine());

                while (hourly < 5.65 || hourly > 49.99)
                {
                    Console.WriteLine("Enter a hourly pay rate ");
                    hourly = double.Parse(Console.ReadLine());
                }
                

                Console.WriteLine("Valid pay rate {0}", hourly);
                Console.ReadLine();
            }
        }
    }
}
    
