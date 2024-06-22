using Microsoft.EntityFrameworkCore;
    
namespace DockerPublishSample.Models
{
    public class SchoolDB : DbContext
    {
        public SchoolDB(DbContextOptions<SchoolDB> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}