using System;

//Арифметические операции языка C#
namespace Single.Part2
{
    public class Solution02
    {
        public static void Execute()
        {
            var dt = new DataType2();
            dt.Run();
            //DataType2.Run();
        }
    }

    internal class DataType2
    {
        public void Run()
        {
          // +
          int ix = 10;
          int iz = ix + 12; // 22

          // -
          ix = 10;
          iz = ix - 6; // 4

          // *
          ix = 10;
          iz = ix * 5; // 50

          // /
          ix = 10;
          iz = ix / 5; // 2

          double da = 10;
          double db = 3;
          double dc = da / db; // 3.33333333

          double dz = 10 / 4; //результат равен 2

          dz = 10.0 / 4.0; //результат равен 2.5

          // %
          double dx = 10.0;
          dz = dx % 4.0; //результат равен 2

          // ++
          int x1 = 5;
          int z1 = ++x1; // z1=6; x1=6
          Console.WriteLine(@"{x1} - {z1}");
 
          int x2 = 5;
          int z2 = x2++; // z2=5; x2=6
          Console.WriteLine(@"{x2} - {z2}");

          // -
          x1 = 5;
          z1 = --x1; // z1=4; x1=4
          Console.WriteLine(@"{x1} - {z1}");
 
          x2 = 5;
          z2 = x2--; // z2=5; x2=4
          Console.WriteLine(@"{x2} - {z2}");

          //Набор операций 
          int a = 3;
          int b = 5;
          int c = 40;
          // int d = (c--)-(b*a);
          int d = c---b*a;    // a=3  b=5  c=39  d=25
          Console.WriteLine(@"a={a}  b={b}  c={c}  d={d}");

          a = 3;
          b = 5;
          c = 40;
          d = (c-(--b))*a;    // a=3  b=4  c=40  d=108
          Console.WriteLine(@"a={a}  b={b}  c={c}  d={d}");

          x1 = 2 + 4; // результат равен 6
          x2 = 10 - 6; //результат равен 4
          int x3 = 10 * 6; //результат равен 60
          double x4 = 10.0 / 4.0; //результат равен 2.5
          double x5 = 10.0 % 4.0; //результат равен 2
          int y1 = 5;
          z1 = ++y1; // z1=6; y1=6
          int y2 = 5;
          z2 = y2++; // z2=5; y2=6
          int y3 = 5;
          int z3 = --y3; // z3=4; y3=4
          int y4 = 5;
          int z4 = y4--; // z4=5; y4=4

          //Сложение строк
          string hello1 = "hello " + "world"; //результат равен "hello world"
          string hello2 = "hello " + 4 + " you"; //результат равен "hello 4 you"
        }
    }
}