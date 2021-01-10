using System;

namespace AdvancedProblem1002
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("가위 바위 보 게임을 시작합니다.");
            Console.WriteLine("1은 가위, 2는 바위, 3은 보 입니다.");
            Console.WriteLine("종료를 원하시면 4 를 입력해주세요.");

            Random random = new Random();

            while (true)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("컴퓨터가 가위 바위 보 중에서 하나를 선택하였습니다.");
                int computerNumber = random.Next(1, 4);

                Console.WriteLine("1: 가위");
                Console.WriteLine("2: 바위");
                Console.WriteLine("3: 보");
                Console.WriteLine("숫자를 선택해주세요.");
                Console.WriteLine("=====================================================");

                int userInput;
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 4)
                    {
                        Console.WriteLine("안녕히 가세요.");
                        break;
                    }

                    if (userInput < 1 || userInput > 4)
                    {
                        Console.WriteLine("** 1, 2, 3, 4(종료) 네 숫자 중에서 하나를 입력해주세요. **");
                    }
                    else
                    {
                        string[] names = { "Computer: ", "You: " };
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write(names[i]);
                            int whoseNumber = 0;
                            if (i == 0)
                            {
                                whoseNumber = computerNumber;
                            }
                            else
                            {
                                whoseNumber = userInput;
                            }

                            if (whoseNumber == 1)
                            {
                                Console.Write("가위 ");
                            }
                            else if (whoseNumber == 2)
                            {
                                Console.Write("바위 ");
                            }
                            else
                            {
                                Console.Write("보 ");
                            }
                            Console.WriteLine();
                        }

                        if (userInput == computerNumber)
                        {
                            Console.WriteLine("비겼습니다.");
                            continue;
                        }
                        else if (userInput - computerNumber == 1 || userInput - computerNumber == -2)
                        {
                            Console.WriteLine("당신이 이겼습니다.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("당신이 졌습니다.");
                            continue;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("** 문자가 아닌 숫자를 입력해주세요! **");
                }
            }
        }
    }
}