using System;
/// @ author Antti Kuusisto 
/// version 21.2.2022
/// <summary>
/// Harjoitus. Osittain tehty.
/// </summary>
namespace Tehtavia
{
    class Program
    {
        static void Main()
        {
        alku: // paluukohta mikäli luku virheellinen
            string kyLu;
            int taLu;
            Console.WriteLine("Valitse seuraavista haluamasi ohjelma"); // Ohje käyttäjälle
            Console.WriteLine("1. pyytää käyttäjän ikää ja palauttaa viestin."); // Tehtävä 11
            Console.WriteLine("2. pyytää yli 10:n suuruista kokonaislukua ja paluttaasen em.mainitun verran"); // Tehtävä 12
            Console.WriteLine("3. vaihtaa sanan ensimmäisen- ja viimeisen kirjaimen paikkaa."); // Tehtävä 13
            Console.WriteLine("4. pyytää kahta kokonaislukua ja palauttaa viestin."); // Tehtävä 14
            Console.WriteLine("5. pyytää lauseen ja palauttaa pisimmän sanan."); // Tehtävä 15
            Console.WriteLine("6. tulostaa parittomat luvut väliltä 1-99."); // Tehtävä 16
            Console.WriteLine("7. tulostaa 3:lla jaolliset luvut väliltä 1-99."); // Tehtävä 17
            kyLu = Console.ReadLine();
            try // kokeillaan onko syötetty luku
            {
                taLu = int.Parse(kyLu);
            }
            catch (Exception ex) // toiminta mikäli vääränlainen syöte
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Et antanut käyttökelpoista arvoa!");
                goto alku; // paluu alkuun
            }   // kokeillaan onko syötetty luku
            switch (taLu) // katsotaan onko luvulle ohjelmaa
            {
                case 1:
                    IkaVi();
                    break;
                case 2:
                    TuLu();
                    break;
                case 3:
                    EkVk();
                    break;
                case 4:
                    LuVi();
                    break;
                case 5:
                    PiSa();
                    break;
                case 6:
                    PaLu(1,99);
                    break;
                case 7:
                    VaLu(1, 99);
                    break;
                default: // toiminta mikäli luku on väärä
                    Console.WriteLine("Et antanut lukua väliltä 1-7!"); // virheviesti
                    goto alku; // paluu alkuun
            } // katsotaan onko luvulle ohjelmaa
            static void IkaVi()
            {
                alku1: // goto paluukohta
                string klu;
                int lu;
                Console.WriteLine("Syötä ikäsi numerona ja se tulostetaan viestin kera."); // toimintaohje käyttäjälle
                Console.Write("Syötä ikäsi: "); // kysytään lukua
                klu = Console.ReadLine();
                try // kokeillaan onko syötetty luku
                {
                    lu = int.Parse(klu);
                }
                catch(Exception ex) // toiminta mikäli vääränlainen syöte
                {
                    Console.WriteLine (ex.Message);
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku1; // paluu metodin alkuun
                }
                Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta.", lu);
            }   // metodi tehtävälle 11 tehty
            static void TuLu()
            {
                alku2:
                string klu;
                int lu;
                Console.WriteLine("Syötä luku joka on yli kymmenen(10) ja se tulostetaan lukumääränsäverran kertoja.");
                Console.Write("Anna luku: ");
                klu = Console.ReadLine();
                try
                {
                    lu = int.Parse (klu);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku2;
                }
                if (lu <= 10)
                {
                    Console.WriteLine("Luku on alle kymmenen(10)!");
                    goto alku2;
                    /*
                     tavoite 13 13 13
                             131313   
                     */
                }
                else
                {
                    int ek, to;
                    string ri1, ri2;
                    for (int i = 0; i < lu; i++)
                    {
                        Console.Write(lu);
                    }
                }

            }   // metodi tehtävälle 12
            static void EkVk()
            {
                alku3: //goto paluukohta
                string sa;
                char ek, vk;
                Console.WriteLine("Syötä sana ja se tulostetaan ensimmäinen ja viimeinen kirjain paikkansa vaihtaneena."); //toimintaohje käyttäjälle
                Console.Write("Syötä sana: "); // kysytään sana
                sa = Console.ReadLine();
                if (sa.Length > 1) // kokeillaan onko sana
                {
                    char[] saArr = sa.ToCharArray(); // sana char-muotoon ja Array:si
                    ek = saArr[0]; // otetaan 1. kirjain
                    int apu = saArr.Length;
                    apu--;
                    vk = saArr[apu]; // otetaan viimeinen kirjain
                    saArr[0] = vk; // muokataan Array:ta
                    saArr[apu] = ek; // muokataan Array:ta
                    string tuSa = new string(saArr); // muodostetaan sana Array:ta
                    Console.WriteLine(tuSa); // tulostetaan vastaus
                } 
                else // mikäli syöte ei ole sana
                {
                    Console.WriteLine("Sanassa pitää olla vähintään kaksi(2) kirjainta.");
                    goto alku3; // paluu metodin alkuun
                }
            }   // metodi tehtävälle 13 tehty
            static void LuVi()
            {
            alku4: // goto paluukohta
                string klu1, klu2;
                int lu1, lu2;
                Console.WriteLine("Syötä kaksi(2) kokonaislukua ja niiden perusteella tulostetaan viesti."); // ohje käyttäjälle
                Console.Write("Syötä 1. luku: "); // kysytään 1. luku
                klu1 = Console.ReadLine();
                Console.Write("Syötä 2. luku: "); // kysytään 2. luku
                klu2 = Console.ReadLine();
                try // katsotaan onko syötetty luvut
                {
                    lu1 = int.Parse (klu1);
                    lu2 = int.Parse (klu2);
                }
                catch(Exception ex) // mikäli ei ole syötetty lukuja
                {
                    Console.WriteLine("Et syöttänyt lukuarvoa!");
                    goto alku4; // paluu metodin alkuun
                }
                if (lu1 >= 0 && lu2>= 0) // kokeillaan ehto1
                {
                    Console.WriteLine("Molemmat ovat positiivisia."); // vataus
                }
                else if (lu1 < 0 && lu2 < 0) // kokeillaan ehto2
                {
                    Console.WriteLine("Molemmat ovat negatiivisia."); // vataus
                }
                else if (lu1 >= 0 && lu2 < 0 || lu1 < 0 && lu2 >= 0) // kokeillaan ehto3
                {
                    Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen."); // vataus
                }
            }  // metodi tehtävälle 14 tehty
            static void PiSa()
            {
                string la;
                Console.WriteLine("Syötä lause ja siitä tulostetaan pisin sana");
                Console.Write("Syötä lause: ");
                la = Console.ReadLine();
                string [] sa = la.Split(' ');
                int [] pi = new int[sa.Length];
                for (int i = 0; i < sa.Length; i++)
                {
                    
                }
            }   // metodi tehtävälle 15
            static void PaLu(int lu1, int lu2)
            {
                for(int i = lu1; i < lu2; i++)
                {   


                    int apu = i %= 2;
                    if (apu == 0)
                    {
                        Console.Write(lu1);
                    }
                }
            }   // metodi tehtävälle 16
            static void VaLu(int lu1, int lu2)
            {

            }   // metodi tehtävälle 17
        }   
    }
}
