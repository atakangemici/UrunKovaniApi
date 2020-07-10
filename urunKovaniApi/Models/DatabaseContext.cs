using Esnafim.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Esnafim
{
    public class EsnafimContext : DbContext
    {
        public DbSet<Shops> Shops { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<EmployeeUser> EmployeeUserteriUser { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ShopCategory> ShopCategory { get; set; }

        public UrunKovaniContext(DbContextOptions<UrunKovaniContext> options) : base(options)
        {

        }
    }
}