using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELECLabAct.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UsersModel> Users { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<SavesModel> Saves { get; set; }
        public DbSet<CategoriesModel> Categories { get; set; }
        public DbSet<ConditionModel> Condition { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<ImagesModel> Images { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsModel>().HasNoKey();
            modelBuilder.Entity<SavesModel>().HasNoKey();
            modelBuilder.Entity<ImagesModel>().HasNoKey();
        }
    }
}
