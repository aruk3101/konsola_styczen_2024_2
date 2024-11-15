using System.Data;

namespace konsola_styczen_2024
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Witaj w programie narzędziowym do pracy z łańcuchami znaków!");

            Console.Write("Podaj łańcuch znaków: ");
            string tekst = Console.ReadLine() ?? "";

            int liczbaSamoglosek = Biblioteka.Licz(tekst);
            Console.WriteLine($"Liczba samogłosk w łańcuchu: {liczbaSamoglosek}");

            string tekstBezPowtorzen = Biblioteka.UsunPowtorzenia(tekst);
            Console.WriteLine($"Łańcuch po usunięciu powtórzeń: {tekstBezPowtorzen}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}

