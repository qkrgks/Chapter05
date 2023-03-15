using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("몇월이 궁금하세요? : ");
            string input = Console.ReadLine();
            int day = 0;

            switch (input)
            {
                case "1":case "3":case "5":case "7":case "8": case "10":case "12":

                    day = 31;
                    break;



                case "4": case "6":case "9":case "11":
                    day = 30;
                    break;

                case "2":
                    day = 28;
                    break;

                default:
                    Console.WriteLine($"{input}월는(은) 요일이 아닙니다.");
                    return;

            }

            Console.WriteLine($"{input}월는(은) {day}까지있습니다.");
        }
    }
}
