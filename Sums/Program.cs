using System;

namespace Sums
{
    class Program
    {
        public static void Main()
        {
            int numb, sum = 0;

            for (numb = 1; numb <= 50; numb++)
            {
                sum = sum + numb;
                Console.WriteLine("{0} Sum = {1}", numb, sum);
            }

            Console.WriteLine("Total Sum = {0}", sum);

            Console.ReadLine();
        }
    }
}