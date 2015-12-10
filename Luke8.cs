using System;
using System.Collections.Generic;
using System.Linq;

namespace Knowit_julekalender
{
    public class Luke8
    {
        public object HentLøsning()
        {
            var mirps = new List<int>();
            for (var i = 3; i < 1000; i = i + 2)
                if (!IsPalindrome(i) && IsPrime(i) && IsPrime(ReversesNumber(i)))
                    mirps.Add(i);
            return mirps.Count;
        }

        private static int ReversesNumber(int i)
        {
            return int.Parse(new String(i.ToString().Reverse().ToArray()));
        }

        private static bool IsPalindrome(int i)
        {
            return i == ReversesNumber(i);
        }

        private static bool IsPrime(int i)
        {
            if (i % 2 == 0)
                return false;
            var sqr = Math.Sqrt(i);
            var prime = true;
            for (var j = 3; j <= sqr; j = j + 2)
            {
                var mod = i % j;
                if (mod != 0) continue;
                prime = false;
                break;
            }
            return prime;
        }
    }
}