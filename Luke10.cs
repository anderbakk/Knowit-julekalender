using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Knowit_julekalender
{
    public class Luke10
    {
        public float HentLøsning()
        {
            var fileContent = File.ReadAllLines("Filer\\Luke2.txt");

            var possibleEarnings = new List<Earning>();

            for (var i = 0; i < fileContent.Length - 1; i++)
            {
                var buyPrice = float.Parse(fileContent[i], CultureInfo.CreateSpecificCulture("en-US"));

                for (var j = i; j < fileContent.Length; j++)
                {
                    var sellPrice = float.Parse(fileContent[j], CultureInfo.CreateSpecificCulture("en-US"));

                    var earning = sellPrice - buyPrice;
                    if (earning > 0)
                        possibleEarnings.Add(new Earning {BuyDay = i, SellDay = j, Earned = earning});
                }
            }
            var maxEarning = 0f;

            var ordered = possibleEarnings.OrderByDescending(e => e.Earned).ToArray();
            Parallel.For(0, ordered.Length - 1, i =>
            {
                for (var j = i + 1; j < ordered.Length; j++)
                {
                    if (ordered[j].BuyDay > ordered[i].BuyDay &&
                        ordered[j].BuyDay > ordered[i].SellDay)
                    {
                        var earning = ordered[i].Earned + ordered[j].Earned;
                        if (earning > maxEarning)
                            maxEarning = earning;
                    }
                }
            });
            return maxEarning;
        }
    }

    public class Earning
    {
        public int BuyDay { get; set; }
        public int SellDay { get; set; }
        public float Earned { get; set; }
    }
}