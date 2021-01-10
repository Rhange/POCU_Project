using System;

namespace AdvancedProblem0902
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int classNumber = 5;
            int studentNumber = 10;

            int[] classTotalScores = new int[classNumber];
            double[] classAvgScores = new double[classNumber];

            for (int i = 0; i < classNumber; i++)
            {
                int total = 0;
                for (int j = 0; j < studentNumber; j++)
                {
                    Console.Write(i + 1);
                    Console.Write("반 ");
                    Console.Write(j + 1);
                    Console.WriteLine("번 학생의 성적을 입력하세요.");
                    total = total + int.Parse(Console.ReadLine());
                }
                classTotalScores[i] = total;

                double avg = total / studentNumber;
                classAvgScores[i] = avg;
            }

            for (int i = 0; i < classNumber; i++)
            {
                Console.Write(i + 1);
                Console.Write("반의 평균점수는 ");
                Console.Write(classAvgScores[i]);
                Console.WriteLine("입니다.");
            }
        }
    }
}