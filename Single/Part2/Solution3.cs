using System;

namespace Single.Part2
{
    public class Solution3
    {
        public static void Execute()
        {
            byte a1 = 4;
            // расширяющее преобразование a1 - неявные (implicit conversion)
            int b1 = a1 + 70;
            // сужающие преобразования а2 - явные преобразования (explicit conversion)
            byte b2 = (byte)(a1 + 70);
            int a2 = 4;
            var b3 = (byte)(a2 + 70);
            Console.WriteLine(b1.GetType() == b2.GetType()); // false
            Console.WriteLine(b1.GetType() == b3.GetType()); // false
            Console.WriteLine(b2.GetType() == b3.GetType()); // true

            int c1 = (a1 + a2);
            byte c2 = (byte)(a1 + a2);
            // ошибка
            //byte c2 = (a1 + a2);

            int a3 = 33;
            int b4 = 600;
            byte c3 = (byte)(a3 + b4); // c = 633 % 256
            Console.WriteLine(c3);

            try
            {
                byte c4 = checked((byte)(a3 + b4));
                Console.WriteLine(c4);
            }
            // Ошибка: Переполнение в результате выполнения арифметической операции
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
