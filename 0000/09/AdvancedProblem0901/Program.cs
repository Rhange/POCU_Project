using System;

namespace AdvancedProblem0901
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            for (int i = 0; i < 5; i++)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex + 1);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;

                        if (i == 4)
                        {
                            Console.Write("비밀번호를 총 ");
                            Console.Write(i + 1);
                            Console.WriteLine("번 틀려서 종료합니다.");
                        }
                        else
                        {
                            Console.Write("비밀번호가 틀렸습니다.");
                            Console.Write("(");
                            Console.Write(i + 1);
                            Console.WriteLine("회)");
                            Console.WriteLine();
                        }
                        break;
                    }
                }

                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}