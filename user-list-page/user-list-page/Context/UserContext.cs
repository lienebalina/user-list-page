using Microsoft.EntityFrameworkCore;
using user_list_page.Models;

namespace user_list_page.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
