using Microsoft.EntityFrameworkCore;
using RecordSystem0._1.Models;

namespace RecordSystem0._1
{

    public class AppDbContext : DbContext   //This class from god
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Record> Records { get; set; }
    }

}
