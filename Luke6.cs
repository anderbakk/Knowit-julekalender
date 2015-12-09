namespace Knowit_julekalender
{
    public class Luke6
    {
        private int _antall = 0;

        public int HentLøsning()
        {
            GenererParenteser(13, 0, 0);
            return _antall;
        }

        public void GenererParenteser(int par, int lukket, int åpen)
        {
            if (lukket == par)
            {
                _antall++;
                return;
            }

            if (åpen < par)
            {
                GenererParenteser(par, lukket, åpen + 1);
            }

            if (lukket < åpen)
            {
                GenererParenteser(par, lukket + 1, åpen);
            }
        }
    }
}