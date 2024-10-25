using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            var inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            if ((A + B) == C)
                Console.WriteLine("correct!");
            else
                Console.WriteLine("wrong!");
        }
    }
}