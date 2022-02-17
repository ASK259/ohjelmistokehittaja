using System;

namespace Harjoituksia
{
    class Program
    {
        static void Main()
        {
            alku:
            string kyLu;
            int taLu;
            Console.WriteLine("Valitse seuraavista haluamasi ohjelma");
            Console.WriteLine("1. laskee kaksi numeroa yhteen.");
            Console.WriteLine("2. muuttaa Celsius-asteet Fahrenheiteiksi");
            Console.WriteLine("3. tekee annetulle luvulle peruslaskutoimitukset.");
            Console.WriteLine("4. palauttaa annetun luvun jakojäännöksen.");
            Console.WriteLine("5. pyytää käyttäjän nimen ja palauttaa viestin.");
            Console.WriteLine("6. laskee yhteen kaksi annettua lukua.");
            Console.WriteLine("7. anna Celsius-arvo ja se muutetaan Fahrenheiteiksi.");
            Console.WriteLine("8. anna 2. lukua, joille tehdään peruslaskutoimitukset.");
            Console.WriteLine("9. anna 2. lukua, joista palautetaan jakojäännös.");
            Console.WriteLine("10. anna luku väliltä 1-10 se tulostetaan kertotauluksi");
            Console.Write("Anna ohjelmanluku, jonka haluat suorittaa: ");
            kyLu = Console.ReadLine();
            try
            {
                taLu = Int32.Parse(kyLu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Et antanut käyttökelpoista arvoa!");
                goto alku;
            }
            switch (taLu)
            {
                case 1:
                    KaksiNumeroaYhteen(8,8);
                    break;
                case 2:
                    Fahrenheit(1);
                    break;
                case 3:
                    PerusLaskut(4,2);
                    break;
                case 4:
                    Jakojaannos(20,3);
                    break;
                case 5:
                    KysyNimi();
                    break;
                case 6:
                    SyLuYh();
                    break;
                case 7:
                    AnnaCelsius();
                    break;
                case 8:
                    AnLuPeLa();
                    break;
                case 9:
                    AnLuJaJa();
                    break;
                case 10:
                    AnLuKeTo();
                    break;
                default:
                    Console.WriteLine("Et antanut lukua väliltä 1-10!");
                    break;
                    goto alku;
            }
            static void KaksiNumeroaYhteen(int lu1, int lu2)
            {
                Console.WriteLine(lu1 + lu2);
            }
            static void Fahrenheit(int lu1)
            {
                Console.WriteLine(lu1 * 1.8 + 32);
            }
            static void PerusLaskut(int lu1, int lu2)
            {
                int su = lu1 + lu2;
                int er = lu1 - lu2;
                int tu = lu1 * lu2;
                int os = lu1 / lu2;
                Console.WriteLine("Summa: {0} Erotus: {1} Tulo: {2} Osamäärä: {3}",su , er, tu, os);
            }
            static void Jakojaannos(int lu1, int lu2)
            {
                Console.WriteLine(lu1 % lu2);
            }
            static void KysyNimi()
            {   alku1:
                string ni;
                Console.Write("Syötä nimesi: ");
                ni = Console.ReadLine();
                if (ni.Length < 1)
                {
                    Console.WriteLine("Et Kirjoittanut nimeäsi!");
                    goto alku1;
                }
                else
                {
                    Console.WriteLine("Hei {0}!", ni);
                }
            }
            static void SyLuYh()
            {   alku2:
                string klu1, klu2;
                int lu1, lu2;
                Console.Write("Syötä 1. luku: ");
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: ");
                klu2 = Console.ReadLine();
                try
                {
                    lu1 = Int32.Parse(klu1);
                    lu2 = Int32.Parse(klu2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku2;
                }
                //int su = lu1 + lu2;
                Console.WriteLine(lu1 + lu2);
            }
            static void AnnaCelsius()
            {
                alku3:
                string klu1;
                int lu1;
                Console.Write("Anna Celsius-arvo: ");
                klu1 = Console.ReadLine();
                try
                {
                    lu1 = Int32.Parse(klu1);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku3;
                }
                Console.WriteLine(lu1 * 1.8 + 32);
            }
            static void AnLuPeLa()
            {
                alku4:
                string klu1, klu2;
                int lu1, lu2;
                Console.Write("Syötä 1. luku: ");
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: ");
                klu2 = Console.ReadLine();
                try
                {
                    lu1 = Int32.Parse(klu1);
                    lu2 = Int32.Parse(klu2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku4;
                }
                int su = lu1 + lu2;
                int er = lu1 - lu2;
                int tu = lu1 * lu2;
                int os = lu1 / lu2;
                Console.WriteLine("Summa: {0} Erotus: {1} Tulo: {2} Osamäärä: {3}", su, er, tu, os);
            }
            static void AnLuJaJa()
            {
                alku5:
                string klu1, klu2;
                int lu1, lu2;
                Console.Write("Syötä 1. luku: ");
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: ");
                klu2 = Console.ReadLine();
                try
                {
                    lu1 = Int32.Parse(klu1);
                    lu2 = Int32.Parse(klu2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku5;
                }
                Console.WriteLine(lu1 %= lu2);
            }
            static void AnLuKeTo()
            {

            }
        }
    }
}