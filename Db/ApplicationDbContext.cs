using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace WebApplication3.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
