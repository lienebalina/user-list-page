using System.ComponentModel.DataAnnotations;
using user_list_page.Services;

namespace user_list_page.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string SpouseName => FullName + " (" + Age + ")";
        public int Age => UserService.CalculateAge(DateOfBirth);
        //public Status Status { get; set; }
    }

    public enum Status
    {
        Married,
        Single
    }
}
