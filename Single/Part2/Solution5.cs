using System;

namespace Single.Part2
{
    public class Solution5
    {
        public static void Execute()
        {
            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            Console.WriteLine(nums[3]);

            // эти два способа равноценны
            int[] nums2 = new int[] { 1, 2, 3, 5 };
            int[] nums3 = { 1, 2, 3, 5 };

            // многомерные масисвы
            int[] nums4 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[,] nums5 =
            {
                { 0, 1, 2 },
                { 3, 4, 5 }
            };

            // объявление трёхмерного массива
            int[,,] nums6 = new int[2, 3, 4];

            // массив массивов
            int[][] nums7 = new int[3][];
            nums7[0] = new int[2];
            nums7[1] = new int[3];
            nums7[2] = new int[5];

            // Методы и свойства массивов
            Console.WriteLine(nums5.Length);
            Console.WriteLine(nums5.Rank);
            Array myArray = Array.CreateInstance(typeof(String), 3);
            myArray.SetValue("What", 0);
            myArray.SetValue("is", 1);
            myArray.SetValue("it", 2);
            PrintIndexAndValues(myArray);
            Array.Reverse(myArray);
            PrintIndexAndValues(myArray);
            Array.Sort(myArray);
            PrintIndexAndValues(myArray);

            // Свойство Length: позволяет получить количество элементов массива
            // Свойство Rank: позволяет получить размерность массива
            // Метод Array.Reverse: изменяет порядок следования элементов массива на обратный
            // Метод Array.Sort: сортирует элементы массива
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++) {
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
            }
        }
    }
}
