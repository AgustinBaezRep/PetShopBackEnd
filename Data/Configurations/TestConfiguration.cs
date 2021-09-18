﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context.Configurations
{
    public partial class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> entity)
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.Prueba)
                .HasMaxLength(50)
                .HasColumnName("prueba");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Test> entity);
    }
}
