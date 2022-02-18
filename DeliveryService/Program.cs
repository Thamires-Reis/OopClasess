using System;

namespace DeliveryService
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string[] zipCode = { "IE01", "IE02", "IE03", "IE04","IE05","IE06","IE07", "IE08", "IE09", "IE10" };
            int[] code = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Welcome to Ireland delivery service");
            Console.WriteLine();
            Console.WriteLine("To check if we delivery to your address enter your zip code");
            Console.WriteLine();
            string zip = Console.ReadLine();

            bool contains = false;
            int codeAddress = 0;
            for (int i = 0; i < zipCode.Length; i++)
            {
                if (zip == zipCode[i])
                {
                   contains = true;
                   codeAddress = code[i];
                    break;
                }
            }

            if (contains == true)
            {
                
                Console.WriteLine("We delivery to your adress {0}", zip);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Unfortunately we don't delivery to your adress");
            }
          

        }
    }
}
