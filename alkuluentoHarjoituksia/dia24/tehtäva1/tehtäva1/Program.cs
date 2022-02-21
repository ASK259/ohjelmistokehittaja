using System;
/// @ author Antti Kuusisto
/// version 21.2.2022
/// <summary>
/// Harjoitus. Kirjoitettu alunperin 15.2 tai 16.2. Kommentoitu 21.2. Tästä syystä ei try -> catch eikä goto ilmauksia.
/// </summary>
namespace Tehtava1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä kaksi lukua ja ne tulostetaan suuruusjärjestyksessä."); // toiminta ohje käyttäjälle
            Console.Write("Annna 1. luku: "); // kysytään lukua nro. 1.
            int lu1 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: "); // kysytään lukua nro. 2.
            int lu2 = Int32.Parse(Console.ReadLine());
            if (lu1 > lu2) // Verrataan lukuja keskenään
            {
                Console.WriteLine("{0} {1}",lu1, lu2); // tulostetaan vastaus
            }
            else if (lu1 < lu2) // Verrataan lukuja keskenään
            {
                Console.WriteLine("{0} {1}", lu2, lu1); // tulostetaan vastaus
            }
        }
    }
}
