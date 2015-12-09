using System;
using System.IO;
using System.Linq;

namespace Knowit_julekalender
{
    public class Luke5
    {
        public int HentLøsning()
        {
            var words = File.ReadAllLines("Luke5.txt");

            var list = words.Select(word => new String(word.OrderBy(c => c).ToArray())).ToList();
            var grouped = list.GroupBy(x => x);
            return grouped.Where(@group => @group.Count() > 1).Sum(@group => @group.Count());
        }
    }
}