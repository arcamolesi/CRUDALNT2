using Microsoft.EntityFrameworkCore;
using CRUDALNT2.Models;

namespace CRUDALNT2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
     }
}