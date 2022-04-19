using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Kaikille_pakollinen_projekti
{
    public partial class SivuForm : Form
    {
        METODEJA metodi = new METODEJA();
        TIETOKANNANMUOKKAUS tietokanta = new TIETOKANNANMUOKKAUS();
        public SivuForm()
        {
            InitializeComponent();
        }
        private void SivuForm_Load(object sender, EventArgs e) // Toiminta, kun Form ladataan
        {
            KotisivuPanel.Visible = true; // Tämä on sivuston etusivu. Oma panel ja näkyvissä
            RekisteroidyPanel.Visible = false; // Rekisteröityminen. Oma panel ja pois näkyvistä
            KirjauduPanel.Visible = false; // Kirjautuminen ja pois näkyvistä.
            GalleriaJulkPanel.Visible = false; //Galleria julkinen.
        }

        // Etusivun rekisteröidy linkki
        private void RekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon
        }

        // Etusivun kirjaudu linkki
        private void KirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon
        }

        // Etusivun Galleria linkki
        private void GalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon

        }

        // Rekisteröidy sivun Etusivu linkki
        private void RKotiLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }
        // Rekisteröidy-sivun Kirjautuminen-sivu linkki
        private void RKirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }

        // Rekisteröidy-sivun Galleria-sivu linkki
        private void RGalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }
       
        // Kirjautuminen-sivun Etusivu linkki
        private void KEtusivuLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Kirjautuminen-sivun Rekisteröityminen-sivu linkki
        private void KRekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Kirjautuminen-sivun Galleria-sivu linkki
        private void KGalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Galleria-sivun Etusivu linkki
        private void GEtusivuLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }

        // Galleria-sivun Kirjautuminen-sivu linkki
        private void GKirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }

        // Galleria-sivun Rekisteröityminen-sivu linkki
        private void GRekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }

        // Rekisteröitymisen tallentaminen
        private void RetallennaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = ReEtunimiTB.Text; // Etunimi
                string lName = ReSukunimiTB.Text; // Sukunimi
                string phone = RePuhelinTB.Text; // Puhelin nro.
                string email = ReEmailTB.Text; // Sähköposti
                string gender = ReSukupuoliCB.Text; // Sukupuoli
                string address = ReOsaiteTB.Text; // Osoite
                int postCode = int.Parse(RePostiNroTB.Text); // Postinumero
                string postArea = RePostitoimipaikkaTB.Text; // Postitoimipaikka
                if (fName.Trim().Equals("") || lName.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals("") || gender.Trim().Equals("") || address.Trim().Equals("") || postCode.Equals("") || postArea.Trim().Equals("")) // katsotaan ettei kentätä ole tyhjiä
                {
                    MessageBox.Show($"Yksi tai useampi kenttä on tyhjä!");
                }
                else if (metodi.EmailIsValid(email) == false) // Tarkistetaan, että sähköpostiosoite on todellinen. HUOM! oma class johon metodi on sijoitettu
                {
                    MessageBox.Show($"Virheellinen sähköpostiosoite!");
                }
                else
                {
                    // Alla toimitaan opetusesimerkin mukaan, jotta tätä voi kaikki muokata. Voin myös tehdä omalla variaatiollani, joka toimii, mutta siihen ei ole, kuin omat kommenttini ohjeeksi
                    Boolean rekisteroiKayttaja = tietokanta.rekisteroiKayttaja(fName, lName, phone, email, gender, address, postCode, postArea);
                    if(rekisteroiKayttaja)
                    {
                        MessageBox.Show($"Rekisteröinti onnistui");
                    }
                    else
                    {
                        MessageBox.Show($"Rekisteröinti ei onnistunut");
                    }
                    RekisteroidyPanel.Visible = false;
                    KirSisaanKotisivuPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Toiminta, kun kirjaudutaan
        private void KirKirjauduBT_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = KirKaytTunTB.Text;
                string password = KirSalasanaTB.Text;
                if(userName.Equals("") || password.Equals(""))
                {
                    MessageBox.Show($"Et syöttänyt käyttäjätunnusta tai salasanaa!");
                }
                else
                {
                    KirjauduPanel.Visible = false;
                    KirSisaanKotisivuPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
