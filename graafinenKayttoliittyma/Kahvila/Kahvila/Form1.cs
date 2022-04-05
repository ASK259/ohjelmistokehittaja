using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvila
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilakunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text = "9:00 - 14:30 joka päivä maanantaista torstaisin ja perjantaisin \n";
            MeistaLB.Text = "9:00 - 12:30.\n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text = "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia \n";
            MeistaLB.Text = "Tervatuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 12);
        }
    }
}
