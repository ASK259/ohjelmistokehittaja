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
/// version 22.03.2022
/// <summary>
/// Tulostaa syötetyt luvut näytölle. Osittain kirjoitettu aiemmin. Tänään korjattu ja kommentoitu
/// </summary>
namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>(); // luodaan jono-niminen lista
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter) // mikäli painetaan enter:ä
            {
                try // kokeillaan onko syötetty luku
                {
                    Int32.Parse(uusiLukuTB.Text); // muutetaan kentän syöte luvuksi
                    if (uusiLukuTB.Text == "-999") // katsotaan onko syötetty arvo pysäytys arvo
                    {
                    VastausLB.Text = ""; // nollataan vastauksen tulostusalue
                    int[] arr = jono.ToArray(); // muutetaan lista Array:si arr
                    Array.Sort(arr); // Järjestetään Array arr
                    foreach (var a in arr) // Käydään Array läpi foreach silmukalla
                    {
                        VastausLB.Text += a + " "; // Lisätään vastaus tulostukseen Array:n arvo
                    }
                    VastausLB.Visible = true; // Vastaus näkyväksi
                    uusiLukuTB.Text = ""; // Nollataan kenttä
                    }
                    else // Mikäli ei ole syötetty pysäytysarvoa
                    {
                        jono.Add(int.Parse(uusiLukuTB.Text)); // Lisätään listaan syötetty luku
                        uusiLukuTB.Text = ""; // Nollataan kenttä
                    }
                }
                catch (Exception ex)
                {
                    uusiLukuTB.Text = "";
                    VastausLB.Visible = false;
                    MessageBox.Show("Et syöttänyt lukua!");
                }
            }
            if (e.KeyChar == (char)Keys.Escape) // Mikäli painetaan ESC
            {
                TyhjaaLomake(); // Kutsutaan metodia
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = ""; // Tyhjentää takstikentän
        }
    }
}
