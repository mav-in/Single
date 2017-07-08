using System;

//Типы значений и ссылочные типы
namespace Single.Part2
{
    public class Solution20
    {
        public static void Execute()
        {
            // ТИПЫ ЗНАЧЕНИЙ И ССЫЛОЧНЫЕ ТИПЫ

            State state0 = new State(); // State - структура, ее данные размещены в стеке
            Country country0 = new Country(); // Country - класс, в стек помещается ссылка на адрес в хипе
                                              // а в хипе располагаются все данные объекта country1

            State state1 = new State(); // Структура State
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2;
            state2.x = 5; // state1.x=1 по-прежнему
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5

            Country country1 = new Country(); // Класс Country
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country1 = country2;
            country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
                            // указывают на один объект в хипе
            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7

            // Ссылочные типы внутри типов значений

            StateCountry stateC1 = new StateCountry();
            StateCountry stateC2 = new StateCountry();

            stateC2.country = new Country();
            stateC2.country.x = 5;
            stateC1 = stateC2;
            stateC2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                                  // указывают на один объект в хипе
            Console.WriteLine(stateC1.country.x); // 8
            Console.WriteLine(stateC2.country.x); // 8

            // Объекты классов как параметры методов

            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            ChangePerson(ref p);

            Console.WriteLine(p.name); // Bill
            Console.WriteLine(p.age); // 45

            Console.Read();
        }

        struct State
        {
            public int x;
            public int y;
        }

        class Country
        {
            public int x;
            public int y;
        }

        struct StateCountry
        {
            public int x;
            public int y;
            public Country country;
        }

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void ChangePerson(ref Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает
            person = new Person { name = "Bill", age = 45 };
        }

        class Person
        {
            public string name;
            public int age;
        }
    }
}
