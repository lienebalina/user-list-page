using System.ComponentModel.DataAnnotations;
using user_list_page.Context;
using user_list_page.Services;

namespace user_list_page.Models
{
    public class User
    {
        public User () 
        {
            this.PhoneNumbers = new HashSet<PhoneNumber>();
            this.Addresses = new HashSet<Address>();
        }

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string SpouseName => FullName + " (" + Age + ")";
        public int Age => UserService.CalculateAge(DateOfBirth);
    }

    public enum Status
    {
        Married,
        Single
    }
}
