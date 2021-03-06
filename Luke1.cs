﻿using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Knowit_julekalender
{
    public class Luke1
    {
        public int HentLøsning()
        {
            var content = File.ReadAllLines("Filer\\Luke1.txt");
            return content.Count(line => Regex.IsMatch(line, @"^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}$"));
        }
    }
}