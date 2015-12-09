﻿using System;
using System.Collections.Generic;

namespace Knowit_julekalender
{
    class Program
    {
        static void Main()
        {
            var løsninger = new List<Func<object>>
            {
                () => new Luke1().HentLøsning(),
                () => new Luke2().HentLøsning(),
                () => new Luke3().HentLøsning(),
                () => new Luke4().HentLøsning(),
                () => new Luke5().HentLøsning(),
                () => new Luke6().HentLøsning(),
            };

            Console.WriteLine("Angi luke (1 - 24)");
            
            var luke = int.Parse(Console.ReadLine()?? string.Empty);
            var løsning = løsninger[luke - 1].Invoke();
            Console.WriteLine("Luke {0}: {1}",luke, løsning);

            Console.Read();
        }
    }
}
