using System;

namespace Single.Part2
{
    class Solution4
    {
        public static void Execute()
        {
            string hello1 = "hello " + "world"; //результат равен "hello world"
            string hello2 = "hello " + 4 + " you"; //результат равен "hello 4 you"
            int x1 = 2 + 4; // результат равен 6
            int x2 = 10 - 6; //результат равен 4
            int x3 = 10 * 6; //результат равен 60
            double x4 = 10.0 / 4.0; //результат равен 2.5
            double x5 = 10.0 % 4.0; //результат равен 2
            int y1 = 5;
            int z1 = ++y1; // z1=6; y1=6
            int y2 = 5;
            int z2 = y2++; // z2=5; y2=6
            int y3 = 5;
            int z3 = --y3; // z3=4; y3=4
            int y4 = 5;
            int z4 = y4--; // z4=5; y4=4

            // & (логическое умножение) - AND
            int x6 = 2; //010
            int y6 = 5;//101
            Console.WriteLine(x6 & y6); // выведет 0
            int x7 = 4; //100
            int y7 = 5; //101
            Console.WriteLine(x7 & y7); // выведет 4

            // | (логическое сложение) - OR
            int x8 = 2; //010
            int y8 = 5;//101
            Console.WriteLine(x8 | y8); // выведет 7 - 111
            int x9 = 4; //100
            int y9 = 5;//101
            Console.WriteLine(x9 | y9); // выведет 5 - 101

            // ^ (логическое исключающее ИЛИ) - XOR
            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            Console.WriteLine("Исходное число: " + x);
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine("Зашифрованное число: " + encrypt);
            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine("Расшифрованное число: " + decrypt);


        }
    }
}
