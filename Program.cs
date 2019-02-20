using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            if (randomNumber == 3)
            {
                Console.WriteLine("Number was 3 this time!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number was not 3 :(");
                Console.ReadLine();
            }
        }
    }
}
