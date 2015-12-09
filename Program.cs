using System;

namespace Knowit_julekalender
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Luke 1: {0}",new Luke1().Antall());
            Console.WriteLine("Luke 2: {0}",new Luke2().Antall());
            Console.WriteLine("Luke 3: {0}",new Luke3().Antall());

            Console.Read();
        }
    }
}
