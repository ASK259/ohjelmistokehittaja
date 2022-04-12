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
    class YH
    {
        // muuttuja jolla yhteys tietokantaan
        private MySqlConnection co = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = opiskelijat"); // saattaa vaatia SSL mode = none ja datasource on nyt ip-osoite.
        public MySqlConnection createCo() // funktio luo yhteyden tietokantaan
        {
            return co;
        }
        public void openCo() // kutsuttaessa avaa yhteyden
        {
            if(co.State == ConnectionState.Closed) // katsotaan onko t.kantayhteys kiinni
            {
                co.Open(); // avataan yhteys
            }
        }
        public void closeCo() // kutsuttaessa sulkee yhteyden
        {
            if( co.State == ConnectionState.Open) // katsotaan onko t.kantayhteys auki
            {
                co.Close(); // suljetaan yhteys
            }
        }
    }
}
