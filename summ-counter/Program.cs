using System;

namespace summ_counter {
    class Program {
        static void Main(string[] args) {

            int sum = 0;
            int i = 0;
            while (i <= 1000) {
                sum += i;
                i++;
            }
            Console.Write(sum);
            Console.Write("\n");

        }
    }
}
