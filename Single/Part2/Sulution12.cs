using System;
using System.Runtime.InteropServices;

//Параметры методов
namespace Single.Part2
{
    public class Solution12
    {
        public static void Execute()
        {
            Math();
            int g = 5;
            int p = 1, s = 5;
            //передача по значению
            Math(p, s);
            
            //передача с получением выходных параметров
            int P, S;
            Math(out P, out S);
            Math(out P, out S, g);
            Math(out P, out S, g, 6);
            Math(out P, out S, g, y:30);
            Console.WriteLine("Значение g = {0}", g);
            
            //передача по ссылке
            Math(ref g, 6);
            Console.WriteLine("Значение g = {0}", g);
            Console.ReadLine();
            
            int x = 10;
            int area;
            int perimetr;
            GetData(x, 15, out area, out perimetr);
            Console.WriteLine("Площадь : " + area);
            Console.WriteLine("Периметр : " + perimetr);
            //C# 7.0
            //int x = 10;
            //GetData(x, 15, out int area, out int perimetr);
            //Console.WriteLine("Площадь : " + area);
            //Console.WriteLine("Периметр : " + perimetr);

            //Именованные параметры
            OptionalParam(x: 2, y: 3);
            //Необязательный параметр z использует значение по умолчанию
            OptionalParam(y: 2, x: 3, s: 10);
            Console.ReadLine();
        }
        static void Math()
        {
            int x = 2;
            int y = 3;
            Console.WriteLine("Сумма {0} + {1} = {2}", x, y, x + y);
        } 
        static void Math(int x, int y)
        {
            Console.WriteLine("Сумма {0} + {1} = {2}", x, y, x + y);
        } 
        //Передача параметров по ссылке и модификатор ref
        static void Math(ref int x, int y = 0)
        {
            x *= x;
            Console.WriteLine("Сумма {0} + {1} = {2}", x, y, x + y);
        }
        //Модификатор out
        static void Math(out int perim, out int area, int x = 10, int y = 10)
        {
          perim = (x + y) * 2;
          area = x * y;
          Console.WriteLine("Периметр ({0} + {1}) * 2 = {2}", x, y, perim);
          Console.WriteLine("Площадь {0} * {1} = {2}", x, y, area);
        }
        //Возврат нескольких парамтеров
        static void GetData(int x, int y, out int area, out int perim)
        {
          area = x * y;
          perim = (x + y)*2; 
        }
        //Именованные параметры
        static int OptionalParam(int x, int y, int z = 5, int s = 4)
        {
          return x + y + z + s;
        }
    }
}