using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);


            if (number >= 90)
            {
                Console.WriteLine($"입력하진 점수 " + $"{number}는(은) A 학점 입니다.");
            }

            else if (number >= 80)
            {
                Console.WriteLine($"입력하진 점수 " + $"{number}는(은) B 학점 입니다.");
            }

            else if (number >= 70)
            {
                Console.WriteLine($"입력하진 점수 " + $"{number}는(은) C 학점 입니다.");
            }

            else 
            { 
            Console.WriteLine($"입력하진 점수 " + $"{number}는(은) F 학점 입니다.");
            }

            //if (number > 0)
            {
                //if (number >= 90)
                    //Console.WriteLine("A");
               // else if (number >= 80)
                   // Console.WriteLine("B");
               // else if (number >= 70)
                   // Console.WriteLine("C");
               // else (number <= 69)
                   // Console.WriteLine("F");
            }
            
                    

        }
    }
}
