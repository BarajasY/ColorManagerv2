using ColorManagerv2.Models;
using Microsoft.EntityFrameworkCore;

namespace ColorManagerv2.Context
{
    public class CMContext : DbContext
    {
        public CMContext() { }

        public CMContext(DbContextOptions<CMContext> options) : base(options)
        {
        }

        public DbSet<Color> Colors { get; set; }
    }
}
