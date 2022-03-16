using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            alku:
            double laina, nesteet, vakuutus, muut, polttoaine, pesut, huollot, renkaat, kilometrit, vastaus;
            /*laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(LisneTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            muut = Convert.ToDouble(MuutkulutTB.Text);
            polttoaine = Convert.ToDouble(PolttonesteTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            */
            try
            {
                laina = Convert.ToDouble(LainaTB.Text);
                nesteet = Convert.ToDouble(LisneTB.Text);
                vakuutus = Convert.ToDouble(VakuutusTB.Text);
                muut = Convert.ToDouble(MuutkulutTB.Text);
                polttoaine = Convert.ToDouble(PolttonesteTB.Text);
                pesut = Convert.ToDouble(PesutTB.Text);
                huollot = Convert.ToDouble(HuollotTB.Text);
                renkaat = Convert.ToDouble(RenkaatTB.Text);
                kilometrit = Convert.ToDouble(KilometritCB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                KulutLB.Text = "virhe!";
                KulutLB.Visible = true;
                goto alku;
            }

            vastaus = (laina + nesteet + vakuutus + muut + polttoaine + pesut + huollot + renkaat) / (kilometrit / 12);
            KulutLB.Text = "Kulut kilometriä kohti ovat: " + vastaus + "€";
            KulutLB.Visible = true;
        }
    }
}
