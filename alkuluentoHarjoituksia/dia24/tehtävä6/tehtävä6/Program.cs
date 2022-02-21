using System;
/// @ author Antti Kuusisto
/// version 21.2.2022
/// <summary>
/// Harjoitus. Kirjoitettu alunperin 15.2 tai 16.2. Kommentoitu 21.2. Tästä syystä ei try -> catch ilmausta.
/// </summary>
namespace Tehtava6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä bonus pisteesi ja ne kerrotaan kaavan mukaan."); // toimintaohje käyttäjälle
            tahan: // goto paluukohta
            Console.Write("Syötä pisteesi: "); // kysytään pisteitä
            int lu = int.Parse(Console.ReadLine());
            if(lu == 0 || lu > 9) // tarkastetaan onko syötetyt pisteet alueella
            {
                Console.WriteLine("Luku ulkona alueelta!"); // virhe viesti
                goto tahan; // paluu alkuun
            }
            else if(lu == 1 || lu == 2 || lu == 3) // "vaihtoehto 1"
            {
                Console.WriteLine("Pisteesi: {0}",lu * 10);
            }
            else if(lu == 4 || lu == 5 || lu == 6) // "vaihtoehto 2"
            {
                Console.WriteLine("Pisteesi: {0}", lu * 100);
            }
            else if (lu == 7 || lu == 8 || lu == 9) // "vaihtoehto 3"
            {
                Console.WriteLine("Pisteesi: {0}", lu * 1000);
            }
        }
    }
}