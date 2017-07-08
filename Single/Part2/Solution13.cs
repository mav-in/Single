using System;
using System.Linq;

//Массив параметров и ключевое слово params
namespace Single.Part2
{
    public class Solution13
    {
        public static void Execute()
        {
            // МАССИВ ПАРАМЕТРОВ И КЛЮЧЕВОЕ СЛОВО PARAMS

            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            Addition(array);

            Addition();

            AdditionArray(array, 4);
            Console.ReadLine();
        }

        // передача параметра с params
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }

        // передача массива
        static void AdditionArray(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }
    }
}
