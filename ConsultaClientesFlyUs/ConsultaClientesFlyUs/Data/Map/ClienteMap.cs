using ConsultaClientesFlyUs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultaClientesFlyUs.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Endereco).HasMaxLength(100);
            builder.Property(x => x.Telefone).HasMaxLength(15);
            builder.Property(x => x.Senha).HasMaxLength(18);
        }
    }
}
