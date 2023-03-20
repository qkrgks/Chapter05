using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWANGJEONGIN_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            
            Console.Write("반복 횟수를 입력하세요 : ");
            string banbock = Console.ReadLine();
            int a = int.Parse(banbock);
            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");

                    }

                    Console.WriteLine("");

                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }
        }
    }
}
