/*начало секции подключаемых пространств имен*/
using System;
//using System.Collections.Generic; /*Вложенное пространство имён*/
//using Single.Part1;
using Solution = Single.Part3.Solution01;

/*конец секции подключаемых пространств имен*/

namespace Single /*объявление нового пространства имен*/
{
    class Program /*объявление нового класса*/
    {
        // начало контекста метода Main
        static void Main(string[] args) /*объявление нового метода*/
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            Solution.Execute();
            Console.ReadLine();
        } /* конец объявления нового метода*/

    } /* конец объявления нового класса*/

} /* конец объявления нового пространства имен*/