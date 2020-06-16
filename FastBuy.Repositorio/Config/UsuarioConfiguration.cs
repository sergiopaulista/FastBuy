using FastBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //Builder utiiza o padrão Floet
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);


            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            //builder.Property(u => u.Pedidos);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);

        }
    }
}
