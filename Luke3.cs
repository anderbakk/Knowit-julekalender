namespace Knowit_julekalender
{
    public class Luke3
    {
        public int HentLøsning()
        {
            var currentWeekDay = 5;
            var result = 0;
            for (var year = 1; year <= 2015; year++)
            {
                var daysInYear = ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? 366 : 365;
                for (var dayInYear = 0; dayInYear <= daysInYear; dayInYear++) 
                {
                    if (dayInYear == 256 && currentWeekDay == 5)
                        result++;

                    currentWeekDay = currentWeekDay < 7 ? currentWeekDay + 1 : 1;
                }
            }
            return result;
        }
    }
}