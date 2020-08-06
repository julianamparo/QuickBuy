using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            builder
               .HasMany(u => u.Pedidos)
               .WithOne(p => p.Usuario);

        }
    }
}
