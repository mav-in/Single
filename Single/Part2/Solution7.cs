using System;

namespace Single.Part2
{
    public class Solution7
    {
        public static void Execute()
        {
            // ЦИКЛЫ

            // цикл for
            for (int i = 0, j = 1; i < 9; i++, j++)
            {
                Console.WriteLine("{2}: Квадрат числа {0} равен {1}", i, i * i, j);
            }

            int k = 0;
            for (;;)
            {
                if (k > 5) break;
                Console.WriteLine("Квадрат числа {0} равен {1}", ++k, k * k);
                System.Threading.Thread.Sleep(500);
            }

            int m = 0;
            for (; m < 9;)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", ++m, m * m);
            }

            // foreach
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }

            // цикл do
            int n = 6;
            do
            {
                Console.WriteLine(n);
                n--;
            }
            while (n > 0);

            int p = -1;
            do
            {
                Console.WriteLine(p);
                p--;
            }
            while (p > 0);

            // цикл while
            int q = 6;
            while (q > 0)
            {
                Console.WriteLine(q);
                q--;
            }

            // операторы countinue и break
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 10)
                    break;
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 10)
                    continue;
                Console.WriteLine(array[i]);
            }
        }
    }
}
