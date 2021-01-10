using System;

namespace BasicProblem0902
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] scores = new int[5];
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
                total = total + scores[i];
            }

            Console.Write("총점은 ");
            Console.Write(total);
            Console.WriteLine("점입니다.");
        }
    }
}