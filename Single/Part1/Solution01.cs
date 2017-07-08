using System;

//Начало работы. Visual Studio
namespace Single.Part1
{
    public class Solution01
    {
        public static void Execute()
        {
            //non-static
            //var calc = new Calculator();
            //calc.Add(2, 3);

            //static
            Calculator.Add(2, 3);
            Console.ReadKey();
        }
    }

    internal class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, z);
            Console.ReadLine();
        }
    }
}
