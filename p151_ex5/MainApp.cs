using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex5
{
    class MainApp
    {
      
            static void Main(string[] args)
        {
            
            Console.Write("세개의 정수 중 첫번째 정수를 입력해주세요 : ");
            string a = Console.ReadLine();
            int nb1 = int.Parse(a); 
            Console.Write("세개의 정수 중 두번째 정수를 입력해주세요 : ");
            string b = Console.ReadLine();
            int nb2 = int.Parse(b);
            Console.Write("세개의 정수 중 세번째 정수를 입력해주세요 : ");
            string c = Console.ReadLine();
            int nb3 = int.Parse(c);
            int[] arr= { nb1, nb2, nb3 };
            int max = arr.Max(); //int max = Math.Max(Math.Max(nb1, nb2), nb3);
            int min = arr.Min(); //int min = Math.Min(Math.Min(nb1, nb2), nb3);
            int sum = arr.Sum(); //System.Linq에 있는 Sum 메소드 사용;
            double average = arr.Average();//System.Linq에 있는 Avergae 메소드 사용;
            Console.WriteLine($"입력하신 {nb1},{nb2},{nb3} 중 최대값은 {max} 이며, 최소값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {nb1},{nb2},{nb3} 중 합은 {sum} 이며, 평균은 {average} 입니다.");
             
        }
    }
}
