using MySql.Data.MySqlClient;// MYSQL kommunikaatio
using System;
using System.Collections.Generic;
using System.Data; // MYSQL kommunikaatio
using System.Data.SqlClient; // MYSQL kommunikaatio
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikille_pakollinen_projekti
{
    class TIETOKANNANMUOKKAUS
    {
        YHDISTA_TIETOKANTAAN tietokanta = new YHDISTA_TIETOKANTAAN();
        public bool rekisteroiKayttaja(string fName, string lName, string phone, string email, string gender,string address,int postCode,string postArea)
        {
            return true;
        }
    }
}
