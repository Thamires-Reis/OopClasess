using System;

namespace IntegerMethod
{
    class Program
    {
        static void Main()
        {
            Console.Write("Multiplication table");
            Console.WriteLine();
            Console.Write("Enter a number : ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            multiplicationTable(numb);
            Console.WriteLine();
        }

        static void multiplicationTable(int numb)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1, -2} = {2}", numb, i, numb * i);
            }
        }
    }
}