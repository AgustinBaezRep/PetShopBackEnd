// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class BeneficioConfiguration : IEntityTypeConfiguration<Beneficio>
    {
        public void Configure(EntityTypeBuilder<Beneficio> entity)
        {
            entity.HasKey(e => e.IdBeneficio)
                .HasName("PK__Benefici__E83C0831145963CA");

            entity.Property(e => e.IdBeneficio).HasColumnName("id_beneficio");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("date")
                .HasColumnName("fecha_vencimiento");

            entity.Property(e => e.IdTipoBeneficio).HasColumnName("id_tipo_beneficio");

            entity.HasOne(d => d.IdTipoBeneficioNavigation)
                .WithMany(p => p.Beneficio)
                .HasForeignKey(d => d.IdTipoBeneficio)
                .HasConstraintName("FK__Beneficio__id_ti__5CD6CB2B");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Beneficio> entity);
    }
}
