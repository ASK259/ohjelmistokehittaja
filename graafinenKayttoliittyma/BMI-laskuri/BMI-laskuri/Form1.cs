using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///@ author Antti Kuusisto
/// version 24.3.2022
/// <summary>
/// BMI-laskuri
/// </summary>
namespace BMI_laskuri
{
    public partial class BmiLaskuri : Form
    {
        public BmiLaskuri()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            if(PainoTB.Text.Length > 0 && PituusTB.Text.Length > 0) // katsotaan onko kentissä sisältöä
            {
                try // kokeillaan muuttaa kenttien sisältö double-arvoksi
                {
                    double paino , pituus, bmi ; // nimetään muuttujat
                    paino = Convert.ToDouble(PainoTB.Text); // Paino-kentän luku
                    pituus = Convert.ToDouble(PituusTB.Text); // Pituus-kentän luku
                    bmi = Math.Round(paino / (pituus * pituus),2); // lasketaan painoindeksi
                    if(bmi < 18.5) // eka vertailu
                    {
                        BmiLB.Text = $"Painoindeksisi on {bmi} {pituus}"; //painoindeksin tulostus
                        BmiLB.ForeColor = Color.Red; // painoindeksin väri
                        BmiLB.Visible = true; // painoindeksi näkyväksi
                        KuvausLB.Text = $"Alipaino"; // painoindeksin kommentti
                        KuvausLB.ForeColor = Color.Red; // kommentin väri
                        KuvausLB.Visible = true; // kommentti näkyväksi
                    }
                    else if (bmi < 25) //toka väittämä
                    {
                        BmiLB.Text = $"Painoindeksisi on {bmi} {pituus}"; //painoindeksin tulostus
                        BmiLB.ForeColor = Color.Orange; // painoindeksin väri
                        BmiLB.Visible = true; // painoindeksi näkyväksi
                        KuvausLB.Text = $"Normaalipaino"; // painoindeksin kommentti
                        KuvausLB.ForeColor = Color.Orange; // kommentin väri
                        KuvausLB.Visible = true;  // kommentti näkyväksi
                    }
                    else if (bmi < 40) // kolmas väittämä
                    {
                        BmiLB.Text = $"Painoindeksisi on {bmi} {pituus}";  //painoindeksin tulostus
                        BmiLB.ForeColor = Color.Blue;  // painoindeksin väri
                        BmiLB.Visible = true; // painoindeksi näkyväksi
                        KuvausLB.Text = $"Ylipaino"; // painoindeksin kommentti
                        KuvausLB.ForeColor = Color.Blue; // kommentin väri
                        KuvausLB.Visible = true;  // kommentti näkyväksi
                    }
                    else // loppu toteamus
                    {
                        BmiLB.Text = $"Painoindeksisi on {bmi} {pituus}";  //painoindeksin tulostus
                        BmiLB.ForeColor = Color.Black;  // painoindeksin väri
                        BmiLB.Visible = true; // painoindeksi näkyväksi
                        KuvausLB.Text = $"Huomattava ylipaino"; // painoindeksin kommentti
                        KuvausLB.ForeColor = Color.Black; // kommentin väri
                        KuvausLB.Visible = true;  // kommentti näkyväksi
                    }
                }
                catch(Exception ex) // Mikäli kenttien sisältöä ei voi muuttaa double-arvoon
                {
                    BmiLB.Text = "Kentissä on kirjaimia!"; // virhe ilmoitus
                    BmiLB.Visible = true; // virhe ilmoitus näkyväksi
                }
            }
            else // Mikäli kenttä/t tyhjiä
            {
                BmiLB.Text = "Et syöttänyt painoasi tai pituuttasi!"; // virhe ilmoitus
                BmiLB.Visible = true; // virhe ilmoitus näkyväksi
            }
        }
    }
}
