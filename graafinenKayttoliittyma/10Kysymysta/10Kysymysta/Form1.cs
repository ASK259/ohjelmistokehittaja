using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// @author Antti Kuusisto
/// version 27.03.2022
/// <summary>
/// 10 kysymystä peli.
/// </summary>
namespace _10Kysymysta
{
    public partial class Vastauslomake : Form
    {
        string[] vast = new string[11]; // Array painetuille vastauksille
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" }; // Array jossa oikeat vastaukset
        int laskuri = 0; // laskuri painalluksille
        int oikein = 0; // laskuri oikeille vastauksille
        public Vastauslomake()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); // A-r.butto:lle eventhandler
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); // B-r.butto:lle eventhandler
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); // C-r.butto:lle eventhandler
            VastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); // D-r.butto:lle eventhandler
        }

        private void Vastauslomake_Load(object sender, EventArgs e)
        {
                
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)// Kun valitaan vastaus
        {
            if(sender is RadioButton && laskuri <= 10) // valitaan vastaus ja vastauksia vähemmän tai 10:n
            {
                RadioButton radioButton = (RadioButton)sender; // 
                vast[laskuri] = radioButton.Text; // lisätään vast-Array:n kyseessä olevan vastauksen kirjain.
                KysymysLB.Text = $"Vastaus {laskuri}, kysymykseen:"; // Päivitetään kysymyksennumero kysymys lauseeseen
                laskuri++; // laskuri +1
            }
            else
            {
                VastausLB.Text = ""; // Vastauksen alueen tyhjennys
                VastausARB.Enabled = false; // poistetaan vast. A-r.button käytöstä
                VastausBRB.Enabled = false; // poistetaan vast. B-r.button käytöstä
                VastausCRB.Enabled = false; // poistetaan vast. C-r.button käytöstä
                VastausDRB.Enabled = false; // poistetaan vast. D-r.button käytöstä
                for (int i = 1; i <= 10; i++) // for-loop jolla käydään vastaukset läpi
                {
                    if(vast[i] == oikeat[i]) // mikäli vastaus ja oikeavastaus täsmäävät
                    {
                        oikein ++; // oikein +1
                    }
                }
                VastausLB.Text = $"Oikeita vastauksia oli: {oikein}"; // vastaus montako oli oikein
                VastausLB.Visible = true; // vastaus näkyväksi
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
