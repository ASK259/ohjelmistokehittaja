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
/// Nopan heitto ohjelma. Ei toimi vielä
/// </summary>
namespace NopanHeitto
{
    public partial class NopanHeitto : Form
    {
        public NopanHeitto()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e) //Kun painetaan Heitä-painiketta
        {
            HeitaNoppa1(noppa01PB); // kutsutaan metodia 1. nopan picturebox:n
            HeitaNoppa1(noppa02PB); // kutsutaan metodia 2. nopan picturebox:n
        }

        private void HeitaNoppa1(PictureBox NoppaBox)
        {
            Task t = Task.Run(() => {
                NoppaBox.Image = Properties.Resources.rollingDice;
                Task.Delay(500).Wait();
                Random sat = new Random();
                int noppa = sat.Next(1, 7);
                switch (noppa)
                {
                    case 1:
                        NoppaBox.Image = Properties.Resources.dice01;
                        break;
                    case 2:
                        NoppaBox.Image = Properties.Resources.dice02;
                        break;
                    case 3:
                        NoppaBox.Image = Properties.Resources.dice03;
                        break;
                    case 4:
                        NoppaBox.Image = Properties.Resources.dice04;
                        break;
                    case 5:
                        NoppaBox.Image = Properties.Resources.dice05;
                        break;
                    case 6:
                        NoppaBox.Image = Properties.Resources.dice06;
                        break;
                }
            });
        }
       
        private void HeitaNoppa(PictureBox NoppaBox)
        {
            
            //NoppaBox.Image = Properties.Resources.rollingDice;
            Random sat = new Random();
            int noppa = sat.Next(1, 7);
            TimeSpan ts = TimeSpan.FromMilliseconds(500);
            Task t = Task.Run(() => {
            NoppaBox.Image = Properties.Resources.rollingDice;
            //int noppa = sat.Next(1, 7);
                /*switch (noppa)
                {
                    case 1:
                        NoppaBox.Image = Properties.Resources.dice01;
                        break;
                    case 2:
                        NoppaBox.Image = Properties.Resources.dice02;
                        break;
                    case 3:
                        NoppaBox.Image = Properties.Resources.dice03;
                        break;
                    case 4:
                        NoppaBox.Image = Properties.Resources.dice04;
                        break;
                    case 5:
                        NoppaBox.Image = Properties.Resources.dice05;
                        break;
                    case 6:
                        NoppaBox.Image = Properties.Resources.dice06;
                        break;
                }*/
            });
            
            if (!t.Wait(1000))
            {
                //NoppaBox.Image = Properties.Resources.rollingDice;
                
                switch (noppa)
                {
                    case 1:
                        NoppaBox.Image = Properties.Resources.dice01;
                        break;
                    case 2:
                        NoppaBox.Image = Properties.Resources.dice02;
                        break;
                    case 3:
                        NoppaBox.Image = Properties.Resources.dice03;
                        break;
                    case 4:
                        NoppaBox.Image = Properties.Resources.dice04;
                        break;
                    case 5:
                        NoppaBox.Image = Properties.Resources.dice05;
                        break;
                    case 6:
                        NoppaBox.Image = Properties.Resources.dice06;
                        break;
            }
            }
        }
        

    }
}
