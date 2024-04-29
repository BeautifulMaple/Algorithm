using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            // 새 객체를 만들지 않고 데이터를 재사용하고 수정할 수 있음
            StringBuilder result = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            bool Tag = false;

            foreach (char c in S)
            {
                if(c == '<')
                {
                    while(stack.Count > 0) result.Append(stack.Pop());
                    Tag = true; // 태그 안으로 진입
                    result.Append(c);
                }
                else if (c == '>')
                {
                    Tag = false;    // 태그 밖으로 나옴
                    result.Append(c);
                }
                else if (Tag)
                {
                    // 태그 안의 문자는 그대로 결과 문자열에 추가
                    result.Append(c);
                }
                else
                {
                    if(c == ' ')
                    {
                        // 공백 문자를 만나면 스택에 쌓인 문자들을 결과 문자에 추가하기
                        while(stack.Count > 0) { result.Append(stack.Pop());}
                        result.Append(c); //
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }
            // 마지막으로 스택에 남아 있는 문자들을 결과 문자열에 추가
            while(stack.Count > 0) result.Append(stack.Pop());
            Console.WriteLine(result.ToString());
        }
    }
}
