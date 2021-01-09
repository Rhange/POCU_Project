using System;

namespace AdvancedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01.
            int number = 2;
            number = number * 3;
            number = number - 4;
            number = number % 2;

            Console.WriteLine(number);

            // 02.
            int bin = 10;
            Console.Write("처음 주머니 속 동전 수 : ");
            Console.WriteLine(bin);
            
            int aramNumber = bin / 2 - 1;
            bin = bin - aramNumber;

            int wooramNumber = bin / 2 + 2;
            bin = bin - wooramNumber;

            Console.Write("아람이가 가져간 동전 수: ");
            Console.WriteLine(aramNumber);

            Console.Write("우람이가 가져간 동전 수: ");
            Console.WriteLine(wooramNumber);

            Console.Write("주머니에 남은 동전 수: ");
            Console.WriteLine(bin);
        }
    }
}