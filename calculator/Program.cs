using System;
using System.Collections.Generic;
using System.Text;



namespace Calculator

{

    class Program

    {
        static void Main(string[] args)

        {

            double numb1, numb2;

            int result = 0;

            Console.WriteLine("Type the first number");

            numb1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the second number");

            numb2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while (result != 5)

            {

                Console.WriteLine("To Add type 1");

                Console.WriteLine("To subtract type 2");

                Console.WriteLine("To divide type 3");

                Console.WriteLine("To multiply type 4");

                Console.WriteLine("To finish type 5");

                result = int.Parse(Console.ReadLine());

                if (result == 1)

                {

                    Console.WriteLine("Result = {0}", numb1 + numb2);

                }

                if (result == 2)

                {

                    Console.WriteLine("Result = {0}", numb1 - numb2);

                }

                if (result == 3)

                {

                    Console.WriteLine("Result = {0}", numb1 / numb2);

                }

                if (result == 4)

                {

                    Console.WriteLine("Result = {0}", numb1 * numb2);

                }

                Console.ReadLine();

                Console.Clear();

            }

        }

    }

}