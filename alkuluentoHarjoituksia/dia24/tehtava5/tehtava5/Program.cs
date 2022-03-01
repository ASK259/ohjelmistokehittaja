using System;

namespace Tehtava5
{
    class Program
    {
        static void Main()
        {   
            alku:
            Console.WriteLine("Minkä arvon haluat syöttää? merkkijono, luku vai double-luku?");
            Console.Write("Syötä arvon tyyppi(merkkijono,luku tai double-luku)");
            string ar = Console.ReadLine();
            double doLu;
            string te;
            int lu;
            if (ar == "merkkijono" || ar == "luku" || ar == "double-luku")
            {
                switch (ar)
                {
                    case "merkkijono":
                        Console.Write("Kirjoita sana/lause: ");
                        te = Console.ReadLine();
                        te += "*";
                        Console.WriteLine(te);
                        break;
                    case "luku":
                        lualku:
                        Console.Write("Anna kokonaisluku: ");
                        try
                        {
                            lu = int.Parse(Console.ReadLine());
                            Console.WriteLine("Annoit luvun: " + lu + " Tulos on: " + (lu + 1));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Et syöttänyt kokonaislukua. Syötä kokonaisluku.");
                            goto lualku;
                        }
                        break;
                    case "double-luku":
                    doalku:
                        Console.Write("Anna double-luku: ");
                        try
                        {
                            doLu = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Annoit luvun: " + doLu + " Tulos on: " + (doLu + 1));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Et syöttänyt double-lukua. Syötä double-luku.");
                            goto doalku;
                        }
                        break;
                        default:
                        {
                            Console.WriteLine("Tapahtui odottamaton virhe. Yritä uudestaan.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Et kirjoittanut syöttöarvontyyppiä(merkkijono,luku tai double-luku).");
                goto alku;
            }
        }
    }
}