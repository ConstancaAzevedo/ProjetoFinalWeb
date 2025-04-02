using Microsoft.EntityFrameworkCore;
using ProjetoFinalWeb.Models;

namespace ProjetoFinalWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}