using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Knowit_julekalender
{
    public class Luke2
    {
        public float HentLøsning()
        {
            var fileContent = File.ReadAllLines("Filer\\Luke2.txt");

            var maxEarning = 0f;
            for (var i = 0; i < fileContent.Length - 1; i++)
            {
                var buyPrice = float.Parse(fileContent[i], CultureInfo.CreateSpecificCulture("en-US"));

                for (var j = i; j < fileContent.Length; j++)
                {
                    var sellPrice = float.Parse(fileContent[j], CultureInfo.CreateSpecificCulture("en-US"));

                    var earning = sellPrice - buyPrice;
                    if (earning > maxEarning)
                        maxEarning = earning;
                }
            }

            return maxEarning;
        }
    }
}