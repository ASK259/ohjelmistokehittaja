using System;

namespace Tehtava4
{
    class Program
    {
        static void Main()
        {
            int[] luvut = new int[5];
            Console.WriteLine("Anna 5 lukua ja suurin tulostetaan.");
            Console.Write("Anna  1. luku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna  2. luku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna  3. luku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna  4. luku: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna  5. luku: ");
            luvut[4] = int.Parse(Console.ReadLine());
            Console.WriteLine(luvut.Max());
        }
    }
}