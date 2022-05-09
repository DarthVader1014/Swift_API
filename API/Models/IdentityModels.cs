using Microsoft.AspNet.Identity.EntityFramework;

namespace Swift_API.Models
{
    public class ApplicationUser: IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
    }
}
