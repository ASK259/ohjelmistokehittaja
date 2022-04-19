using MySql.Data.MySqlClient; // MYSQL kommunikaatio
using System;
using System.Collections.Generic;
using System.Data; // MYSQL kommunikaatio
using System.Data.SqlClient; // MYSQL kommunikaatio
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikille_pakollinen_projekti
{
    class YHDISTA_TIETOKANTAAN
    {
        // muuttuja jolla yhteys tietokantaan
        // Alla olevan tietokannan osoite tiedot PÄIVITETTÄVÄ ovat nyt väärät
        private MySqlConnection connection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = "); // saattaa vaatia SSL mode = none ja datasource on nyt ip-osoite.
        public MySqlConnection createCo() // funktio luo yhteyden tietokantaan
        {
            return connection;
        }
        public void openCo() // kutsuttaessa avaa yhteyden
        {
            if (connection.State == ConnectionState.Closed) // katsotaan onko tietokantayhteys kiinni
            {
                connection.Open(); // avataan yhteys
            }
        }
        public void closeCo() // kutsuttaessa sulkee yhteyden
        {
            if (connection.State == ConnectionState.Open) // katsotaan onko tietokantayhteys auki
            {
                connection.Close(); // suljetaan yhteys
            }
        }
    }
}
