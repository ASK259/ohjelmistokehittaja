using System;
/// @ author Antti Kuusisto
/// version 21.2.2022
/// <summary>
/// Harjoitus. Kirjoitettu alunperin 15.2 tai 16.2. Kommentoitu 21.2. Tästä syystä ei try -> catch eikä goto ilmauksia.
/// </summary>
namespace Tehtava2
{
    class Program
    {
        static void Main()
        {
            int[] luvut = new int[3]; // luodaan Array, johon luvut tulevat
            Console.WriteLine("Anna kolme(3) lukua ja niistä tulostetaan suurin."); // toimintaohje käyttäjälle
            Console.Write("Anna 1. luku: "); // kysytään lukua nro. 1.
            luvut[0] = int.Parse(Console.ReadLine( ));
            Console.Write("Anna 2. luku: "); // kysytään lukua nro. 2.
            luvut[1] = int.Parse(Console.ReadLine( ));
            Console.Write("Anna 3. luku: "); // kysytään lukua nro. 3.
            luvut[2] = int.Parse(Console.ReadLine( ));
            Console.WriteLine(luvut.Max());  // etsitään ja tulostetaan suurin luku
        }
    }
}