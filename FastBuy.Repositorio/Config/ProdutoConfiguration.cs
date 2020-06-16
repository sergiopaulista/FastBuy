using FastBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            //Builder utiiza o padrão Floet
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
               .Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(400);

            builder
               .Property(p => p.Preco)
               .IsRequired();
               
        }
    }
}
