using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine(" what is the random number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The random number was {0}", randomNumber);

            if (number > randomNumber)
            {
                Console.WriteLine("The random number was too high");
                Console.ReadLine();
            }
          if (number < randomNumber)
            {
                Console.WriteLine("The random number was too low");
                Console.ReadLine();
            }
          else 
            {
                Console.WriteLine("You got it right");
                Console.ReadLine();
            }
        }
    }
}

