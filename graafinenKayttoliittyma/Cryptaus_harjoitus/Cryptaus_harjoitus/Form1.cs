using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;// Cryptaus ohjelma
///@author Antti Kuusisto
///version 12.04.2022
/// <summary>
/// Salasanan lähetys cryptattuna tietokantaan ja palutus sekä decryptaus. Hieman voisi ComboBox:n toimintaa säätää
/// </summary>
namespace Cryptaus_harjoitus
{
    public partial class CryptForm : Form
    {
        CONNECT co = new CONNECT(); // Muuttuja CONNECT CLASS:lle jolla yhdistetään tietokantaan
        DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
        public CryptForm()
        {
            InitializeComponent();
        }

        private void CryptBT_Click(object sender, EventArgs e)
        {
            string password = eCryptography.Encrypt(PasswordTB.Text.Trim()); //lukee muuttujaan cryptattavan salasanan, poistaavälit ja cryptaa
            if (password.Equals("")) // Katsotaan onko salasanakenttään kirjoitettu mitään
            {
                MessageBox.Show($"Kenttä on tyhjä!"); // virhe viesti mikäli kenttä on tyhjä
            }
            else
            {   //alla Sql komento jossa samassa lisäyskysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("Insert INTO salasanat(salasana) Values (@pwd)", co.createCo());
                command.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = password;// komentoon lisätään cryptattu salasana
                co.openCo(); // Avataaan yhteys tietokantaan CONNECT CLASS:n funktiolla.
                if (command.ExecuteNonQuery() == 1) // mikäli komento suoritettiin
                {
                    co.closeCo(); // suljetaan yhteys tietokantaan
                    MessageBox.Show($"Salanasi on lisätty cryptattuna tietokantaan"); //ilmoitus, että salasana on lisätty tietokantaan
                    PasswordTB.Text = "";// tyhjennetään salasana kenttä
                    VastausLB.Text = "";// tyhjennetään vastaus
                    VastausLB.Visible = false;// piilotetaan vastaus
                    MySqlCommand comman = new MySqlCommand("SELECT salasana FROM salasanat", co.createCo()); // Haetaan salasanat tietokannasta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                    adapter.SelectCommand = comman; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                    adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                }
                else
                {
                    co.closeCo(); // suljetaan yhteys tietokantaan
                    MessageBox.Show($"Salanan cryptaus ja lisäys epäonnistui!"); // Virhe viesti
                }
            }
            
        }

        private void CryptCB_SelectedIndexChanged(object sender, EventArgs e) // cryptatun salasanan kentän käytös
        {
           
            CryptCB.DataSource = table; // haetaan DataTable:sta tiedot
            CryptCB.DisplayMember = "salasana"; // kerrotaan mitä näytetään kentässä
        }

        private void CryptForm_Load(object sender, EventArgs e) // toiminta, kun ladataan lomake
        {   // alla hakukysely tietokantaan on sulautettu Sql komentoon, samassa yhteyden muodostus
            MySqlCommand command = new MySqlCommand("SELECT salasana FROM salasanat", co.createCo());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            CryptCB.DataSource = table; // ComboBox:n tiedot DataTable:sta
            CryptCB.DisplayMember = "salasana";// Mitä näytetään kentässä
        }

        private void DecryptBT_Click(object sender, EventArgs e) // Näytä salasana button:n toiminta
        {
            string salasana = table.Rows[CryptCB.SelectedIndex]["salasana"].ToString(); // luetaan ComboBox ja tehdään tyyppimuunnos
            string vastaus = eCryptography.Decrypt(salasana); //Decrypt:aan salasana
            VastausLB.Text = vastaus; // liitetään salasana vastaus alueeseen
            VastausLB.Visible = true; // vastaus näkyväksi
        }
    }
}
