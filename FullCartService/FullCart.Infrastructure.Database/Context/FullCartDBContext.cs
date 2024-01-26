using FullCart.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullCart.Infrastructure.Database.Context
{
    public class FullCartDBContext : DbContext
    {
        public FullCartDBContext(DbContextOptions<FullCartDBContext> options) : base(options)
        {

        }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

        public virtual DbSet<Role> Roles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Model.Pl
        //}
    }
}
