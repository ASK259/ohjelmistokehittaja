using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // lisättävä mikäli käyttää rexep:ä
///@author Antti Kuusisto
///version 12.04.2022
/// <summary>
/// Ei täydellinen, mutta keskustelee tietokannan kanssa ja ei ole suora kopio mallista. Kommentit lienevät ilmaisevan, että tiedän miten toimii
/// </summary>
namespace Oppilashallintajarjestelma
{
    public partial class OHallintaForm : Form
    {
        OP student = new OP(); // muuttuja OP CLASS:lle
        public OHallintaForm()
        {
            InitializeComponent();
        }

        private void TaBT_Click(object sender, EventArgs e) // Tallentaa oppilaan
        {
            try
            {
                string fName = EniTB.Text; // luetaan etunimi
                string lName = SniTB.Text; // luetaan sukunimi
                string phone = PnroTB.Text; // luetaan puhelin
                string email = SpoTB.Text; // luetaan sähköposti
                if (fName.Equals("") || lName.Equals("") || phone.Equals("") || email.Equals("")) // katsotaan ettei kentätä ole tyhjiä
                {
                    MessageBox.Show($"Jokin täytettävä kenttä on tyhjä!"); // viesti
                }
                else
                {
                    string addStudent = student.addStudent(fName, lName, phone, email); //kutsutaan OP CLASS:ssa olevaa funktiota, joka lisää oppilaan tiedot tietokantaan
                    MessageBox.Show(addStudent); // näyttää edellä kutsutun funktion paluu viestin
                }
                Tiedot.DataSource = student.fetchInformation(); // Kutsutaan OP CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
                TyBT.PerformClick();// ohjelma "klikkaa" tyhjennä button:a ja tyhjentää kentät
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Näyttää virhe viestin mikä on pielessä
            }

        }

        private void PaBT_Click(object sender, EventArgs e) // Päivittää oppilaan tiedot
        {
            try
            {
                string fName = EniTB.Text; // luetaan etunimi
                string lName = SniTB.Text; // luetaan sukunimi
                string phone = PnroTB.Text; // luetaan puhelin
                string email = SpoTB.Text; // luetaan sähköposti
                int oId = int.Parse(OIdTB.Text); //Kokeillaan muuttaa id kentän syöte numeroksi
                if (fName.Equals("") || lName.Equals("") || phone.Equals("") || email.Equals("") || oId.Equals("")) // katsotaan ettei kentätä ole tyhjiä
                    {
                        MessageBox.Show($"Jokin täytettävä kenttä on tyhjä!"); // viesti
                    }
                else
                {
                    string modStudent = student.modifyingStudent(oId,fName,lName,phone,email); // Kutsutaan OP CLASS:ssa olevaa funktiota jolla päivitetään tietokannassa olevan oppilaan tiedot
                    MessageBox.Show(modStudent); // Näytetään edellä kutsutun funktion paluuviesti
                }
                TyBT.PerformClick();// ohjelma "klikkaa" tyhjennä button:a ja tyhjentää kentät
                Tiedot.DataSource = student.fetchInformation(); // Kutsutaan OP CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Opiskelijanumero puuttuu!"); // Viesti mikä tieto virheellinen
            }
        }

        private void TyBT_Click(object sender, EventArgs e) // tyhjennetään kentät
        {
            EniTB.Text = ""; // Tyhjentää etunimen
            SniTB.Text = ""; // Tyhjentää sukunimen
            PnroTB.Text = ""; // Tyhjentää puhelimen
            SpoTB.Text = ""; // Tyhjentää sähköpostin
            OIdTB.Text = ""; // Tyhjentää opiskelijanumeron
        }

        private void PoBT_Click(object sender, EventArgs e) // Poistaa oppilaan
        {
            try
            {
                int oId = int.Parse(OIdTB.Text); //Kokeillaan muuttaa id kentän syöte numeroksi
                string delStudent = student.deleteStudent(oId); // OP CLASS:ssa olevaa funktiota, joka poistaa opiilaan tiedot
                if(delStudent == "OK") // toiminta mikäli edellä kutsuttu funktio palauttaa OK
                {
                    MessageBox.Show($"Oppilas poistettu");// ilmoitus, että oppilas on poistettu
                }
                else // toiminta mikäli poisto ei onnistunut
                {
                    MessageBox.Show($"Oppilasta ei pystytty poistamaan!"); // ilmoitus, että poisto ei onnistunut
                }
                Tiedot.DataSource = student.fetchInformation(); // Kutsutaan OP CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
                TyBT.PerformClick();// ohjelma "klikkaa" tyhjennä button:a ja tyhjentää kentät
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Opiskelijanumero puuttuu!"); // viesti siitä mikä meni pieleen
            }
        }

        private void Tiedot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EniTB.Text = Tiedot.CurrentRow.Cells[1].Value.ToString(); // Tyhjentää etunimen
            SniTB.Text = Tiedot.CurrentRow.Cells[2].Value.ToString(); // Tyhjentää sukunimen
            PnroTB.Text = Tiedot.CurrentRow.Cells[3].Value.ToString(); // Tyhjentää puhelimen
            SpoTB.Text = Tiedot.CurrentRow.Cells[4].Value.ToString(); // Tyhjentää sähköpostin
            OIdTB.Text = Tiedot.CurrentRow.Cells[0].Value.ToString(); // Tyhjentää opiskelijanumeron
        }

        private void OHallintaForm_Load(object sender, EventArgs e) // Toiminta, kun ladataan lomake
        {
            Tiedot.DataSource = student.fetchInformation(); // Kutsutaan OP CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            Tiedot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }
    }
}
