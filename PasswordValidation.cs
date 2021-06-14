using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestPracticeSunday
{
    public class PasswordValidation : IPasswordValidation
    {
        public bool PasswordContainsAatLeast1Number(string password)
        {
            foreach (char c in password)
            {
               if(char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsAtLeast1CapitalLetter(string password)
        {
            foreach(char c in password)
            {
                if(char.IsLetter(c) && c.ToString() == c.ToString().ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsAtLeast1SpecialCharacter(string password)
        {
            foreach(char c in password)
            {
                if(!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool PasswordContainsAtLeast8Characters(string password)
        {
            return password.Length >= 8;
        }

        public bool PasswordIsNoLongerThan16Characters(string password)
        {
            return password.Length <= 16;
        }
    }
}
