using IDMB.Models;
using Microsoft.EntityFrameworkCore;

namespace IDMB.EntittyData
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {

        }

        public DbSet<Entities> Entities { get; set; }
    }
}
