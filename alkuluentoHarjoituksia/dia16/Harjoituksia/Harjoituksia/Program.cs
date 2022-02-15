using System;
/// @ author Antti Kuusisto
/// @ version 15.02.2022 ///
/// <summary>
/// Harjoituksia laskuoperaattoreista
/// </summary>
namespace Harjoituksia
    {
        class Laskuja
        {
            static void Main()
            {
            /// <summary>
            /// Tehtävä 1
            /// </summary>
            String lu1, lu2;
            int lu;
            Console.WriteLine("Tehtävä 1");
            Console.WriteLine("Syötä kaksi lukua ja ihmettele vastausta.");
            Console.Write("Syötä 1. luku: ");
            lu1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            lu2 = Console.ReadLine();
            lu = Int32.Parse(lu2) + 3;
            Console.WriteLine("Vastaus on {0}",lu);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 2
            /// </summary>
            String er1, er2;
            int er;
            Console.WriteLine("Tehtävä 2");
            Console.WriteLine("Syötä kaksi lukua ja ihmettele vastausta.");
            Console.Write("Syötä 1. luku: ");
            er1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            er2 = Console.ReadLine();
            er = Int32.Parse(er2) - 2;
            Console.WriteLine("vastaus on {0}", er);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 3
            /// </summary>
            String tu1, tu2;
            int tu;
            Console.WriteLine("Tehtävä 3");
            Console.WriteLine("Syötä kaksi lukua ja ihmettele vastausta.");
            Console.Write("Syötä 1. luku: ");
            tu1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            tu2 = Console.ReadLine();
            tu = Int32.Parse(tu2) * 5;
            Console.WriteLine("vastaus on {0}", tu);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 4
            /// </summary>
            String os1, os2;
            int os;
            Console.WriteLine("Tehtävä 4");
            Console.WriteLine("Syötä kaksi lukua ja niiden osamäärä tulostuu.");
            Console.Write("Syötä 1. luku: ");
            os1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            os2 = Console.ReadLine();
            os = Int32.Parse(os1) / Int32.Parse(os2);
            Console.WriteLine("Osamäärä on {0}", os);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 5
            /// </summary>
            String jak1, jak2;
            int jak;
            Console.WriteLine("Tehtävä 5");
            Console.WriteLine("Syötä kaksi lukua ja niiden jakojäännös tulostuu.");
            Console.Write("Syötä 1. luku: ");
            jak1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            jak2 = Console.ReadLine();
            jak = Int32.Parse(jak1) % Int32.Parse(jak2);
            Console.WriteLine("jakojäännös on {0}", jak);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 6
            /// </summary>
            String su1, su2;
            int su;
            Console.WriteLine("Tehtävä 6");
            Console.WriteLine("Syötä kaksi lukua ja niiden summa tulostuu.");
            Console.Write("Syötä 1. luku: ");
            su1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            su2 = Console.ReadLine();
            su = Int32.Parse(su1) + Int32.Parse(su2);
            Console.WriteLine("Summa on {0}", su);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 7
            /// </summary>
            String ero1, ero2;
            int ero;
            Console.WriteLine("Tehtävä 7");
            Console.WriteLine("Syötä kaksi lukua ja niiden erotus tulostuu.");
            Console.Write("Syötä 1. luku: ");
            ero1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            ero2 = Console.ReadLine();
            ero = Int32.Parse(ero1) - Int32.Parse(ero2);
            Console.WriteLine("Erotus on {0}", ero);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 8
            /// </summary>
            String po1, po2;
            int po;
            Console.WriteLine("Tehtävä 8");
            Console.WriteLine("Syötä kaksi lukua ja niiden kertoma tulostuu.");
            Console.Write("Syötä 1. luku: ");
            po1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            po2 = Console.ReadLine();
            int po3 = Int32.Parse(po2);
            po = Int32.Parse(po1) * (po3 *= 5);
            Console.WriteLine("Vastaus on {0}", po);
            Console.WriteLine("");
            ///<summary>
            ///Tehtävä 9
            /// </summary>
            String ost1, ost2;
            int ost;
            Console.WriteLine("Tehtävä 9");
            Console.WriteLine("Syötä kaksi lukua ja niiden osamäärä tulostuu.");
            Console.Write("Syötä 1. luku: ");
            ost1 = Console.ReadLine();
            Console.Write("Syötä 2. luku: ");
            ost2 = Console.ReadLine();
            ost = Int32.Parse(os1) / Int32.Parse(os2);
            Console.WriteLine("Osamäärä on {0}", ost);
        }
    }
    }
