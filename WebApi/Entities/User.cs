using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual UserHash UserHash { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
