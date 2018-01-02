using System;

namespace Single.Part3
{
    public class Solution04
    {
        public static void Execute()
        {
            // СВОЙСТВА И ИНКАПСУЛЯЦИЯ

            Person p = new Person("Tom", 24);

            Console.WriteLine(p.Name); // Tom
            Console.WriteLine(p.Sum);  // 100
            Console.WriteLine(p.Sex);  // 'M'

            // Ошибка - set объявлен с модификатором private
            //p.Name = "John";

            Console.WriteLine(p.Name);
        }

        class Person
        {
            private string _name;
            private int _age;
            // Автоматическое свойство, начинаяс C# 6.0
            public int Sum { get; private set; } = 100;
            public char Sex { get; set; } = 'M';
            public int IQ { get; set; } = 90;

            public Person(string _name, int _age)
            {
                Name = _name;
                Age = _age;
            }

            public string Name
            {
                get { return _name; }
                private set { _name = value; }
            }

            private int Age
            {
                get { return _age; }
                set
                {
                    if (value < 18) {
                        Console.WriteLine("Возраст должен быть больше 18");
                    }
                    else {
                        _age = value;
                    }
                }
            }

            private string _count;
            // свойство только для чтения
            public string Count
            {
                get
                {
                    return _count;
                }
            }

            private int _move;
            // свойство только для записи
            public int Move
            {
                set
                {
                    _move = value;
                }
            }
        }
    }
}
