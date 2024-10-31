using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        while (true)
        {
            string inputs = Console.ReadLine(); //입력값

            if (string.IsNullOrWhiteSpace(inputs))
            {
                break;
            }
            count++;
        }


        Console.WriteLine(count);
        
    }
}
