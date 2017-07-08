using System;

//Условные выражения
namespace Single.Part2
{
    class Solution06
    {
        public static void Execute()
        {
            // Операци сравнения
            int x = 0;
            int y = 1;
            bool bz;
            // ==
            bz = x == y; // сравнивает два операнда на равенство: z равно true, если x равно y, иначе z будет равно false
            // !-
            bz = x != y; //(z равно true, если x не равно y, иначе z будет равно false)
            // <
            bz = x < y; // (z равно true, если x меньше y, иначе z будет равно false)
            // >
            bz = x > y; // (z равно true, если x больше y, иначе z будет равно false)
            // <=
            bz = x <= y; // (z равно true, если x меньше или равно y, иначе z будет равно false)
            // >=
            bz = x >= y; // (z равно true, если x больше или равно y, иначе z будет равно false)
            bool bx = true, by = false;
            bz = bx == by;
            bz = bx != by;
            int a = 10;
            int b = 4;
            bool c = a >= b;     // true
            bool d = a >= 25;    // false

            // Логические операторы
            bz = bx | by; //(z равно true, если либо x, либо y (либо и x, и y) равны true, иначе z будет равно false)
            bz = bx & by; // (z равно true, если и x, и y равны true, иначе z будет равно false)
            bz = !by; // (z равно true, если y равно false, иначе z будет равно false)
            bz = bx ^ by; // (z равно true, если либо x, либо y (но не одновременно) равны true, иначе z будет равно false)
            bz = bx || by; // (z равно true, если либо x, либо y (либо и x, и y) равны true, иначе z будет равно false)
            bz = bx && by; // (z равно true, если и x, и y равны true, иначе z будет равно false)

            // Примеры
            bool bx1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool bx2 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            bool bx3 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool bx4 = (50 > 6) && (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается true
            bool bx5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool bx6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false

            // ~ (логическое отрицание) - инверсия
            //bool z = true;
            //Console.WriteLine(~z); //?
        }
    }
}
