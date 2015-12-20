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
            var power = n.ToString().Length - 1;
            var currentDigit = (int)char.GetNumericValue(n.ToString()[0]);

            if (power == 0)
                return currentDigit >= 2 ? 1 : 0;

            var remaining = long.Parse(n.ToString().Substring(1));

            var twos = power*currentDigit*((long) Math.Pow(10, power - 1));
            twos += RecursiveTwoCounter(remaining);
            if (currentDigit == 2)
                return twos + remaining + 1;
            if (currentDigit > 2)
                return twos + (long) Math.Pow(10, power);
            return twos;
        }
    }

    public class Luke17
    {
        public long HentLøsning()
        {

            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var shiftTime = new DateTime(1814, 5, 17, 13, 37, 14, DateTimeKind.Utc);
            var span = shiftTime - start;
            var endTime = new DateTime(2015, 9, 17, 17, 15, 0, DateTimeKind.Utc);
            var endShiftTime = endTime + span;
            var seconds = (endTime - shiftTime).TotalSeconds;
            return (long)seconds;
        }
    }
}