using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace user_list_page.Models
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberId { get; set; }
        public string Number { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
