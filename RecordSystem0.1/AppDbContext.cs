namespace RecordSystem0._1
{
    using Microsoft.EntityFrameworkCore;
    using RecordSystem0._1.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Record> Records { get; set; }
    }

}
