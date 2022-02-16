using System;

namespace Tehtava2
{
    class Program
    {
        static void Main()
        {
            int[] luvut = new int[3];
            Console.WriteLine("Anna kolme(3) lukua ja ne tulostetaan suuruusjärjrstyksessä.");
            Console.Write("Anna 1. luku: ");
            luvut[0] = int.Parse(Console.ReadLine( ));
            Console.Write("Anna 2. luku: ");
            luvut[1] = int.Parse(Console.ReadLine( ));
            Console.Write("Anna 3. luku: ");
            luvut[2] = int.Parse(Console.ReadLine( ));
            Console.WriteLine(luvut.Max());
        }
    }
}