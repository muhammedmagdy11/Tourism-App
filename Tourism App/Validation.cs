using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Validation
    {
        public static bool NameValidation(string Name)
        {
            return Name.Length > 5;
        }
        public static bool MobileValidation(string Mobile)
        {
            string pattern = @"^([011|010|015|012]{3})+\d{8}$";

            Regex R = new Regex(pattern);

            return R.IsMatch(Mobile);
        }

        public static bool NationalIDValidation(string ID)
        {
            string pattern = @"^\d{14}$";

            Regex R = new Regex(pattern);

            return R.IsMatch(ID);
        }
        public static bool EmptyString(string Text)
        {
            return (string.IsNullOrEmpty(Text) && string.IsNullOrWhiteSpace(Text));
        }
    }
}
