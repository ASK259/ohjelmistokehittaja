using System;

namespace Tehtava6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä bonus pisteesi ja ne kerrotaan kaavan mukaan.");
            tahan:
            Console.Write("Syötä pisteesi: ");
            int lu = int.Parse(Console.ReadLine());
            if(lu == 0 || lu > 9)
            {
                Console.WriteLine("Luku ulkona alueelta!");
                goto tahan;
            }
            else if(lu == 1 || lu == 2 || lu == 3)
            {
                Console.WriteLine("Pisteesi: {0}",lu * 10);
            }
            else if(lu == 4 || lu == 5 || lu == 6)
            {
                Console.WriteLine("Pisteesi: {0}", lu * 100);
            }
            else if (lu == 7 || lu == 8 || lu == 9)
            {
                Console.WriteLine("Pisteesi: {0}", lu * 1000);
            }
        }
    }
}