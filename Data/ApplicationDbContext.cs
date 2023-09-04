using Microsoft.EntityFrameworkCore;
using WebApplicationeExemplo1.Models;

namespace WebApplicationeExemplo1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Alunos> alunos { get; set; }
        public DbSet<Turmas> turmas { get; set; }
    }
}
