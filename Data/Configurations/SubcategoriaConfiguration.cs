// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class SubcategoriaConfiguration : IEntityTypeConfiguration<Subcategoria>
    {
        public void Configure(EntityTypeBuilder<Subcategoria> entity)
        {
            entity.HasKey(e => e.IdSubcategoria)
                .HasName("PK__Subcateg__FDB38B9E0A10B281");

            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

            entity.HasOne(d => d.IdCategoriaNavigation)
                .WithMany(p => p.Subcategoria)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subcatego__id_ca__4BAC3F29");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Subcategoria> entity);
    }
}
