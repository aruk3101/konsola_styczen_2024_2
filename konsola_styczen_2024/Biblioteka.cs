using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola_styczen_2024
{

    public static class Biblioteka
    {
        public static int Licz(string text)
        {
            if (text == null || String.IsNullOrEmpty(text) == true) return 0;

            string samogloski = "aąeęiouóyAĄEĘIOUÓY";
            int i = 0;

            foreach (char znak in text.ToArray())
            {
                if (samogloski.Contains(znak))
                {
                    i++;
                }
            }
            return i;

        }

        public static string UsunPowtorzenia(string tekst)
        {
            if (string.IsNullOrEmpty(tekst))
            {
                return string.Empty;
            }
            return new string(tekst.ToArray()
                .GroupBy(znak => znak)
                .Select(grupa => grupa.Key)
                .ToArray());
        }
    }
}
