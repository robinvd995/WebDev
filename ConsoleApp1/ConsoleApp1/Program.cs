using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            Increment.inc(ref i);
            Increment.inc(ref i);
            Increment.inc(ref i);
            Increment.inc(ref i);
            Increment.inc(ref i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
