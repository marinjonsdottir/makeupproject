using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace makeup1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        DbSet<photos> potosbyusers { get; set; }
        DbSet<Like> likes { get; set; }
        DbSet<Followers> userFollowers { get; set; }
        DbSet<Hashtag> hashtagging { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }

}