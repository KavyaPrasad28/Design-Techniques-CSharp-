using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSRP
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if(string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("fist name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
