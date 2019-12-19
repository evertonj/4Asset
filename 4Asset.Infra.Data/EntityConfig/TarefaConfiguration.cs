using FourAsset.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FourAsset.Infra.Data.EntityConfig
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.TarefaId);
            builder.Property(t => t.Titulo).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Descricao).HasMaxLength(5000);
        }
    }
}
