using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DemoAPI.Models.Data
{
    public class DemoContext: DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base (options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
