using System;

namespace HiddenWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman game");
            string[] secretwords = new string[10];
            secretwords[0] = "blue";
            secretwords[1] = "moon";
            secretwords[2] = "umbrella";
            secretwords[3] = "holiday";
            secretwords[4] = "sun";
            secretwords[5] = "pool";
            secretwords[6] = "friday";
            secretwords[7] = "apple";
            secretwords[8] = "beach";
            secretwords[9] = "book";
            Random randGen = new Random();
            var secretWords = randGen.Next(0, 9);
            string hiddenWord = secretwords[secretWords];
            char[] guess = new char[hiddenWord.Length];
            Console.Write("Please enter a letter: ");

            for (int p = 0; p < hiddenWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char userGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < hiddenWord.Length; j++)
                {
                    if (userGuess == hiddenWord[j])
                        guess[j] = userGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}
