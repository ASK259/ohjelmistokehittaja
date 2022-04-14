using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eramake;// Cryptaus ohjelma
///@author Antti Kuusisto
///version 12.04.2022
/// <summary>
/// Salasanan lähetys cryptattuna tietokantaan ja palutus sekä decryptaus. Hieman voisi ComboBox:n toimintaa säätää
/// </summary>

namespace Cryptaus_harjoitus
{
     class CONNECT
    {
        private MySqlConnection co = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = salasana");
        public MySqlConnection createCo() // funktio luo yhteyden tietokantaan
        {
            return co;
        }
        public void openCo() // kutsuttaessa avaa yhteyden
        {
            if (co.State == ConnectionState.Closed) // katsotaan onko t.kantayhteys kiinni
            {
                co.Open(); // avataan yhteys
            }
        }
        public void closeCo() // kutsuttaessa sulkee yhteyden
        {
            if (co.State == ConnectionState.Open) // katsotaan onko t.kantayhteys auki
            {
                co.Close(); // suljetaan yhteys
            }
        }
    }
}
