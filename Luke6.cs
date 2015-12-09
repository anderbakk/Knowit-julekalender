namespace Knowit_julekalender
{
    public class Luke6
    {
        private int _antall = 0;

        public int HentL�sning()
        {
            GenererParenteser(13, 0, 0);
            return _antall;
        }

        public void GenererParenteser(int par, int lukket, int �pen)
        {
            if (lukket == par)
            {
                _antall++;
                return;
            }

            if (�pen < par)
            {
                GenererParenteser(par, lukket, �pen + 1);
            }

            if (lukket < �pen)
            {
                GenererParenteser(par, lukket + 1, �pen);
            }
        }
    }
}