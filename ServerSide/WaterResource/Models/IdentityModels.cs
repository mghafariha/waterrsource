using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WaterResource.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Hometown { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<WaterResource.Models.OtherType> OtherType { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.AreaStudy> AreaStudies { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.Plain> Plains { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.InspectionDepartments> InspectionDepartments { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.City> Cities { get; set; }
        public System.Data.Entity.DbSet<WaterResource.Models.WellProfile> WellProfiles { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.WellVisited> WellVisiteds { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.WellViolation> WellViolations { get; set; }

        public System.Data.Entity.DbSet<WaterResource.Models.WellViolationsItems> WellViolationItems { get; set; }


    }
}