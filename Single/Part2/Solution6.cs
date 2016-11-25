using System;

namespace Single.Part2
{
    public class Solution6
    {
        public static void Execute()
        {
            // УСЛОВНЫЕ КОСТРУКЦИИ

            // конструкция if / else
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine("Число {0} больше числа {1}", num1, num2);
            }

            if (num1 > num2)
            {
                Console.WriteLine("Число {0} больше числа {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("Число {0} меньше числа {1}", num1, num2);
            }

            if (num1 > num2)
            {
                Console.WriteLine("Число {0} больше числа {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Число {0} меньше числа {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }

            if (num1 > num2 && num1 == 8)
            {
                Console.WriteLine("Число {0} больше числа {1}, и число {0} равно 8", num1, num2);
            }

            // switch
            Console.WriteLine("Нажмите Y или N");
            string selection1 = Console.ReadLine();
            switch (selection1)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            // switch goto
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5; // переход к case 5
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // Тернарная операция
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection2 = Console.ReadLine();

            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
        }
    }
}
