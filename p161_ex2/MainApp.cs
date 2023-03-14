using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 두개와 연산기호를 입력해주세요!");
            Console.Write("첫번째 번호를 입력해주세요. : ");
            string input1 = Console.ReadLine();
            Console.Write("두번째 번호를 입력해주세요. : ");
            string input2 = Console.ReadLine();
            Console.Write("연산 기호를 입력해주세요. ex) +,-,*,/,% : ");
            string input3 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
            int number3 = int.Parse(input3);

            //switch (input3)
            //{
            //    case "+":
            //        value = number1 + number2;
            //        break;

            //    case "-":
            //        value = number1 - number2;
            //        break;

            //    case "*":
            //        value = number1 * number2;
            //        break;

            //    case "/":
            //        value = number1 / number2;
            //        break;

            //    case "%":
            //        value = number1 % number2;
            //        break;

                

            //}

            //Console.WriteLine($"입력하신 정수 " + $"는(은) 3의 배수 입니다.");

        }
    }
}
