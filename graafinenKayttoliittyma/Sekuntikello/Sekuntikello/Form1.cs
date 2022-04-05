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

        
        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void SekuntikelloForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void SeTimer_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
