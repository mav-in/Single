using System;

namespace Single.Part2
{
    public class Solution8
    {
        public static void Execute()
        {
            // ПРОГРАММА СОРТИРОВКИ МАССИВА
            // ввод чисел
            int[] numsA = new int[7];
            int[] numsB = new int[7];
            Console.WriteLine("Введите семь чисел");
            for (int i = 0; i < numsA.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                numsA[i] = Int32.Parse(Console.ReadLine());
                numsB[i] = numsA[i];
            }

            // сортировка перестановкой
            int temp;
            for (int i = 0; i < numsA.Length - 1; i++)
            {
                for (int j = i + 1; j < numsA.Length; j++)
                {
                    if (numsA[i] > numsA[j])
                    {
                        temp = numsA[i];
                        numsA[i] = numsA[j];
                        numsA[j] = temp;
                    }
                    for (int k = 0; k < numsA.Length; k++)
                    {
                        Console.Write(numsA[k] + " ");
                    }
                    Console.WriteLine();
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < numsA.Length; i++)
            {
                Console.WriteLine(numsA[i]);
            }
            Console.ReadLine();

            // сортировка с использованием метода Sort
            Array.Sort(numsB);
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < numsB.Length; i++)
            {
                Console.WriteLine(numsB[i]);
            }
            Console.ReadLine();
        }
    }
}
