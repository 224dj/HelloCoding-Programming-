using System;

namespace _124page_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int poketOrigin = 10;

            Console.WriteLine("어머니는 몇개의 동전을 주머니에 더 넣었나요? (기본값: 10)");
            double motherMoney = double.Parse(Console.ReadLine());

            Console.WriteLine("아람이가 몇 개 가져갔나요?");
            double aramMoney = double.Parse(Console.ReadLine());

            Console.WriteLine("우람이가 몇 개 가져갔나요?");
            double uramMoney = double.Parse(Console.ReadLine());

            Console.Write("남은돈: ");
            Console.WriteLine(poketOrigin + motherMoney - aramMoney - uramMoney);
        }
    }
}
