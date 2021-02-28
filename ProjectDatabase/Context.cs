using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace ProjectDatabase
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; } 
        
        public DbSet<Product> Product { get; set; } 
        
        public DbSet<Recipe> Recipe { get; set; } 
        
        public DbSet<Category> Category { get; set; } 
        
        public DbSet<Subscribe> Subscribe { get; set; } 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=FoodDB;User=sa;Password=P@55w0rd;");
        }
    }
}