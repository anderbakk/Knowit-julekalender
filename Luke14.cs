using System.Text;
using System.Text.RegularExpressions;

namespace Knowit_julekalender
{
    public class Luke14
    {
        public int HentLøsning()
        {
            var count = 0;
            for (var i = 0; i <= 100000; i++)
                if (i == Flip(i))
                    count++;
            return count;
        }

        private static int Flip(int num)
        {
            var asString = num.ToString();
            if (!Regex.IsMatch(asString, @"^[0,1,6,8,9]{0,}$"))
                return -1;
            var newString = new StringBuilder();
            for (var i = asString.Length - 1; i >= 0; i--)
            {
                var cchar = asString[i];
                if (cchar == '6') cchar = '9';
                else if (cchar == '9') cchar = '6';
                newString.Append(cchar);
            }
            return int.Parse(newString.ToString());
        }
    }
}