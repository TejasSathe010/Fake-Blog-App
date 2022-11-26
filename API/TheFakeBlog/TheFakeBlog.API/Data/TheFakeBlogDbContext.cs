using Microsoft.EntityFrameworkCore;
using TheFakeBlog.API.Entities;

namespace TheFakeBlog.API.Data
{
    public class TheFakeBlogDbContext : DbContext
    {
        public TheFakeBlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
