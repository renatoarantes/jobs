﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TestProjetas.Repository.Configuration;

namespace TestProjetas.Repository.Migrations
{
    [DbContext(typeof(PersistContext))]
    partial class PersistContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestProjetas.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnName("NM_BRAND")
                        .HasMaxLength(40);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnName("NM_COLOR")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnName("DS_DESCRIPTION")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsZero")
                        .HasColumnName("FL_NEW")
                        .HasColumnType("BIT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("NM_MODEL")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnName("DC_PRICE");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnName("DT_REGISTRATION");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnName("DT_UPDATE");

                    b.Property<int>("Year")
                        .HasColumnName("NR_YEAR");

                    b.HasKey("Id")
                        .HasName("PK_Id_Vehicle");

                    b.ToTable("TB_VEHICLE");
                });
#pragma warning restore 612, 618
        }
    }
}