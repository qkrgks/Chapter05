using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("정수 한개를 입력하세요 : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);


            if (number % 3 == 0)
            {

                Console.WriteLine($"입력하신 정수 " + $"{number}는(은) 3의 배수 입니다.");

            }

            else
            {

                Console.WriteLine($"입력하신 정수 " + $"{number}는(은) 3의 배수가 아닙니다.");

            }








        }
    }
}
