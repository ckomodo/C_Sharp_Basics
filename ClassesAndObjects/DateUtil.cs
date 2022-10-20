using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal static class DateUtil
    {
        public static int YearOfBirth(int age)
        {
            return DateTime.Now.Year - age; //gets the year of birth
        }

        public static int YearOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
                return 0;
            return dateOfBirth.Year;
        }

        public static int Age(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
                return 0;
            return DateTime.Now.Year - dateOfBirth.Year;
        }
    }
}
