using System;
using System.Linq;

namespace Knowit_julekalender
{
    public class Luke7
    {
        public int HentLøsning()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i = i + 7)
            {
                if (int.Parse(new String(i.ToString().Reverse().ToArray())) % 7 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}