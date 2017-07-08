using System;

//Работа с консолью и класс Console
namespace Single.Part2
{
    public class Solution19
    {
        public static void Execute()
        {
            // РАБОТА С КОНСОЛЬЮ И КЛАСС CONSOLE

            // установка зеленого цвета шрифта
            Console.Title = "Работа с консолью";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Gray;

            try
            {
                do
                {
                    Console.WriteLine("Введите первое число");
                    int num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма чисел {0} и {1} равна {2}", num1, num2, num1 + num2);

                    Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую другую клавишу");
                    Console.Clear();
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.Beep(1000, 500);
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

//Класс Console представляет ряд методов для взаимодействия с консолью:
//    Beep: подача звукового сигнала
//    Clear: очистка консоли
//    WriteLine: вывод строки текста, включая символ возврата каретки(то есть с переводом на новую строку)
//    Write: вывод строки текста, но без символа возврата каретки
//    ReadLine: считывание строки текста со входного потока
//    Read: считывание введенного символа в виде числового кода данного символа.С помощью преобразования к типу char мы можем получить введенный символ
//    ReadKey: считывание нажатой клавиши клавиатуры(ConsoleKeyInfo key = Console.ReadKey();)

//Кроме того, класс Console обладает свойствами, которые позволяют управлять консолью.Некоторые из них:
//    BackgroundColor: цвет фона консоли
//    ForegroundColor: цвет шрифта консоли
//    BufferHeight: высота буфера консоли
//    BufferWidth: ширина буфера консоли
//    Title: заголовок консоли
//    WindowHeight и WindowWidth: высота и ширина консоли соответственно
