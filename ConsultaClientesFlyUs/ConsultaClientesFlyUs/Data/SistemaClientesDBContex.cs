using ConsultaClientesFlyUs.Data.Map;
using ConsultaClientesFlyUs.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaClientesFlyUs.Data
{
    public class SistemaClientesDBContex : DbContext
    {
        public SistemaClientesDBContex(DbContextOptions<SistemaClientesDBContex> options)
            : base(options)
        {
        }
        public DbSet<ClienteModel> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
