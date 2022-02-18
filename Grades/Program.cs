using System;

namespace Grades
{

    class Program
    {
        static void Main(string[] args)
        {

            string student1, student2, student3;
            double average = 0;

            Console.WriteLine("Enter the students name and final score");
            Console.WriteLine();
            student1 = Console.ReadLine();
            int score1 = Convert.ToInt32(Console.ReadLine());

            student2 = Console.ReadLine();
            int score2 = Convert.ToInt32(Console.ReadLine());

            student3 = Console.ReadLine();
            int score3 = Convert.ToInt32(Console.ReadLine());

            if (score1 > score2)
            {

                if (score1 > score3)
                {
                    Console.WriteLine("The highest grade in the class is : " + score1);
                }
                else
                {
                    Console.WriteLine("The highest grade in the class is : " + score3);
                }
            }
            else
            {
                if (score2 > score3)
                {
                    Console.WriteLine("The highest grade in the class is : " + score2);
                }
                else
                {
                    Console.WriteLine($"The highest grade in the class is : "  + score3);


                }
            }
                    average = (score1 + score2 + score3) / 3;

                    Console.WriteLine($"The average grade for the class is : {average} ");


                }

            }

        }
    












