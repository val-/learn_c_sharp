using System;

namespace word_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string output = "";
            for (int i = 1; i <= input.Length; i++) {
                output += input[input.Length - i];
            }
            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
