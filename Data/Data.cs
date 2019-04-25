using Microsoft.EntityFrameworkCore;
using skillet.Models;

namespace skillet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users{ get; set; }

        public DbSet<Household> Households { get; set; }
        
    }
}