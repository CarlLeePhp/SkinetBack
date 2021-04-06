using Microsoft.EntityFrameworkCore;
using SkinetCore.Entities;

namespace SkinetInfrastructure.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options): base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
