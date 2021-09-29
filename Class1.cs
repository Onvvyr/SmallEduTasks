using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Potegowanie
    {
        public int Power(int a, int b)
        {
            int wynik = 1;
            for (int i = b; i > 0; i--)
            {
                wynik = wynik * a;
            }
            return wynik;
        }
    }
}
