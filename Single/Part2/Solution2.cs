using System;

namespace Single.Part2
{
    // начало контекста класса
    public class Solution2
    {
        // переменная уровня класса
        static int a = 9;

        // начало контекста метода Execute
        public static void Execute()
        {
            // переменная уровня метода
            int b = a - 1;

            { // начало контекста блока кода
                // переменная уровня блока кода
                int c = b - 1;
            } // конец контекста блока кода, переменная с уничтожается

            // так нельзя, переменная c определена в блоке кода
            //Console.WriteLine(c);

            // так нельзя, переменная d определена в другом методе
            //Console.WriteLine(d);

            Display();
        } // конец контекста метода Execute, переменная b уничтожается

        static void Display() // начало контекста метода Display
        {
            // переменная a определена в контексте класса, поэтому доступна
            int d = a + 1;
            var e = new InternalClass().d;
            InternalClass.InternalDisplay();
        } // конец конекста метода Display, переменные d и e уничтожаются
    } // конец контекста класса, переменная a уничтожается

    // начало контекста внутреннего класса
    internal class InternalClass
    {
        // переменная d определена в контексте класса как публичная, поэтому доступна
        public int d = 1;

        public static void InternalDisplay() // начало контекста метода InternalDisplay
        {
            int a = 5; // скрывает переменную a, которая объявлена на уровне класса
            Console.WriteLine(a); // 5
            // работать не будет
            //Console.WriteLine(this.a);
        }
    } // конец внутреннего контекста класса, переменная d уничтожается
}
