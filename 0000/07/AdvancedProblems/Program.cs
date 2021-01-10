using System;

namespace AdvancedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 02. 총점과 평균
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[subjects.Length];
            int total_score = 0;
            double avg_score;

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write(subjects[i]);
                Console.WriteLine(" 점수를 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
                total_score = total_score + scores[i];
            }

            avg_score = total_score / subjects.Length;

            Console.Write("총 점수: ");
            Console.WriteLine(total_score);
            Console.Write("평균 점수: ");
            Console.WriteLine(avg_score);   
           
        }
    }
}
