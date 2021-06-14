using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestPracticeSunday
{
    public interface IPasswordValidation
    {
        bool PasswordContainsAtLeast8Characters(string password);
        bool PasswordContainsAtLeast1SpecialCharacter(string password);
        bool PasswordContainsAtLeast1CapitalLetter(string password);
        bool PasswordContainsAatLeast1Number(string password);
        bool PasswordIsNoLongerThan16Characters(string password);
    }
}
