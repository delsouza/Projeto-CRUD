using EmprestimoJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoJogos.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string cnnString = _configuration.GetConnectionString("cnnEmprestimosJogos").ToString();
                optionsBuilder.UseSqlServer(cnnString);
            }
        }

        public DbSet<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
