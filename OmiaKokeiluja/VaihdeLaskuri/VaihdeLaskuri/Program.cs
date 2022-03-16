using System;
/// <summary>
/// Vaihdevälitysten laskuri C#:lla .
/// </summary>
namespace VaihdeLaskuri
{
    public class VaihdeParametrit
    {
        private readonly string tunnus;
        private string merkki, malli;
        private int vaihde, aks1, aks2, pin, crw, aRpm, lRpm, kRpm;
        private double rHalk;

        public VaihdeParametrit() 
        {
            merkki = "";
            malli = "";
            tunnus = "";
            vaihde = 0;
            aks1 = 0;
            aks2 = 0;  
            pin = 0;
            crw = 0;
            rHalk = 0;
            aRpm = 0;
            lRpm = 0;
            kRpm = 0;
        }

        public string Merkki
        { 
            set { merkki = value; }
            get { return merkki; } 
        }
        public string Malli
        {
            set { malli = value; }
            get { return malli; } 
        }
        public int Vaihde
         { 
            set { vaihde = value; }
            get { return vaihde; } 
        }
        public int Aks1
        { 
            set { aks1 = value; }
            get { return aks1; } 
        }
        public int Aks2
        { 
            set{ aks2 = value; }
            get { return aks2; } 
        }
        public int Pin
        { 
            set { pin = value; }
            get { return pin; } 
        }
        public int Crw
        { 
            set { crw = value; }    
            get { return crw; } 
        }
        public double RHalk
        { 
            set { rHalk = value; }
            get { return rHalk; } 
        }
        public int ARpm
        { 
            set { aRpm = value; }
            get { return aRpm; } 
        }
        public int LRpm
        { 
            set { lRpm = value; }
            get { return lRpm; } 
        }
        public int KRpm
        { 
            set { kRpm = value; }
            get { return kRpm; } 
        }

        public double VaSuh()
        {
             return  aks1 * aks2;
        }

        public double PeSuh()
        {
            return pin * crw;
        }

        public double KokVal()
        {
            return VaSuh() * PeSuh(); 
        }

        public double Pituus()
        {
            return rHalk * Math.PI;
        }
        /*public VaihdeParametrit(string merkki, string malli, string tunnus, int vaihde, int aks1, int aks2, int pin, int crw, double rHalk, double aRpm, double lRpm, double kRpm)
        {
            u_merkki = merkki;
            u_malli = malli;
            u_tunnus = tunnus;
            u_vaihde = vaihde;
            u_aks1 = aks1;
            u_aks2 = aks2;
            u_pin = pin;
            u_crw = crw;
            u_rHalk = rHalk;
            u_aRpm = aRpm;
            u_lRpm = lRpm;
            u_kRpm = kRpm;
        }*/
        /*public string Tunnus
        {
            set { tunnus = value; }
            get { return tunnus; }
        }*/

        static void Main()
        {
            string u_merkki, u_malli, u_tunnus;
            int u_vaihde, u_aks1, u_aks2, u_pin, u_crw, u_aRpm, u_lRpm, u_kRpm;
            double u_rHalk;
        alku:
            Console.WriteLine("Syötä pyydetyt tiedot, jotta ohjelma laskee nopeudet.");
            try
            {
            Console.Write("Syötä tunnus tiedoille: ");
            u_tunnus = Console.ReadLine();
            Console.Write("Syötä merkki: ");
            u_merkki = Console.ReadLine();
            Console.Write("Syötä malli: ");
            u_malli = Console.ReadLine();
            Console.Write("Syötä vaihde: ");
            u_vaihde = int.Parse(Console.ReadLine());
            Console.Write("Syötä 1.akselin hammasluku: ");
            u_aks1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2.akselin hammasluku: ");
            u_aks2 = int.Parse(Console.ReadLine());
            Console.Write("Syötä pienenlautaspyörän/piniomin hammasluku: ");
            u_pin = int.Parse(Console.ReadLine());
            Console.Write("Syötä isonlautaspyörän hammasluku: ");
            u_crw = int.Parse(Console.ReadLine());
            Console.Write("Syötä alkukierrosluku: ");
            u_aRpm = int.Parse(Console.ReadLine());
            Console.Write("Syötä loppukierrosluku: ");
            u_lRpm = int.Parse(Console.ReadLine());
            Console.Write("Syötä kierrosluvun kasvuväli: ");
            u_kRpm = int.Parse(Console.ReadLine());
            Console.Write("Syötä renkaanhalkaisia(millimetreinä): ");
            u_rHalk = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Syötit väärän arvon. Yritä uudelleen.");
                goto alku;
            }
            VaihdeParametrit tieto = new VaihdeParametrit();
            tieto.Merkki = u_merkki;
            tieto.Malli = u_malli;
            tieto.Vaihde = u_vaihde;
            tieto.Aks1 = u_aks1;
            tieto.Aks2 = u_aks2;
            tieto.Pin = u_pin;
            tieto.Crw = u_crw;
            tieto.ARpm = u_aRpm;
            tieto.LRpm = u_lRpm;
            tieto.KRpm = u_kRpm;
            tieto.RHalk = u_rHalk;

        }
    }
}