using FastBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(P => P.DataPedido)
                .IsRequired();

            builder
                .Property(P => P.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(P => P.CEP)
                .IsRequired()
            .HasMaxLength(10);

            builder
                .Property(P => P.Cidade)
                .IsRequired()
                .HasMaxLength(180);

            builder
                .Property(P => P.Estado)
                .IsRequired()
                .HasMaxLength(02);

            builder
               .Property(P => P.EnderecoCompleto)
               .IsRequired()
               .HasMaxLength(180);

            builder
               .Property(P => P.NumeroEndereco)
               .IsRequired()
               .HasMaxLength(6);
        }
    }
}
