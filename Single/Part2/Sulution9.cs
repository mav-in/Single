using System;
using System.Runtime.InteropServices;

namespace Single.Part2
{
    public class Solution9
    {
        public static void Execute()
        {
            // МЕТОДЫ
            string message = Hello(); // вызов первого метода
            Console.WriteLine(message);
            Math(); // вызов второго метода
            int g = 5;
            int P, S;
            Math(out P, out S);
            Math(out P, out S, g);
            Math(out P, out S, g, 6);
            Math(out P, out S, g, y:30);
            Console.WriteLine("Значение g = {0}", g);
            Math(ref g, 6);
            Console.WriteLine("Значение g = {0}", g);
            Console.ReadLine();
        }

        static string Hello()
        {
            return "Hell to World!";
        }
        static void Math()
        {
            int x = 2;
            int y = 3;
            Console.WriteLine("Сумма {0} + {1} = {2}", x, y, x + y);
        } 

        static void Math(out int perim, out int area, int x = 10, int y = 10)
        {
            perim = (x + y) * 2;
            area = x * y;
            Console.WriteLine("Периметр ({0} + {1}) * 2 = {2}", x, y, perim);
            Console.WriteLine("Площадь {0} * {1} = {2}", x, y, area);
        }

        static void Math(ref int x, int y = 0)
        {
            x *= x;
            Console.WriteLine("Сумма {0} + {1} = {2}", x, y, x + y);
        }
    }
}