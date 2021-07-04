
namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using System;
    public class StringErrorChecker
    {
        public bool stringErrorChecker(string incString)
        {
            return checkTheIncStringForErrors(incString);
        }
        private bool checkTheIncStringForErrors(string incString)
        {
            if (incString == "monthly" || incString == "weekly" || incString == "fortnightly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
