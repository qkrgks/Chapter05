﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 연결 테스팅
            Console.WriteLine("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("음수");
            }
            else
            {
                Console.WriteLine("양수");
            }

            else 
            {
                Console.WriteLine("0");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }

            else 
            {
                Console.WriteLine("홀수");
            }

            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");


        }
    }
}
