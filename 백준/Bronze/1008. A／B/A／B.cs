using System;

namespace Baekjoon
{
    class program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //Split()은 특정 문자를 기준으로 문자열을 나눈 뒤 리스트 형태로 반환하는 함수
            string[] ss = s.Split();
            //Parse(): 일부 문자열을 입력으로 받고 필요한 정보를 "추출"하여 호출 클래스의 객체로 반환합니다.
            //실수값을 나타내기 위해 실수형 사용하기
            double a = double.Parse(ss[0]);
            double b = double.Parse(ss[1]);
            Console.WriteLine(a/b);
        }
    }
}