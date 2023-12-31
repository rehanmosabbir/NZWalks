using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "9f1e9c87-fbc6-4726-89b2-3c3cdc9e867e";
            var writerRoleId = "98b00d25-261d-45b6-8e7c-9c9e07e2e68b";

            var roles = new List<IdentityRole>()
            {
                new IdentityRole() { Id = readerRoleId, ConcurrencyStamp = readerRoleId, Name = "reader", NormalizedName = "reader".ToUpper() },
                new IdentityRole() { Id=writerRoleId, ConcurrencyStamp = writerRoleId, Name = "writer", NormalizedName = "writer".ToUpper()}
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }


    }
}
