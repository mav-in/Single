using System;

namespace Single.Part1
{
    public class Solution1
    {
        public static void Execute()
        {
            var calc = new Calculator();
            calc.Add(2, 3);
        }
    }

    internal class Calculator
    {
        public void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, z);
            Console.ReadLine();
        }
    }
}
