using System;

namespace Knowit_julekalender
{
    public class Luke16
    {
        public long HentLøsning()
        {
            return (RecursiveTwoCounter(12345678987654321));
        }

        private static long RecursiveTwoCounter(long n)
        {
            var nstring = n.ToString();
            var power = nstring.Length - 1;
            var currentDigit = (int) char.GetNumericValue(nstring[0]);

            if (power == 0)
                return currentDigit >= 2 ? 1 : 0;

            var remaining = long.Parse(nstring.Substring(1));

            var twos = power *currentDigit* ((long)Math.Pow(10, power - 1));
            twos += RecursiveTwoCounter(remaining);
            if (currentDigit == 2)
                return twos + remaining + 1;
            if (currentDigit > 2)
                return twos + (long) Math.Pow(10, power);
            return twos;
        }
    }
}