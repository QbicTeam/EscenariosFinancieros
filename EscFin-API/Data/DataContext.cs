using Microsoft.EntityFrameworkCore;
using EscFin_API.Models;


namespace EscFin_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}