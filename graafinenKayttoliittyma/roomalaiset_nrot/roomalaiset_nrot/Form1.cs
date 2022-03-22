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
/// Ohjelma joka muuttaa latinalaisen-luvun roomalaiseksi-luvuksi
/// </summary>
namespace roomalaiset_nrot
{
    public partial class roomalaisetNro : Form
    {
        public roomalaisetNro()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {   //määritetään muuttujat
            int lu1, lu2, lu3, lu4, luk;
            string vastaus = "";
            if (LukuTB.Text.Length == 4) // katsotaan onko tekstikentän syöte 4 - merkkiä pitkä
            { 
                try // kokeillaan onko kyseessä luku
                {   
                    luk = Convert.ToInt32(LukuTB.Text);
                    lu1 = Convert.ToInt32(LukuTB.Text.Substring(0, 1));
                    lu2 = Convert.ToInt32(LukuTB.Text.Substring(1, 1));
                    lu3 = Convert.ToInt32(LukuTB.Text.Substring(2, 1));
                    lu4 = Convert.ToInt32(LukuTB.Text.Substring(3, 1));
                    if (luk > 3999) // Katsotaan onko luku isompi, kuin mitä pyydetään
                    {
                        VastausLB.Text = ""; // Nollataan vastaus - alue
                        MessageBox.Show("Syötit liian suuren luvun!"); // virheviesti
                        LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                    }
                    vastaus += Tuhannet(lu1); // kutsutaan metodia, joka määrittelee tuhannet roomalaisilla numeroilla
                    vastaus += Sadat(lu2);  // kutsutaan metodia, joka määrittelee sadat roomalaisilla numeroilla
                    vastaus += Kympit(lu3); // kutsutaan metodia, joka määrittelee kymmenet roomalaisilla numeroilla
                    vastaus += Ykkoset(lu4); // kutsutaan metodia, joka määrittelee ykköset roomalaisilla numeroilla
                    VastausLB.Text = vastaus; // Vastaus - alueelle roomalainen luku
                    VastausLB.Visible = true; // Vastaus näkyväksi
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
                catch (Exception ex) // mikäli sisältää muita tietotyyppejä
                {
                    VastausLB.Text = ""; // Nollataan vastaus - alue
                    MessageBox.Show("Et syöttänyt lukuarvoa!"); // virheviesti
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
            }
            else if (LukuTB.Text.Length == 3) // katsotaan onko tekstikentän syöte 3 - merkkiä pitkä
            {
                try // kokeillaan onko kyseessä luku
                {
                    lu2 = Convert.ToInt32(LukuTB.Text.Substring(0, 1));
                    lu3 = Convert.ToInt32(LukuTB.Text.Substring(1, 1));
                    lu4 = Convert.ToInt32(LukuTB.Text.Substring(2, 1));
                    vastaus += Sadat(lu2); // kutsutaan metodia, joka määrittelee sadat roomalaisilla numeroilla
                    vastaus += Kympit(lu3); // kutsutaan metodia, joka määrittelee kymmenet roomalaisilla numeroilla
                    vastaus += Ykkoset(lu4); // kutsutaan metodia, joka määrittelee ykköset roomalaisilla numeroilla
                    VastausLB.Text = vastaus; // Vastaus - alueelle roomalainen luku
                    VastausLB.Visible = true; // Vastaus näkyväksi
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
                catch (Exception ex) // mikäli sisältää muita tietotyyppejä
                {
                    VastausLB.Text = ""; // Nollataan vastaus - alue
                    MessageBox.Show("Et syöttänyt lukuarvoa!"); // virheviesti
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
            }
            else if (LukuTB.Text.Length == 2) // katsotaan onko tekstikentän syöte 2 - merkkiä pitkä
            {
                try // kokeillaan onko kyseessä luku
                {
                    lu3 = Convert.ToInt32(LukuTB.Text.Substring(0, 1));
                    lu4 = Convert.ToInt32(LukuTB.Text.Substring(1, 1));
                    vastaus += Kympit(lu3); // kutsutaan metodia, joka määrittelee kymmenet roomalaisilla numeroilla
                    vastaus += Ykkoset(lu4); // kutsutaan metodia, joka määrittelee ykköset roomalaisilla numeroilla
                    VastausLB.Text = vastaus; // Vastaus - alueelle roomalainen luku
                    VastausLB.Visible = true; // Vastaus näkyväksi
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
                catch (Exception ex) // mikäli sisältää muita tietotyyppejä
                {
                    VastausLB.Text = ""; // Nollataan vastaus - alue
                    MessageBox.Show("Et syöttänyt lukuarvoa!"); // virheviesti
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
            }
            else if (LukuTB.Text.Length == 1) // katsotaan onko tekstikentän syöte 1 - merkkiä pitkä
            {
                try // kokeillaan onko kyseessä luku
                {
                    lu4 = Convert.ToInt32(LukuTB.Text.Substring(0, 1));
                    vastaus += Ykkoset(lu4); // kutsutaan metodia, joka määrittelee ykköset roomalaisilla numeroilla
                    VastausLB.Text = vastaus; // Vastaus - alueelle roomalainen luku
                    VastausLB.Visible = true; // Vastaus näkyväksi
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
                catch (Exception ex) // mikäli sisältää muita tietotyyppejä
                {
                    VastausLB.Text = ""; // Nollataan vastaus - alue
                    MessageBox.Show("Et syöttänyt lukuarvoa!"); // virheviesti
                    LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
                }
            }
            else if (LukuTB.Text.Length == 0) // katsotaan onko tekstikentässä ollenkaan syötettä
            {
                VastausLB.Text = ""; // Nollataan vastaus - alue
                MessageBox.Show("Et ole syöttänyt mitään tekstikenttään!"); // virheviesti
                LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
            }
            else if (LukuTB.Text.Length > 4) // Toiminta mikäli tekstikentänsyöte on yli 4 - merkkiä
            {
                VastausLB.Text = ""; // Nollataan vastaus - alue
                MessageBox.Show("Olet syöttänyt liian pitkän luvun tekstikenttään!");   // virheviesti
                LukuTB.Focus(); // Automaattinen kohdistus tekstikenttään
            }
        }
        private string Tuhannet(int lu1) // Määrittää tuhannet roomalaisilla luvuilla
        {
            if (lu1 == 1)
            {
                return "M";
            }
            else if (lu1 == 2)
            {
                return "MM";
            }
            else if (lu1 == 3)
            {
                return "MMM";
            }
            else
            {
                return "";
            }
        }
        private string Sadat(int lu2) // Määrittää sadat roomalaisilla luvuilla
        {
            if (lu2 == 1)
            {
                return "C";
            }
            else if (lu2 == 2)
            {
                return "CC";
            }
            else if (lu2 == 3)
            {
                return "CCC";
            }
            else if (lu2 == 4)
            {
                return "CD";
            }
            else if (lu2 == 5)
            {
                return "D";
            }

            else if (lu2 == 6)
            {
                return "DC";
            }
            else if (lu2 == 7)
            {
                return "DCC";
            }
            else if (lu2 == 8)
            {
                return "DCCC";
            }
            else if (lu2 == 9)
            {
                return "CM";
            }
            else
            {
                 return "";
            }
        }
        private string Kympit(int lu3) // Määrittää kymmenet roomalaisilla luvuilla
        {
            if (lu3 == 1)
            {
                return "X";
            }
            else if (lu3 == 2)
            {
                return "XX";
            }
            else if (lu3 == 3)
            {
                return "XXX";
            }
            else if (lu3 == 4)
            {
                return "LX";
            }
            else if (lu3 == 5)
            {
                return "L";
            }

            else if (lu3 == 6)
            {
                return "LC";
            }
            else if (lu3 == 7)
            {
                return "LCC";
            }
            else if (lu3 == 8)
            {
                return "LCCC";
            }
            else if (lu3 == 9)
            {
                return "XC";
            }
            else
            {
                return "";
            }
        }
        private string Ykkoset(int lu4) // Määrittää ykköset roomalaisilla luvuilla
        {
            if (lu4 == 1)
            {
                return "I";
            }
            else if (lu4 == 2)
            {
                return "II";
            }
            else if (lu4 == 3)
            {
                return "III";
            }
            else if (lu4 == 4)
            {
                return "IV";
            }
            else if (lu4 == 5)
            {
                return "V";
            }

            else if (lu4 == 6)
            {
                return "VI";
            }
            else if (lu4 == 7)
            {
                return "VII";
            }
            else if (lu4 == 8)
            {
                return "VIII";
            }
            else if (lu4 == 9)
            {
                return "IX";
            }
            else
            {
                return "";
            }
        }
    }
}
