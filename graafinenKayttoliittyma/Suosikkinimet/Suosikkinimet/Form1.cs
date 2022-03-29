using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
///@author Antti Kuusisto
///version 29.03.2022
/// <summary>
/// Ohjelma, joka etsii nimen 50 suosituimman joukosta ja tulostaa "sijoituksen"
/// </summary>
namespace Suosikkinimet
{
    public partial class NimiForm : Form
    {
        public NimiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)// toiminta, kun painetaan Tarkasta-buttonia
        {
            VastausLB.Text = ""; // nollataan vastaus alueen teksti
            string[] pojat = File.ReadAllLines("C:\\Users\\asus\\source\\repos\\ohjelmistokehittajana_toimiminen\\graafinenKayttoliittyma\\Suosikkinimet\\pojat.txt"); // Array poikien nimistä
            string[] tytot = File.ReadAllLines("C:\\Users\\asus\\source\\repos\\ohjelmistokehittajana_toimiminen\\graafinenKayttoliittyma\\Suosikkinimet\\tytot.txt"); // Array tyttöjen nimistä
            string nimi = NimiTB.Text; // Luetaan syötetty nimi muuttujaan
            int laskuriP = 1; // laskuri poikiennimen läpikäyntiin, jolla saadaan "sijoitus"
            int laskuriT = 1; // laskuri tyttöjennimen läpikäyntiin, jolla saadaan "sijoitus"
            bool pEi = true; // mikäli syötetty nimi ei poikien joukossa
            bool tEi = true; // mikäli syötetty nimi ei tyttöjen joukossa
            foreach (string p in pojat) // poikien nimien läpikäynti
            {
                if (nimi == p)
                {
                    VastausLB.Text = $"Nimesi on {laskuriP} suosituin poikien nimi vuonna 2020."; // vastaus
                    VastausLB.Visible = true; // vastaus näkyväksi
                    pEi = false; // nimi löytyi
                }
                laskuriP++; // laskuri +1
            }
            foreach (string t in tytot)  // tyttöjen nimien läpikäynti
            {
                if (nimi == t)
                {
                    VastausLB.Text = $"Nimesi on {laskuriT} suosituin poikien nimi vuonna 2020."; // vastaus
                    VastausLB.Visible = true; // vastaus näkyväksi
                    tEi = false; // nimi löytyi

                }
                laskuriT++; // laskusi +1
            }
            if (pEi == true && tEi == true) // mikäli nimeä ei löydy
            {
                VastausLB.Text = $"Nimeäsi ei löytynyt suosituimpien joukosta."; // vastaus
                VastausLB.Visible = true; // vastaus näkyväksi
            }
        }
    }
}
