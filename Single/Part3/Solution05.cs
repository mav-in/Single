using System;

namespace Single.Part3
{
    public class Solution05
    {
        public static void Execute()
        {
            //ПЕРЕГРУЗКА МЕТОДОВ И ОПЕРАТОРОВ
            //Список перегружаемых операторов:
            //http://msdn.microsoft.com/ru-ru/library/8edha89s.aspx

            State s1 = new State { Name = "State1", Area = 300, Population = 100 };

            State s2 = new State { Name = "State2", Area = 200, Population = 70 };

            if (s1 > s2) {
                Console.WriteLine("Государство s1 больше государства s2");
            }
            else if (s1 < s2) {
                Console.WriteLine("Государство s1 меньше государства s2");
            }
            else {
                Console.WriteLine("Государства s1 и s2 равны");
            }

            State s3 = s1 + s2;
            Console.WriteLine("Название государства : {0}", s3.Name);
            Console.WriteLine("Площадь государства : {0}", s3.Area);
            Console.WriteLine("Население государства : {0}", s3.Population);

            State state = new State { Name = "State3" };
            GetStateName(state);

            Console.ReadLine();
        }

        public class State
        {
            public string Name { get; set; } // название
            public int Population { get; set; } // население
            public double Area { get; set; } // площадь

            //ПЕРЕГРУЗКА ОПЕРАТОРОВ

            public static State operator +(State s1, State s2)
            {
                string name = s1.Name;
                int people = s1.Population + s2.Population;
                double area = s1.Area + s2.Area;

                // возвращаем новое объединенное государство
                return new State { Name = name, Area = area, Population = people };
            }

            public static bool operator <(State s1, State s2)
            {
                if (s1.Area < s2.Area) {
                    return true;
                }
                return false;
            }

            public static bool operator >(State s1, State s2)
            {
                if (s1.Area > s2.Area)
                {
                    return true;
                }
                return false;
            }
        }

        public void Attack(State enemy)
        {
            // здесь код метода
        }
        public void Attack(State enemy, int army)
        {
            // здесь код метода
        }

        public static void GetStateName(State st)
        {
            Console.WriteLine(st.Name);
        }
    }
}
