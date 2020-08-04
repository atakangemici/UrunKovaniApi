using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using urunKovaniApi.Models;

namespace urunKovaniApi
{
    public class UrunKovaniContext : DbContext
    {
        public DbSet<Shops> Shops { get; set; }
        public DbSet<AdminUsers> AdminUsers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ShopCategories> ShopCategories { get; set; }
        public DbSet<AppSettings> AppSettings { get; set; }


        public UrunKovaniContext(DbContextOptions<UrunKovaniContext> options) : base(options)
        {

        }
    }
}