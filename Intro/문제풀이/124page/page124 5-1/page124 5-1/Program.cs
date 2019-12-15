using System;

namespace page124_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("userInput1: ?");
            double userInput1 = double.Parse(Console.ReadLine());

            Console.WriteLine("userInput2: ?");
            double userInput2 = double.Parse(Console.ReadLine());

            Console.Write("userInput1 + userInput2 = ");
            Console.WriteLine (userInput1 + userInput2);
            Console.Write("userInput1 - userInput2 = ");
            Console.WriteLine(userInput1 - userInput2);
            Console.Write("userInput1 * userInput2 = ");
            Console.WriteLine(userInput1 * userInput2);
            Console.Write("userInput1 / userInput2 = ");
            Console.WriteLine(userInput1 / userInput2);

        }
    }
}
