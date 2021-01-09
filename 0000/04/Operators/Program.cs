using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("100 + 10 = ");
            Console.WriteLine(100 + 10);
            Console.Write("100 - 10 = ");
            Console.WriteLine(100 - 10);
            Console.Write("100 * 10 = ");
            Console.WriteLine(100 * 10);
            Console.Write("84 / 10 = ");
            Console.WriteLine(84 / 10);
            Console.Write("84 % 10 = ");
            Console.WriteLine(84 % 10);

            Console.WriteLine("글" + "붙여쓰기");

            // Console.WriteLine("글붙여쓰기" - "붙여쓰기"); // 문자열은 '+' 연산자만 가능
        }
    }
}
