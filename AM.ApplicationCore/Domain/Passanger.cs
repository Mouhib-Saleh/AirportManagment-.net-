using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passanger
    {
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        public int PassportNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Telephone number must contain 8 digits.")]
        public int TelNumber { get; set; }
        public List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
        }
        public virtual void PassangerType()
        {
            Console.WriteLine("I am a Passenger");

        }


        public bool CheckProfil(string firstname, string lastname, string emailadress = null)
        {
            if (emailadress == null)
            {
                return FirstName == firstname && LastName == lastname;

            }
            else
            {
                return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;

            }
        }
    }

}
