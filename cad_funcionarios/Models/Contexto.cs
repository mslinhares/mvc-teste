using Microsoft.EntityFrameworkCore;

namespace cad_funcionarios.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=mateus\\sqlexpress;database=db_funcionarios;trusted_connection=true;Integrated Security=True");
        }
    }
}
