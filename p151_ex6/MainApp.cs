using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex.2) : ");
            string a = Console.ReadLine(); //a에 값을 입력
            int grade = int.Parse(a); // grade에 a의 값 int로 변환 시켜서 대입
            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85) : ");
            string b = Console.ReadLine();//b에 값을 입력
            int score = int.Parse(b);// score에 b의 값 int로 변환 시켜서 대입
            
            if (grade == 4)//grade가 4일 경우 발동
            {
                if (score >= 70 && score <=100)//논리 연산자 &&를 사용하여 score가 70 이상이고 100이하 이면 발동
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 합격 입니다.  ");
                }
                else if(score<70 && score>=0)//논리 연산자 &&를 사용하여 score가 60 이상이고 70미만 이면 발동
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 불합격 입니다.  ");
                }
                else //위의 두 조건을 제외한 발동
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요. ");
                }
            }
            else if(grade ==3 || grade ==2 || grade ==1)
            {
                if (score >= 60 && score <= 100)//논리 연산자 &&를 사용하여 score가 60 이상이고 100이하 이면 발동
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 합격 입니다.  ");
                }
                else if(score < 60 && score >=0)//논리 연산자 &&를 사용하여 score가 0 이상이고 60미만 이면 발동
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 불합격 입니다.  ");
                }
                else //위의 두 조건을 제외한 발동
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요 ");
                }
            }
            else//학년을 잘못입력했을경우 출력
            {
                Console.WriteLine("학년을 잘못입력하셨습니다. 확인 후 다시 입력해주세요 ");
            
            }
            
        }
    }
}
