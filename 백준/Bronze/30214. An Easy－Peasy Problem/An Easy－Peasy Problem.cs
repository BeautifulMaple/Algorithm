using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            var inputs = Console.ReadLine().Split(' ');
            int s1 = int.Parse(inputs[0]);
            int s2 = int.Parse(inputs[1]);

            Console.WriteLine((s1 * 2 >= s2) ? "E" : "H");
        }
    }
}