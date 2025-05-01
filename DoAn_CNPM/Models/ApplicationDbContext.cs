using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DoAn_CNPM.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> products { get; set; }
    }
}
