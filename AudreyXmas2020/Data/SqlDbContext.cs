using Microsoft.EntityFrameworkCore;

namespace AudreyXmas2020.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
           : base(options)
        {
        }
        public DbSet<MadLib> MadLibs { get; set; }
    }
}