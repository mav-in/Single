using System;
using System.Dynamic;

namespace Single.Part3
{
    public class Solution6
    {
        public static void Execute()
        {
            // СТАТИЧЕСКИЕ ЧЛЕНЫ И МОДИФИКАТОР ТИПА STATIC

            // Не обязательно создавать, объект класса, если требуется доступ к статическим методам

            int num1 = Algorithm.Factorial(5);
            int num2 = Algorithm.Fibonachi(5);

            // Эквивалентно
            //Algorithm algorithm1 = new Algorithm();
            //Algorithm algorithm2 = new Algorithm();
            // объекты будут хранить ссылку на общий участов в памяти

            Algorithm.PI = 3.14159;

            State state1 = new State();
            State state2 = new State();
            State state3 = new State();
            State state4 = new State();

            State.DisplayCounter(); // 4
            state4 = new State();
            State.DisplayCounter(); // 5

            Build s1 = new Build(); // здесь сработает статический конструктор
            Build s2 = new Build();

            Ship.Counter = 100;
            Console.WriteLine(Ship.Counter);

            Console.Read();
        }
    }

    class Algorithm
    {
        public static double PI = 3.1415;

        public static int Factorial(int x) {
            if (x == 1) {
                return 1;
            }
            return x * Factorial(x - 1);
        }
 
        public static int Fibonachi(int x)
        {
            if (x == 0) {
                return 1;
            }
            if (x == 1) {
                return 1;
            }
            return Fibonachi(x - 1) + Fibonachi(x - 2);
        }
    }

    // Класс со счётчиком созданных объектов
    class State
    {
        private static int counter = 0;
        public State() {
            counter++;
        }

        ~State() {
            counter--;
        }

        public static void DisplayCounter() {
            Console.WriteLine("Создано {0} объектов State", counter);
        }
    }

    // Класс со статическим конструктором
    class Build
    {
        static Build()
        {
            Console.WriteLine("Создано первое здание");
        }
    }

    // Статический класс может содержать только статические поля и методы
    static class Ship
    {
        private static int counter = 0;

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        static Ship()
        {
            Console.WriteLine("Создан первый объект");
        }
    }
}
