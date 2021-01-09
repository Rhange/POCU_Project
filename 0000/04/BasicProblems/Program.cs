using System;

namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01.
            Console.Write("10 + 5 = ");
            Console.WriteLine(10 + 5);

            Console.Write("20 - 10 = ");
            Console.WriteLine(20 - 10);

            Console.Write("4 X 7 = ");
            Console.WriteLine(4 * 7);

            Console.Write("20 / 7 = ");
            Console.WriteLine(20 / 7);
            Console.Write("20 % 7 = ");
            Console.WriteLine(20 % 7);

            // 02.
            Console.WriteLine("안녕" + "하세요");

            // 03.
            int number1 = 20;
            int number2 = 5;
            int number3 = 3;
            int number4 = 13;
            int number5;

            number1 = number1 + number2;    // 25
            number2 = number3 + number4;    // 16
            number4 = number1 - number4;    // 12
            number3 = number2 / number4;    // 16 / 12 == 1
            number5 = number2 % number4;    // 16 % 12 == 4

            Console.WriteLine(number1); // 25
            Console.WriteLine(number2); // 16
            Console.WriteLine(number3); // 1
            Console.WriteLine(number4); // 12
            Console.WriteLine(number5); // 4

            // 04.
            int number6 = 4 - 2;
            number6 = number6 * 16;
            number6 = number6 + 2;

            Console.WriteLine("(4 - 2) * 16 + 2");
            Console.Write(number6);

        }
    }
}
