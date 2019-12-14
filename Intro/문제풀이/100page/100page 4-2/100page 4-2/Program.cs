using System;

namespace _100page_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int poketOrigin = 10;
            int nowPoket = poketOrigin;
            int aram;
            int uram;

            nowPoket = nowPoket / 2;
            nowPoket = nowPoket + 1;
            aram = poketOrigin - nowPoket;
            
            nowPoket = nowPoket / 2;
            nowPoket = nowPoket - 2;
            uram = (poketOrigin - aram) - nowPoket;

            Console.Write("아람이가 가져간 동전: ");
            Console.WriteLine(aram);

            Console.Write("우람이가 가져간 동전: ");
            Console.WriteLine(uram);

            Console.Write("남은 동전: ");
            Console.WriteLine(nowPoket);
        }
    }
}
