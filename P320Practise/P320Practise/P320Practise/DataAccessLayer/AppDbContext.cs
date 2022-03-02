using Microsoft.EntityFrameworkCore;
using P320Practise.Models;

namespace P320Practise.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
