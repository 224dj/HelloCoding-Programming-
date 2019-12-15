using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 수");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            Console.WriteLine("두 번째 수");
            int number2 = int.Parse(userInput2);
        }
    }
}
