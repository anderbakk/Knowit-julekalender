using System;

namespace Knowit_julekalender
{
    public class Luke17
    {
        public long HentLøsning()
        {
            var start = new DateTime(1814, 5, 17, 13, 37, 14, DateTimeKind.Utc);
            var slutt = new DateTime(2015, 9, 17, 17, 15, 0, DateTimeKind.Utc);
            return (long) (slutt - start).TotalSeconds;
        }
    }
}