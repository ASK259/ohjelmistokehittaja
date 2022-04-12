using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // lisättävä mikäli käyttää rexep:ä
///@author Antti Kuusisto
///version 12.04.2022
/// <summary>
/// Ei täydellinen, mutta keskustelee tietokannan kanssa ja ei ole suora kopio mallista. Kommentit lienevät ilmaisevan, että tiedän miten toimii
/// </summary>
namespace Oppilashallintajarjestelma
{
    class OP
    {
        YH co = new YH(); // YH CLASS:lle muuttuja.
        public string addStudent(string fName, string lName, string phone, string email) // funktio joka lisää oppilaan tietokantaan.
        {
            string username = fName.Substring(1,2) + lName.Substring(1,4); //tehdään käyttäjätunnus nimien toisesta kirjaimesta alkaen.
            string password = makePassword(); // tehdään salasana.
            MySqlCommand command = new MySqlCommand(); // nimetään MySql komento
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fName; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lName; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@unm", MySqlDbType.VarChar).Value = username; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = password; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            string addDatabase = "Insert INTO yhteystiedot" + " (etunimi,sukunimi,puhelin,sahkoposti,kayttaja_tunnus,salasana)" + 
            " VALUES (@fnm,@lnm,@phn,@email,@unm,@pwd); "; // lisäyskysely tietokantaan
            command.CommandText = addDatabase; // liitetään tietokanta komentoon lisäyskysely
            command.Connection = co.createCo(); // luodaan yhteys tietokantaan kutsumalla YH CLASS:n funktiota, joka luo yhteyden tietokantaan
            co.openCo(); // Avataaan yhteys tietokantaan YH CLASS:n funktiolla.
            if (command.ExecuteNonQuery() == 1) // mikäli komento suoritettiin
            {
                co.closeCo(); // suljetaan yhteys tietokantaan
                return $"Oppilas lisätty! Tunnus {username} ja salasana {password}"; // palautetaan onnistumis viesti sekä käyttäjätunnus ja salasana
            }
            else 
            {
                co.closeCo(); // suljetaan yhteys tietokantaan
                return $"Oppilasta ei pystytty lisäämään!"; // Virhe viesti
            }
        }
        public DataTable fetchInformation() // haetaan opiskelijoiden tiedot tietokannasta
        {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
            MySqlCommand command = new MySqlCommand("SELECT opiskelijanumero, etunimi, sukunimi, puhelin, sahkoposti FROM yhteystiedot", co.createCo());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public string modifyingStudent(int oId, string fName,string lName,string phone,string email) // funktio muokkaa oppilaan tietoja tietokannassa
        {
            MySqlCommand command = new MySqlCommand(); // muuttuja Sql komennolle
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fName; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lName; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
            command.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oId; // Nyt lisätään kyselyyn myös opiskelija numero jotta tiedetään kenen tietoja päivitetään
            string updateQuest = "Update `Yhteystiedot` Set `etunimi` = @fnm, `sukunimi` = @lnm, `puhelin` = @phn, `sahkoposti` = @email WHERE opiskelijanumero = @oid"; // Sql lisäys kysely tässä opiskelijanumero on primary key
            command.CommandText = updateQuest; // liitetään tietokantakomentoon muokkauskysely
            command.Connection = co.createCo(); // muodostetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
            co.openCo(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
            if(command.ExecuteNonQuery()== 1) // Katsotaan suoritettiinko komento
            {
                co.closeCo(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                string apu = $"OK"; // Vastaus viesti
                return apu; // viestin palautus
            }
            else // mikäli ei onnistunut tietokannan muokkaus
            {
                co.closeCo();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                string apu = $"Päivitys ei onnistunut!"; // Vastaus viesti
                return apu; // viestin palautus
            }
            
        }
        public string deleteStudent(int oId) // funktio poistaa opiskelijan
        {
            string va; // määritys palutettavalle muutujalle
            MySqlCommand command = new MySqlCommand("DELETE FROM yhteystiedot WHERE opiskelijanumero = @oid", co.createCo());
            command.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oId; // arvojen lisäys poistokyselyyn
            co.openCo(); // Yhteyden avaus YH CLASS:n funktiolla
            if(command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
            {
                co.closeCo(); // suljetaan yhteys YH CLASS:n funktiolla
                 va = $"OK"; // vastaus viesti
                return va; // vastauksen palautus
            }
            else
            {
                co.closeCo(); // suljetaan yhteys YH CLASS:n funktiolla
                va = $"NO";// vastaus viesti
                return va;  // vastauksen palautus
            }
            
        }
        public string makePassword() // funktio tekee salasanan. Ei toimi. Palauttaa testimielessä jotain, jotta kokonaisuutta voi testata
        {
            //string lista = "";
            //string pattern = ([a-z_0-9]);
            //string replacement = "$1";
            //public override string ToString();
            //Regex rgx = new Regex(@"[a - z_0 - 9]");
            //string pi = rgx.ToString();
            /*char[] lista1 = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','X','Y','Z','1','2','3','4','5','6','7','8','9'};
            */
            string pi = $"Salasana";
            return pi;
        }
        }
    }
