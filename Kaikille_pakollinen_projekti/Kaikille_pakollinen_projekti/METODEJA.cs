using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Kaikille_pakollinen_projekti
{
    class METODEJA
    {
        public bool EmailIsValid(string emailaddress) // Tarkistaa sähköpostiositteen
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
