﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using infra.context;

namespace infra.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20201027050608_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("domain.entities.Sensor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tag")
                        .IsRequired()
                        .HasColumnName("Tag")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("timestamp")
                        .HasColumnName("TimeStamp")
                        .HasColumnType("float");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasColumnName("Valor")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TB_Sensor");
                });
#pragma warning restore 612, 618
        }
    }
}
