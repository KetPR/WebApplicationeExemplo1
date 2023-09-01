using Microsoft.EntityFrameworkCore;

namespace WebApplicationeExemplo1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet <Produto> produtos { get; set; } = default!;
    }
}

