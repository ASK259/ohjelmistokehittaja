using System;

namespace Pankki
{
    public class PankkiTili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        private PankkiTili() { }
        public PankkiTili(string asiakkaanNimi, double saldo)
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
        static void Main()
        {
            PankkiTili pt = new PankkiTili("Antti", 500.00);
            pt.Pano(500);
            pt.Otto(225.23);
            Console.WriteLine("Nykyinen saldo on {0} euroa.", pt.Saldo);
        }
    }
}
