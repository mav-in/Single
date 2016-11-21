using System;
using Single.Part1;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            Solution1.Execute();
        }
    }
}
