using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static string UpperFullName(this Passanger P)
        {
            if (P == null)
            {
                throw new ArgumentNullException();
            }
            string firstName = P.FirstName;
            string lastName = P.LastName;
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            return firstName + " " + lastName;

        }
    }
}
