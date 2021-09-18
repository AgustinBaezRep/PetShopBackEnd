﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.HasKey(e => e.IdProducto)
                .HasName("PK__Producto__FF341C0DA3E8226F");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.Especificacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("especificacion");

            entity.Property(e => e.IdStock).HasColumnName("id_stock");

            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

            entity.Property(e => e.Imagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("imagen");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdStockNavigation)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__id_sto__5070F446");

            entity.HasOne(d => d.IdSubcategoriaNavigation)
                .WithMany(p => p.Producto)
                .HasForeignKey(d => d.IdSubcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__id_sub__5165187F");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Producto> entity);
    }
}