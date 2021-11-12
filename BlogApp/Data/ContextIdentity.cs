using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class ContextIdentity : IdentityDbContext
    {
        public ContextIdentity()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=blog;Trusted_Connection=True;");
    }
}
