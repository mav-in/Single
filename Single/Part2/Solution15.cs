using System;

namespace Single.Part2
{
    public class Solution15
    {
        public static void Execute()
        {
            // РЕКУРСИВНЫЕ ФУНКЦИИ

            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Factorial(a);
            Console.WriteLine("Факториал числа {0}! = {1}", a, b);
            Console.WriteLine("Чсило фибоначи числа {0} = {1}", a, Fibonachi(a));
        }

        static int Factorial(int x)
        {
            if (x == 0) {
                return 1;
            } else {
                return x * Factorial(x - 1);
            }
        }

        static int Fibonachi(int n)
        {
            if (n == 0) {
                return 0;
            }
            if (n == 1) {
                return 1;
            } else {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
