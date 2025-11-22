using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.MainSettings
{
    public class clsValidation
    {
        static public bool IsDigit(char c)
        {
            if (char.IsDigit(c)) return true;
            if ((Keys)c == Keys.Back) return true;

            return false;
        }

        static public bool IsValidDate(DateTime date)
        {
            if (date > (DateTime.Now.AddYears(-18)))
                return false;

            if (date < (DateTime.Now.AddYears(-150)))
                return false;

            return true;
        }

        static public bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
            
            return regex.IsMatch(email);
        }

        static public bool IsValidNationalNo(string NationalNo, string currentNationalNo)
        {
            if (NationalNo == currentNationalNo) return true;

            return !(clsPerson.IsPersonExist(NationalNo));
        }
    }
}
