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
///version 5.4.2022
/// <summary>
/// Ajsatin. Muutama toiminnan kehitys idea on, tosin pitäisi jaksaa toteuttaa ne
/// </summary>
namespace Ajastin
{
    public partial class AjastinForm : Form
    {
        public AjastinForm()
        {
            InitializeComponent();
        }

        private int koAika;
        private void AjastinForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                MiCB.Items.Add(i.ToString());
                SeCB.Items.Add(i.ToString());
            }
            MiCB.SelectedIndex = 20;
            SeCB.SelectedIndex = 0;
            StopBT.Enabled = false;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int mi = int.Parse(MiCB.Text);
            int se = int.Parse(SeCB.Text);
            koAika = mi * 60 + se;
            AikaTimer.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            koAika = 0;
            AikaTimer.Enabled=false;
            AikaLB.Text = "00:00";
        }

        private void AikaTimer_Tick(object sender, EventArgs e)
        {
            if (koAika > 0)
            {
                koAika --;
                int mi = koAika / 60;
                int se = koAika - mi * 60;
                AikaLB.Text = $"{mi.ToString()}:{se.ToString()}";
            }
            else
            {
                AikaTimer.Stop();
                MessageBox.Show($"Kello nollassa");
            }
        }
    }
}
