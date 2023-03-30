using Core;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.EntityFramework.Context
{
    public class WinFormDBContext : DbContext
    {
        //public WinFormDBContext(DbContextOptions<WinFormDBContext> options)
        //    : base(options)
        //{ }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }

        public DbSet<Categories> Categories { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                    //burada delete operasyonu gerçekleştiğinde silinmiş bir verinin de bu swicthden geçeceğini bildiğimiz için yaptık
                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
