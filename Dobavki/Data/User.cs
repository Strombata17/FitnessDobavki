using Microsoft.AspNetCore.Identity;

namespace Dobavki.Data
{
    public class User:IdentityUser
    {
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateRegistor { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
