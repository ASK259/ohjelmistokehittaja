using System;

namespace Tehtava1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä kaksi lukua ja ne tulostetaan suuruusjärjestyksessä.");
            Console.Write("Annna 1. luku: ");
            int lu1 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int lu2 = Int32.Parse(Console.ReadLine());
            if (lu1 > lu2)
            {
                Console.WriteLine("{0} {1}",lu1, lu2);
            }
            else if (lu1 < lu2)
            {
                Console.WriteLine("{0} {1}", lu2, lu1);
            }
        }
    }
}
