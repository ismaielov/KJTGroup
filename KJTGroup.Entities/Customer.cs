using KJTGroup.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace KJTGroup.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<string> City { get; set; }


        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();


        [NotMapped]
        public string FullName
        {
            get
            {
                return $" {FirstName} {LastName}";
            }
        }

        [NotMapped]
        public int Age
        { 
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }





    }
}
