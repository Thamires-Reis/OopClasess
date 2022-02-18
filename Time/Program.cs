using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the ammount of hours:");
                int hours = Convert.ToInt32(Console.ReadLine());
                int minutes = hours * 60;
                Console.WriteLine(minutes + " Minutes");
            }
        }
    }
