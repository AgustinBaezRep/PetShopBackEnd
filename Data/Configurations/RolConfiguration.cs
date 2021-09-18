﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> entity)
        {
            entity.HasKey(e => e.IdRol)
                .HasName("PK__Rol__6ABCB5E002101E26");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.EstadoRol).HasColumnName("estado_rol");

            entity.HasOne(d => d.EstadoRolNavigation)
                .WithMany(p => p.Rol)
                .HasForeignKey(d => d.EstadoRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rol__estado_rol__37A5467C");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rol> entity);
    }
}