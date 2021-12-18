using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Cart Cart { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
