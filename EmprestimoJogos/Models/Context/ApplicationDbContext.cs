using EmprestimoJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoJogos.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
