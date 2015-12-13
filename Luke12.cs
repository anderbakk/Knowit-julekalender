namespace Knowit_julekalender
{
    public class Luke12
    {
        public long HentLøsning()
        {
            var result = 0L;
            for (long i = 7; i <= 100000000; i = i+7)
            {
                if (i%5 != 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}