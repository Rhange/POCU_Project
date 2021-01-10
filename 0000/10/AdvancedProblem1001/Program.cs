using System;

namespace AdvancedProblem1001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("수비수가 숫자를 선택하였습니다.");
            Random random = new Random();
            int number = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("1 이상 100 이하의 숫자 중에서 하나를 입력하세요.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine("1 이상 100 이하의 숫자만 넣으세요!");
                    continue;
                }

                if (userInput > number)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (userInput < number)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
        }
    }
}