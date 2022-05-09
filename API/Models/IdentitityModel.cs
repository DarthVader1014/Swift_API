using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Swift_API.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
       
    }

    public class AppliactionDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppliactionDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
    }
}
