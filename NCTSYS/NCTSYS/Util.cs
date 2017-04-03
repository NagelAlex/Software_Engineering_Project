using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NCTSYS
{
    class Util
    {
        //Email Validation
        public static Boolean isValidEmail(string email)
        {
            if (Regex.IsMatch(email,
                           @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //PPSN Validation
        public static Boolean isValidPPSN(String ppsn)
        {
            Regex pattern = new Regex(@"^\d{7}[A-Z]{1,2}$");

            if (pattern.IsMatch(ppsn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Reg No Validation
        public static Boolean isValidReg(String regNo)
        {
            // Define Regex for car reg with 3 digits-two letters-up to 5 digits
            if ((Regex.IsMatch(regNo, "^[0-9]{2}[12][-][A-Za-z]{1,2}[-][0-9]{1,5}$")))
            {
                return true;
            }
            // Define Regex for car reg with 2 digits-two letters-up to 5 digits
            else if (Regex.IsMatch(regNo, "^[0-9]{2}[-][A-Za-z]{1,2}[-][0-9]{1,5}$"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
