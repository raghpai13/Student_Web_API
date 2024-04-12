using Microsoft.EntityFrameworkCore;

namespace WebApi.Model
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options) { }   

       public DbSet<Student> Students { get; set; }    
    }
}
