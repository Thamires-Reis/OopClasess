using System;

namespace Room
{
    class Program
    {

        public static void Main()
        {
            const double square = 9.80;
            double length, width, area;
            Console.Write("Enter length of room: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of room:");
            width = Convert.ToInt32(Console.ReadLine());
             area = length * width;
            double price = area * square;

            Console.WriteLine("The carpet cost is {0} by {1} room is ${2}", length, width, price);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}