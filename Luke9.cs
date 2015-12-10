using System;
using System.Linq;
using System.Text;

namespace Knowit_julekalender
{
    public class Luke9
    {
        public string HentLøsning()
        {
            var sb = new StringBuilder();
            var input = 142453146368L;
            while (input > 0)
            {
                var mod = (input - 1) % 26L;
                sb.Append((char)('A' + mod));
                input = (input - mod) / 26L;
            }
            return new String(sb.ToString().Reverse().ToArray());
        }
    }
}