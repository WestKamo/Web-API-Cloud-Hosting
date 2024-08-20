using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TelemetryPortal_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object Projects;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object Clients { get; internal set; }
        public object Project { get; internal set; }
    }
}
