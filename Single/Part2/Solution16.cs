using System;

//Перечисления enum
namespace Single.Part2
{
    public class Solution16
    {
        public static void Execute()
        {
            // ПЕРЕЧИСЛЕНИЯ

            // Тип операции задаем с помощью константы Operation.Add, которая равна 1
            MathOp(10, 5, Operation.Add);
            // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
            MathOp(11, 5, Operation.Multiply);

            Console.ReadLine();
        }

        static void MathOp(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }

        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        enum Operation_v2
        {
            Add = 2,
            Subtract = 4,
            Multiply = 8,
            Divide = 16
        }

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
    }
}
