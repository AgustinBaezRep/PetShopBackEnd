﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> entity)
        {
            entity.HasKey(e => e.IdVenta)
                .HasName("PK__Venta__459533BF204BC06A");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Venta__id_client__46E78A0C");

            entity.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Venta__id_usuari__45F365D3");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Venta> entity);
    }
}
