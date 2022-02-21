using System;
/// @ author Antti Kuusisto
/// version 21.2.2022
/// <summary>
/// Harjoitus, joka kirjoitettu välillä 17.2 - 20.2.2022. Kommentoitu 21.2.2022. Sisältää paluuta virheen sattuessa
/// </summary>
namespace Harjoituksia
{
    class Program
    {
        static void Main()
        {
        alku: // goto paluu mikäli ohjelman valinnasta tulee virhe
            string kyLu;
            int taLu;
            Console.WriteLine("Valitse seuraavista haluamasi ohjelma"); // Ohje käyttäjälle
            Console.WriteLine("1. laskee kaksi numeroa yhteen."); // tehtävä 1
            Console.WriteLine("2. muuttaa Celsius-asteet Fahrenheiteiksi"); // tehtävä 2
            Console.WriteLine("3. tekee annetulle luvulle peruslaskutoimitukset."); // tehtävä 3
            Console.WriteLine("4. palauttaa annetun luvun jakojäännöksen."); // tehtävä 4
            Console.WriteLine("5. pyytää käyttäjän nimen ja palauttaa viestin."); // tehtävä 5
            Console.WriteLine("6. laskee yhteen kaksi annettua lukua."); // tehtävä 6
            Console.WriteLine("7. anna Celsius-arvo ja se muutetaan Fahrenheiteiksi."); // tehtävä 7
            Console.WriteLine("8. anna 2. lukua, joille tehdään peruslaskutoimitukset."); // tehtävä 8
            Console.WriteLine("9. anna 2. lukua, joista palautetaan jakojäännös."); // tehtävä 9
            Console.WriteLine("10. anna luku väliltä 1-10 se tulostetaan kertotauluksi"); // tehtävä 10
            Console.Write("Anna ohjelmanluku, jonka haluat suorittaa: "); // kysytään ohjelmaa, jonka haluaa suorittaa
            kyLu = Console.ReadLine();
            try // katsotaan syötettinkö luku
            {
                taLu = int.Parse(kyLu);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Et antanut käyttökelpoista arvoa!");
                goto alku;
            }   // katsotaan syötettinkö luku
            switch (taLu) // katsotaan onko syötetylle luvulle ohjelmaa 
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
                default: // virhe mikäli syötetty luku on ulkona alueelta
                    Console.WriteLine("Et antanut lukua väliltä 1-10!");
                    goto alku; // paluu alkuun
            }   // katsotaan onko syötetylle luvulle ohjelmaa 
            static void KaksiNumeroaYhteen(int lu1, int lu2) 
            {
                Console.WriteLine(lu1 + lu2);
            }   // tehtävän 1. metodi
            static void Fahrenheit(int lu1) 
            {
                Console.WriteLine(lu1 * 1.8 + 32);
            }   // tehtävän 2. metodi
            static void PerusLaskut(int lu1, int lu2)
            {
                int su = lu1 + lu2;
                int er = lu1 - lu2;
                int tu = lu1 * lu2;
                int os = lu1 / lu2;
                Console.WriteLine("Summa: {0} Erotus: {1} Tulo: {2} Osamäärä: {3}",su , er, tu, os);
            }   // tehtävän 3. metodi
            static void Jakojaannos(int lu1, int lu2)
            {
                Console.WriteLine(lu1 % lu2);
            }   // tehtävän 4. metodi
            static void KysyNimi()
            {   alku1: // goto paluukohta
                string ni;
                Console.WriteLine("Syötä nimesi ja ohjelma tulostaa nimesi + viestin."); // toimintaohje käyttäjälle
                Console.Write("Syötä nimesi: "); // kysytään nimeä
                ni = Console.ReadLine();
                if (ni.Length < 1) // tarkastetaan että on syöttänyt nimen
                {
                    Console.WriteLine("Et Kirjoittanut nimeäsi!");
                    goto alku1; // paluu metodin alkuun
                }
                else // toiminta mikäli syötetty kelvollinen merkkijono
                {
                    Console.WriteLine("Hei {0}!", ni);
                }
            }   // tehtävän 5. metodi
            static void SyLuYh()
            {   alku2: // goto paluukohta
                string klu1, klu2;
                int lu1, lu2;
                Console.WriteLine("Syötä kaksi(2) lukua ja ne lasketaan yhteen."); // toimintaohje käyttäjälle
                Console.Write("Syötä 1. luku: "); // kysytään 1. luku
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: ");  // kysytään 2. luku
                klu2 = Console.ReadLine();
                try // kokeillaan onko syötetty luku
                {
                    lu1 = Int32.Parse(klu1);
                    lu2 = Int32.Parse(klu2);
                }
                catch (Exception ex) // toiminta mikäli epäkelpo arvo
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku2; // paluu metodin alkuun
                }
                Console.WriteLine(lu1 + lu2); // vastauksen tulostaminen
            }   // tehtävän 6. metodi
            static void AnnaCelsius()
            {
                alku3: // goto paluukohta
                string klu1;
                int lu1;
                Console.WriteLine("Anna Celsius-arvo ja se muutetaan Fahrenheitiksi."); // toimintaohje käyttäjälle
                Console.Write("Anna Celsius-arvo: ");
                klu1 = Console.ReadLine();
                try // kokeillaan onko syötetty luku
                {
                    lu1 = Int32.Parse(klu1);
                }
                catch(Exception ex) // toiminta mikäli epäkelpo arvo
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku3; // paluu metodin alkuun
                }
                Console.WriteLine(lu1 * 1.8 + 32); // vastauksen tulostus
            }   // tehtävän 7. metodi
            static void AnLuPeLa()
            {
                alku4: // goto paluukohta
                string klu1, klu2;
                int lu1, lu2;
                Console.WriteLine("Anna kaksi(2) lukua ja niille tehdään peruslaskutoimitukset(+, -, *, /)"); // toimintaohje käyttäjälle
                Console.Write("Syötä 1. luku: "); // kysytään 1. lukua
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: "); // kysytään 2. lukua
                klu2 = Console.ReadLine();
                try // katsotaan onko syötetty luku
                {
                    lu1 = Int32.Parse(klu1);
                    lu2 = Int32.Parse(klu2);
                }
                catch (Exception ex) // toiminta mikäli ei ole syötetty lukua
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku4; // paluu metodin alkuun
                }
                int su = lu1 + lu2; // lasketaan summa
                int er = lu1 - lu2; // lasketaan erotus
                int tu = lu1 * lu2; // lasketaan tulo
                int os = lu1 / lu2; // lasketaan osamäärä
                Console.WriteLine("Summa: {0} Erotus: {1} Tulo: {2} Osamäärä: {3}", su, er, tu, os); // tulostetaan vastaus
            }   // tehtävän 8. metodi
            static void AnLuJaJa()
            {
                alku5: // goto paluukohta
                string klu1, klu2;
                int lu1, lu2;
                Console.WriteLine("Syötä kaksi(2) lukua ja niistä lasketaan jakojäännös."); // toimintaohje käyttäjälle
                Console.Write("Syötä 1. luku: "); // kysytään lukua 1.
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: "); // kysytään lukua 1.
                klu2 = Console.ReadLine();
                try // katsotaan onko syötetty luku
                {
                    lu1 = int.Parse(klu1);
                    lu2 = int.Parse(klu2);
                }
                catch (Exception ex) // toiminta mikäli ei ole syötetty lukua
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku5; // paluu metodin alkuun
                }
                Console.WriteLine(lu1 %= lu2); // vastauksen tulostus
            }   // tehtävän 9. metodi
            static void AnLuKeTo()
            {
            alku6: // goto paluukohta
                string klu1;
                int lu1, ke;
                Console.WriteLine("Kirjoita haluamasi luku 1-10 ja siitä tulostetaan kymmenen(10)kertotaulu."); // toimintaohje käyttäjälle
                Console.Write("Syötä luku: "); // kysytään lukua
                klu1 = Console.ReadLine();
                try // kokeillaan onko syötetty luku
                {
                    lu1 = int.Parse(klu1);
                    ke = lu1;
                }
                catch(Exception ex) // toiminta mikäli ei ole syötetty lukua
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku6; // paluu metodin alkuun
                }
                if (lu1 > 0 && lu1 <= 10) // katsotaan onko sopiva luku
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        int tu = lu1 * i; // muuttuja tulolle
                        Console.WriteLine("{0} X {1} = {2}", ke, i, tu); // vastauksen tulostus
                    }
                }
                else // toiminta mikäli syötetty väärän kokoinen luku
                {
                    Console.WriteLine("Et syöttänyt lukuarvoa väliltä 1-10!"); // virheviesti
                    goto alku6; // paluu metodin alkuun
                }
            }   // tehtävän 10. metodi
        }
    }
}