﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class CarritoConfiguration : IEntityTypeConfiguration<Carrito>
    {
        public void Configure(EntityTypeBuilder<Carrito> entity)
        {
            entity.HasKey(e => new { e.IdCarrito, e.IdProducto })
                .HasName("PK__Carrito__4C51EC5CD051EA25");

            entity.Property(e => e.IdCarrito).HasColumnName("id_carrito");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");

            entity.Property(e => e.PrecioActual)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_actual");

            entity.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.Carrito)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Carrito__id_prod__5812160E");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Carrito> entity);
    }
}
