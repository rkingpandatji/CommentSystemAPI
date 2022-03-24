using Microsoft.EntityFrameworkCore;

namespace CommentSystem.Model
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Comment> comments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
