using System;

//Поразрядные операции
namespace Single.Part2
{
    class Solution03
    {
        public static void Execute()
        {
            //Логические операции  

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

            // Операции сдвига

            // Операции сдвига *=2 /=2
            Console.WriteLine(y9 << 1);
            Console.WriteLine(y9 >> 1);
        }
    }
}
