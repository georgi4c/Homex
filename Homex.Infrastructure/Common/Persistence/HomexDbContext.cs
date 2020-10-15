using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Homex.Domain.Common.Models;
using Homex.Domain.Shelves.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Homex.Infrastructure.Common.Persistence
{
    public class HomexDbContext : DbContext, IDbContext
    {
        public DbSet<Shelf> Shelves { get; set; } = default!;

        public DbSet<Box> Boxes { get; set; } = default!;

        public DbSet<Item> Items { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
