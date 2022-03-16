using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pankki1
{
     public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        private Pankkitili() { }

        public Pankkitili(string asiakkaanNimi, double saldo)
        {
            m_asiakkaanNimi = asiakkaanNimi;
            m_saldo = saldo;
        }

        public string AsiakkaanNimi
        {
            get { return m_asiakkaanNimi; }
        }

        public double Saldo
        {
            get { return m_saldo; }
        }
        public void Otto(double summa)
        {
            if (summa > m_saldo)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo -= summa;
        }
        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }
        static void Main(string[] args)
        {
            Pankkitili pt = new Pankkitili("Antti", 500.00);
            pt.Pano(500);
            pt.Otto(100.77);
            Console.WriteLine("Nykyinen saldo on {0} euroa.", pt.Saldo);
        }
    }
}
