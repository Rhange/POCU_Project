using System;

namespace AdvancedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01.
            Console.WriteLine("첫 번째 숫자를 입력해주세요.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            
            Console.WriteLine("두 번째 숫자를 입력해주세요.");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);

            Console.Write("두 수의 합: ");
            Console.WriteLine(number1 + number2);

            Console.Write("두 수의 차: ");
            Console.WriteLine(number1 - number2);

            Console.Write("두 수의 곱: ");
            Console.WriteLine(number1 * number2);

            Console.Write("두 수의 나눗셈의 결과: ");
            Console.WriteLine(number1 / number2);

            Console.Write("두 수의 나눗셈의 나머지: ");
            Console.WriteLine(number1 % number2);

            Console.WriteLine("=======================================");
            // 02.
            // 분모가 0일 때, 나타나는 모습?
            // 몫은 무한대로 발산, 나머지는 NaN

            // 03.
            int binNumber = 10;
            Console.Write("주머니에는 동전이 ");
            Console.Write(binNumber);
            Console.WriteLine("개 들어 있습니다.");
            
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            string userInput3 = Console.ReadLine();
            int motherNumber = int.Parse(userInput3);
            binNumber = binNumber + motherNumber;   // 어머니가 넣은 동전 갯수 추가

            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            string userInput4 = Console.ReadLine();
            int aramNumber = int.Parse(userInput4);
            binNumber = binNumber - aramNumber; // 아람이가 꺼낸 동전 갯수 차감

            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            string userInput5 = Console.ReadLine();
            int wooramNumber = int.Parse(userInput5);
            binNumber = binNumber - wooramNumber;   // 우람이가 꺼낸 동전 갯수 차감

            Console.Write("주머니에 남아 있는 동전의 개수는 ");
            Console.Write(binNumber);
            Console.WriteLine("개입니다.");

            Console.WriteLine("=======================================");
        }
    }
}
