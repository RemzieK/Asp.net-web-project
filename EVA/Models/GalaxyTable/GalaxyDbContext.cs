using Microsoft.EntityFrameworkCore;

namespace EVA.Models.GalaxyTable
{
    public class GalaxyDbContext: DbContext
    {
        public GalaxyDbContext(DbContextOptions<GalaxyDbContext> options)
       : base(options)
        {
        }

        public DbSet<GalaxiesTableModel> Galaxies { get; set; }
    }
}
