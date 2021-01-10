using System;

namespace AdvancedProblem0802
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총 학생수를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());
            string[] subjects = { "국어", "영어", "수학" };
            
            int[] studentsTotal = new int[studentCount];
            double[] studentsAvg = new double[studentCount];
            
            int studentIndex = 0;
   
            while (studentIndex < studentCount)
            {
                int subjectIndex = 0;
                int total = 0;
                double average;

                while (true)
                {
                    Console.Write(studentIndex + 1);
                    Console.Write("번째 학생의 ");
                    Console.Write(subjects[subjectIndex]);
                    Console.WriteLine("점수를 입력하세요.");
                    total = total + int.Parse(Console.ReadLine());

                    subjectIndex = subjectIndex + 1;

                    if (subjectIndex == 3)
                    {
                        break;
                    }
                }

                average = total / 3;

                studentsTotal[studentIndex] = total;
                studentsAvg[studentIndex] = average;

                studentIndex = studentIndex + 1;
            }

            studentIndex = 0;

            while (studentIndex < studentCount)
            {
                Console.Write(studentIndex + 1);
                Console.Write("번째 학생의 총점은 ");
                Console.Write(studentsTotal[studentIndex]);
                Console.Write("점이고 평균은 ");
                Console.Write(studentsAvg[studentIndex]);
                Console.WriteLine("점입니다.");

                studentIndex = studentIndex + 1;
            }
        }
    }
}
