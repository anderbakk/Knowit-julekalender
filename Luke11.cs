using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Knowit_julekalender
{
    public class Luke11
    {
        private readonly Dictionary<char, int> _romans = new Dictionary<char,int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        public string HentLøsning()
        {
            var content = File.ReadAllLines(@"Filer\Luke11.txt");
            var tuples = new List<Tuple<int, string>>();
            foreach (var line in content)
            {
                if (IsRoman(line))
                {
                    var value = RomanToInteger(line);
                    tuples.Add(new Tuple<int, string>(value, line));
                }
                else if (IsBinary(line))
                    tuples.Add(new Tuple<int, string>(Convert.ToInt32(line.Replace("0b", string.Empty), 2), line));
                else
                    tuples.Add(new Tuple<int, string>(int.Parse(line), line));
            }

            var ordered = tuples.OrderBy(t => t.Item1).ToList();
            return ordered[(ordered.Count /2)].Item2;
        }

        private static bool IsBinary(string line)
        {
            return line.StartsWith("0b");
        }

        private int RomanToInteger(string line)
        {
            var result = 0;

            var left = _romans[line[0]];
            foreach (var right in line.Select(letter => _romans[letter]))
            {
                if (left < right)
                    result += right - left -left;
                else
                    result += right;
                left = right;
            }
            return result;
        }

        private bool IsRoman(string line)
        {
            return _romans.ContainsKey(line[0]);
        }
    }
}