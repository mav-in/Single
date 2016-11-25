using System;
using System.IO;

namespace Single.Part2
{
    public class Solution14
    {
        public static void Execute()
        {
            // ОБРАБОТКА ИСКЛЮЧЕНИЙ

            int[] a = new int[4];
            Console.Write("Ввведите размерность массива: ");
            try {
                int n;
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out n)) {
                    n *= n;
                    Console.WriteLine("Квадрат числа: " + n);
                }
                else {
                    Console.WriteLine("Некорректный ввод");
                }
                //int n = Convert.ToInt32(Console.ReadLine()); // Тут может возникнуть исключение
                if (n <= 0) {
                    throw new Exception("Задан размер массива менее 1-го элемента");
                }
                a[n] = 4; // Тут может возникнуть исключение
                Console.WriteLine("Завершение блока try");
            }
            catch (FileNotFoundException ex)
            {
                // Обработка исключения, возникшего при отсутствии файла
            }
            catch (IOException ex)
            {
                // Обработка исключений ввода-вывода
            }
            catch (Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally {
                Console.WriteLine("Блок finally");
            }
            Console.ReadLine();

            // VS2015 Фильтры исключений
            int x = 1;
            int y = 0;

            try {
                int result = x / y;
                Console.WriteLine(result);
            }
            catch (Exception ex) when (y == 0) {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
