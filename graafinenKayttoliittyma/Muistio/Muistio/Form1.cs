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
///version 5.4.2022
/// <summary>
/// Muistio. Toimiikin vielä. 12.4.22 Pitää vielä kommentoida suht hyvä käsitys siitä mikä tekee mitäkin.
/// </summary>
namespace Muistio
{
    public partial class MuistioForm : Form
    {
        string tiedostopolku = ""; // nimetään muuttuja johon tallennetaan tiedostopolku
        public MuistioForm()
        {
            InitializeComponent();
        }

        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstiRTB.Text != "")
            {
                tallennaToolStripMenuItem_Click( sender, e);
                TekstiRTB.Text = "";
            }
            else
            {
                TekstiRTB.Text = "";
            }
           
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstiRTB.Rtf = text.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using(SaveFileDialog ttk = new SaveFileDialog()
                {Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames=true })
                {
                    if(ttk.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                        }
                    }
                    else
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                        }
                    }
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstiRTB.Rtf);
                    }
                }
            }
        }

        private void tuolostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void muokkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Redo();
        }

        private void kopioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstiRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstiRTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstiRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstiRTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstiRTB.Text, TekstiRTB.Font, Brushes.Black, 12, 12);
        }

        private void TekstiRTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstiRTB.Text.Length > 0)
            {
                kopioToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
    }
}
