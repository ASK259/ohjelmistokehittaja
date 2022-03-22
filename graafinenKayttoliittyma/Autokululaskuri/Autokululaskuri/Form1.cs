using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// @ author Antti Kuusisto
/// version 22.03.2022///
/// <summary>
/// Ohjelma, joka laskee auton kuukausi kulut. Koodi kirjoitettu aiemmin, nyt puolestaan kommentoitu. Try-catch toimii nyt. Ei varmaankaan täysin oikeaoppinen,
/// mutta ajaa tässä asiansa.
/// </summary>
namespace Autokululaskuri
{
    public partial class AutonkuluLaskuri : Form
    {
        public AutonkuluLaskuri()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            // määritellään muuttujat
            double laina, nesteet, vakuutus, muut, polttoaine, pesut, huollot, renkaat, kilometrit, vastaus;
            try // Katsotaan onko kentissä muita, kuin lukuja
            {   // muutetaan tekstikentän arvot Double-luvuiksi
                laina = Convert.ToDouble(LainaTB.Text);
                nesteet = Convert.ToDouble(LisneTB.Text);
                vakuutus = Convert.ToDouble(VakuutusTB.Text);
                muut = Convert.ToDouble(MuutkulutTB.Text);
                polttoaine = Convert.ToDouble(PolttonesteTB.Text);
                pesut = Convert.ToDouble(PesutTB.Text);
                huollot = Convert.ToDouble(HuollotTB.Text);
                renkaat = Convert.ToDouble(RenkaatTB.Text);
                kilometrit = Convert.ToDouble(KilometritCB.Text);
                vastaus = (laina + nesteet + vakuutus + muut + polttoaine + pesut + huollot + renkaat) / (kilometrit / 12); // lasketaan kulut kuukautta kohden
                KulutLB.Text = "Kulut kilometriä kohti ovat: " + vastaus + "€"; // Vatauksen tekstiosan ja laskutuloksen yhdistäminen
                KulutLB.Visible = true; // Vastaus näkyväksi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Syötetty kirjain luvun sijaan johonkin kenttään!");
                KulutLB.Visible = false;
            }

 
        }
    }
}
