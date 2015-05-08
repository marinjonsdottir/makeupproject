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
        DbSet<Photo> Photos { get; set; }
        DbSet<Like> Likes { get; set; }
        DbSet<Follower> Followers { get; set; }
        DbSet<Hashtag> Hashtags { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }

}