using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWANGJEONGIN_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //1번문제 while문
            Console.WriteLine("예제1번 while문과 do 문입니다");
            int i = 0;
            while (i < 5)
            {
                int j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            //1번문제 do-while문

            i = 0;
            do
            {
                int j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                } while (j <= i);
                Console.WriteLine();
                i++;
            } while (i < 5);
            
            Console.WriteLine("예제2번 while문과 do 문입니다");
            //2번문제 while문
            i = 0;
            while (i<5 )
            {
                int j = 5;
                while (j > i)
                {
                    Console.Write("*");
                    j--;
                }
                Console.WriteLine();
                i++;
            }
            i = 0;
            //2번문제 do-while문
            do
            {
                int j = 5;
                do
                {
                    Console.Write("*");
                    j--;
                } while (j > i);
                Console.WriteLine();
                i++;
            } while (i < 5);
        }
    }
}
