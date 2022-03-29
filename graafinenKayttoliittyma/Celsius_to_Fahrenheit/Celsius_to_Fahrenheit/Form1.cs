using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///@author Antti Kuusisto
///version 24.3.2022
/// <summary>
/// Ohjelma, joka muuttaa syötetyn asteluvun Fahrenheiteiksi tai Celsiuksiksi
/// </summary>
namespace Celsius_to_Fahrenheit
{
    public partial class LampoMuunnin : Form
    {
        public LampoMuunnin()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vas, ast; //Määritellään muuttujat
            if (AsteTB.Text.Length > 0) // Kokeillaan onko aste-kentässä syötettä
            {
                try //Kokeillan muuttaa aste-kentän syöte double-arvoksi
                { 
                    ast = Convert.ToDouble(AsteTB.Text); //Syötteen muunnos
                    if (CelciusRB.Checked) //mikäli on valittu celsius
                    {
                        vas = Math.Round(ast * 1.8 + 32,2); //lasketaan ja pyöristetään celsius
                        VastausLB.Text = $"{ast} Fahrenheitia on {vas} °C:sta."; // Vastaus
                        VastausLB.Visible = true; // vastaus näkyväksi
                    }
                    else if (FahrenheitRB.Checked) //mikäli on valittu fahrenheit
                    {
                        vas = Math.Round((ast - 32) / 1.8,2); //lasketaan ja pyöristetään fahrenheit
                        VastausLB.Text = $"{ast} Celsiusta on {vas} Fahrenheitia"; // Vastaus
                        VastausLB.Visible = true; // vastaus näkyväksi
                    }
                    else // mikäli ei ole valittu kumpaakaan muunnostyyppiä
                    {
                        VastausLB.Text = "Et valinnut kohdeyksikköä";  // virheilmoitus
                        VastausLB.Visible = true;  // virheilmoitus näkyväksi
                    }
                }
                catch (Exception ex) // Mikäli aste-kentän syöte ei muunnu double-arvoksi
                {
                    VastausLB.Text = "Astekentässä on kirjaimia!"; // virheilmoitus
                    VastausLB.Visible = true;  // virheilmoitus näkyväksi
                }
            }
            else // mikäli astekenttä tyhjä
            {
                VastausLB.Text = "Aste-kenttä on tyhjä!"; // virheilmoitus
                VastausLB.Visible = true; // virheilmoitus näkyväksi
            }
        }
    }
}
