﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class BeneficioxSubcategoriaConfiguration : IEntityTypeConfiguration<BeneficioxSubcategoria>
    {
        public void Configure(EntityTypeBuilder<BeneficioxSubcategoria> entity)
        {
            entity.HasKey(e => new { e.IdBeneficio, e.IdSubcategoria })
                .HasName("PK__Benefici__17E730880367A1CC");

            entity.Property(e => e.IdBeneficio).HasColumnName("id_beneficio");

            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");

            entity.HasOne(d => d.IdBeneficioNavigation)
                .WithMany(p => p.BeneficioxSubcategoria)
                .HasForeignKey(d => d.IdBeneficio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Beneficio__id_be__5FB337D6");

            entity.HasOne(d => d.IdSubcategoriaNavigation)
                .WithMany(p => p.BeneficioxSubcategoria)
                .HasForeignKey(d => d.IdSubcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Beneficio__id_su__60A75C0F");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BeneficioxSubcategoria> entity);
    }
}