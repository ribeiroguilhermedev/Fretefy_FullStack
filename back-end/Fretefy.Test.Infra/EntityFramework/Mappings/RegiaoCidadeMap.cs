using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
    {
        public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.HasOne(rc => rc.Regiao)
                .WithMany(r => r.RegioesCidades)
                .HasForeignKey(rc => rc.RegiaoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rc => rc.Cidade)
                .WithMany(c => c.RegioesCidades)
                .HasForeignKey(rc => rc.CidadeId)
                .OnDelete(DeleteBehavior.Cascade);

            // garantir que nao havera multiplos registros da mesma cidade e regiao 
            builder.HasIndex(rc => new { rc.RegiaoId, rc.CidadeId }).IsUnique();
        }
    }
} 