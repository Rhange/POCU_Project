using System;

namespace BasicProblem0901
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("몇 명의 친구들엑 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumber = new int[friendCount];

            for (int i = 0; i < friendCount; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개 인가요?");
                appleNumber[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < friendCount; i++)
            {
                Console.Write(i + 1);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNumber[i]);
                Console.WriteLine("개입니다.");
            }
        }
    }
}