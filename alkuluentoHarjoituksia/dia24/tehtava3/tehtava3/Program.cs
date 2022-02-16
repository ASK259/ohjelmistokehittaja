using System;

namespace Tehtava3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä luku väliltä 0-9 ja se tulostetaan tekstinä.");
            tahan:
            Console.Write("Syötä luku: ");
            int lu = int.Parse(Console.ReadLine());
            switch (lu)
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
                default:
                    Console.WriteLine("Syötetty luku alueen ulkopuolella");
                    goto tahan;
                    break;
            }
        }
    }
}