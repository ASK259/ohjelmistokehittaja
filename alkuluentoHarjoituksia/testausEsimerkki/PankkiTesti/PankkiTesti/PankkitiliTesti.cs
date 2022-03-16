using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pankki;
namespace PankkiTesti
{
    [TestClass]
    public class PankkitiliTesti
    {
        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSaldo()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            PankkiTili tili = new PankkiTili("Testi", alkusaldo);

            tili.Otto(ottoSumma);

            double todellinen = tili.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut!");
        }
    }
}