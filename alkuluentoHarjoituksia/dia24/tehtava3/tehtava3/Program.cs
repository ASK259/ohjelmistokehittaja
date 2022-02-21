using System;
/// @ author Antti Kuusisto
/// version 21.2.2022
/// <summary>
/// Harjoitus. Kirjoitettu alunperin 15.2 tai 16.2. Kommentoitu 21.2. Tästä syystä ei try -> catch ilmausta.
/// </summary>

namespace Tehtava3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä luku väliltä 0-9 ja se tulostetaan tekstinä."); // toimintaohje käyttäjälle
            tahan: // goto paluu kohta
            Console.Write("Syötä luku: "); // kysytään lukua
            int lu = int.Parse(Console.ReadLine());
            switch (lu) // luvun tarkastelu switch:llä
            {
                case 0:
                    Console.WriteLine("nolla");
                    break;
                case 1:
                    Console.WriteLine("yksi");
                    break;
                case 2:
                    Console.WriteLine("kaksi");
                    break;
                case 3:
                    Console.WriteLine("kolme");
                    break;
                case 4:
                    Console.WriteLine("neljä");
                    break;
                case 5:
                    Console.WriteLine("viisi");
                    break;
                case 6:
                    Console.WriteLine("kuusi");
                    break;
                case 7:
                    Console.WriteLine("seitsämän");
                    break;
                case 8:
                    Console.WriteLine("kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("yhdeksän");
                    break;
                default: // mikäli luku alueen ulkopuolella
                    Console.WriteLine("Syötetty luku alueen ulkopuolella");
                    goto tahan; // paluu alkuun
                    break;
            }
        }
    }
}