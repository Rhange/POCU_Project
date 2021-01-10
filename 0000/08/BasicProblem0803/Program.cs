using System;

namespace BasicProblem0803
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];
            int index = 0;
            int total = 0;

            while (index < friendCount)
            {
                Console.Write(index + 1);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개 인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
                total = total + appleNumbers[index];

                index = index + 1;
            }

            Console.Write("친구들에게 ");
            Console.Write(total);
            Console.WriteLine("개의 사과를 나눠줬습니다.");
        }
    }
}
