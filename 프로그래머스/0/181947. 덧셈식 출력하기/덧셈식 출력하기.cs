using System;

public class Example
{
    public static void Main()
    {
        String[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }
}