using EmprestimoJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoJogos.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            protected override void OnConfiguring(DbContextOptionsBuilder options) =>
                options.UseSqlServer("server=DEL\\SQLEXPRESS; Database=EmprestimosJogos; trusted_connection=true; TrustServerCertificate=True");

        public DbSet<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
