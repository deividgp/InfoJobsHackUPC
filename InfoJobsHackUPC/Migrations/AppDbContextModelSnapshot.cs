﻿// <auto-generated />
using System;
using InfoJobsHackUPC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InfoJobsHackUPC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InfoJobsHackUPC.Entities.Lead", b =>
                {
                    b.Property<int>("IdLead")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdLead"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Industry")
                        .HasColumnType("text");

                    b.Property<bool>("IsSalaryShowed")
                        .HasColumnType("boolean");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<int>("MaximumSalary")
                        .HasColumnType("integer");

                    b.Property<int>("MinimumSalary")
                        .HasColumnType("integer");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.Property<int>("NumLeads")
                        .HasColumnType("integer");

                    b.Property<int>("NumViews")
                        .HasColumnType("integer");

                    b.Property<string>("OfferType")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.HasKey("IdLead")
                        .HasName("PK_Leads");

                    b.ToTable("Leads");
                });
#pragma warning restore 612, 618
        }
    }
}
