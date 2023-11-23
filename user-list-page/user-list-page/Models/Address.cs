using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace user_list_page.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string UserAddress { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
