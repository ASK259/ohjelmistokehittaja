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
/// Päiväkirjaohjelma. Tallentaa teksti tiedostoon syötteen ja lisää loppuun päivänmäärän ja kellonajan
/// </summary>

namespace Paivakirja
{
    public partial class PaivakirjaF : Form
    {
        public PaivakirjaF()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\asus\\source\\repos\\ohjelmistokehittajana_toimiminen\\graafinenKayttoliittyma\\Paivakirja\\paivakirja.txt"); // muuttuja johon luetaan tallennettu teksti
            SyottoRTB.Text = teksti; // Tallennettu teksti näkyviin näytölle
        }

        private void TallennaBT_Click(object sender, EventArgs e) // tominta, kun painetaan Tallenna-button:a
        {
            string teksti = ""; // muuttujan nollaus
            teksti += SyottoRTB.Text; // muuttujaan suötetty teksti
            teksti += DateTime.Now.ToString("dd,MM,yyyy HH:mm") + "\n"; // tekstiin haetaan ja liitetään päivänmäärä ja aika sekä lisätään tyhjä rivi
            TextWriter text = new StreamWriter("C:\\Users\\asus\\source\\repos\\ohjelmistokehittajana_toimiminen\\graafinenKayttoliittyma\\Paivakirja\\paivakirja.txt"); // Muuttuja jolla kirjoitetaan teksti tallennus kohteeseen
            text.Write(teksti); // määritetään mitä kirjoitetaan
            text.Close(); // suljetaan kirjoitus
            Application.Exit(); // poistutaan aplikaatiosta
        }
    }
}
