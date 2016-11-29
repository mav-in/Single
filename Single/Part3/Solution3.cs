using System;

namespace Single.Part3
{
    public class Solution3
    {
        const double PI = 3.14;
        const double E = 2.71;

        public static void Execute()
        {
            // КОНСТАНТЫ И ПОЛЯ ДЛЯ ЧТЕНИЯ

            const double PI = 3.1415;
            const double E = 2.71;

            //MathLib.E = 3.8; // константу нельзя установить несколько раз

            Console.WriteLine(MathLib.PI); // 3.1415

            MathLib mathLib = new MathLib(3.8);
            Console.WriteLine(mathLib.K); // 3.8

            //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса
            Console.ReadLine();
        }

        class MathLib
        {
            //Константы
            public const double PI = 3.141;
            public const double E = 2.81;
            //public const double K;

            //Поля для чтения
            public readonly double K;

            //Для чтения с использование только геттера
            private double _m;
            public double M
            {
                get { return _m; }
            }

            public MathLib()
            {
                _m = 31.1786;
                //K = 2.5; // ошибка - константа должна быть определена до компиляции
            }

            public MathLib(double _k)
            {
                K = _k; // поле для чтения может быть определено после компиляции
            }
        }
    }
}
