using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int passNumber1 = 2;
            int passNumber2 = 6;

            Console.Write("첫번째 숫자");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자");
            int userInput2 = int.Parse(Console.ReadLine());

            if (passNumber1 == userInput1 && passNumber2 == userInput2)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
        }
    }
}
