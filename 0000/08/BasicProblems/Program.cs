using System;

namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01.
            int[] scores = new int[5];
            int index = 0;
            int totalScore = 0;

            while (index < scores.Length)
            {
                Console.Write(index);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
                totalScore = totalScore + scores[index];

                index = index + 1;
            }

            Console.Write("총점은 ");
            Console.Write(totalScore);
            Console.WriteLine("점입니다.");
        }
    }
}
