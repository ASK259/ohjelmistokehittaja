using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
///@author Antti Kuusisto
///version 5.4.2022
/// <summary>
/// Sekuntikello. Pitää AINA muistaa tarkistaa onko Timer Enabled true vai false.
/// </summary>
namespace Sekuntikello
{
    public partial class SekuntikelloForm : Form
    {
        private Stopwatch stopWatch;
        public SekuntikelloForm()
        {
            InitializeComponent();
        }

        
        private void StartBT_Click(object sender, EventArgs e) // toiminta, kun käynnistetään kello
        {
            stopWatch.Start(); // Sisäänrakennetulla metodilla käynnistys
        }

        private void StopBT_Click(object sender, EventArgs e) // toiminta, kun pysäytetään kello
        {
            stopWatch.Stop();  // Sisäänrakennetulla metodilla pysäytys
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();  // Sisäänrakennetulla metodilla nollaus 
        }

        private void SekuntikelloForm_Load(object sender, EventArgs e) // toiminta,kun lomake ladataan
        {
            stopWatch = new Stopwatch(); // määritetään uusi stopwatch "metodi"
        }

        private void SeTimer_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed); // kerrotaan formaatti jossa näytetään kulunut aika ja liitetään siihen "kello"
        }
    }
}
