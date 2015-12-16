using System.Collections.Generic;

namespace Knowit_julekalender
{
    public class Luke15
    {
        public string HentLøsning()
        {
            var kart = HentKart();
            var celle = 11;
            var sti = new List<string>();
            while (true)
            {
                var tekst = celle.ToString();
                var nesteCelle = kart[int.Parse(tekst[0].ToString()), int.Parse(tekst[1].ToString())];
                sti.Add(tekst);
                if (celle == nesteCelle)
                    break;
                celle = nesteCelle;
            }

            return string.Join(",", sti);
        }

        private static int[,] HentKart()
        {
            var kart = new int[6, 6];
            kart[1, 1] = 34;
            kart[1, 2] = 21;
            kart[1, 3] = 32;
            kart[1, 4] = 41;
            kart[1, 5] = 25;

            kart[2, 1] = 14;
            kart[2, 2] = 42;
            kart[2, 3] = 43;
            kart[2, 4] = 14;
            kart[2, 5] = 31;

            kart[3, 1] = 54;
            kart[3, 2] = 45;
            kart[3, 3] = 52;
            kart[3, 4] = 42;
            kart[3, 5] = 23;

            kart[4, 1] = 33;
            kart[4, 2] = 15;
            kart[4, 3] = 51;
            kart[4, 4] = 31;
            kart[4, 5] = 35;

            kart[5, 1] = 21;
            kart[5, 2] = 52;
            kart[5, 3] = 33;
            kart[5, 4] = 13;
            kart[5, 5] = 23;
            return kart;
        }
    }
}