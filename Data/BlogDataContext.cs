using Microsoft.EntityFrameworkCore;
using system;

namespace Blog
{
    public class BlogDataContext : DbContext
    {
        public Dbset<Category> Categories { get; set; }
        public Dbset<Post> Posts { get; set; }
        public Dbset<PostTag> PostTags { get; set; }
        public Dbset<Tag> Tags { get; set; }
        public Dbset<User> Users { get; set; }
        public Dbset<UserRole> UserRoles { get; set; }
      
        protectd override void ONConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
    }
}
