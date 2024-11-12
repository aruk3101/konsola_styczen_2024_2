using System.Data;

namespace konsola_styczen_2024
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static int Licz(string text)
        {
            if (text == null || String.IsNullOrEmpty(text) == true) return 0;

            string samogloski = "aąeęiouóyAĄEĘIOUÓY";
            int i = 0;

            foreach (char znak in text.ToArray())
            {
                if (samogloski.Contains(znak))){
                    i++;
                }
            }
            return i;

        }
    }
}
