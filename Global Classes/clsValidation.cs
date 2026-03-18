using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cafe_Management_System.Global_Classes
{
    public class clsValidation
    {
        public static bool IsEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex re = new Regex(emailRegex);

            return re.IsMatch(email) && !string.IsNullOrEmpty(email);
        }

        public static bool IsPassword(string password)
        {
            return password.Length >= 6 && !string.IsNullOrEmpty(password);
        }
    }
}
