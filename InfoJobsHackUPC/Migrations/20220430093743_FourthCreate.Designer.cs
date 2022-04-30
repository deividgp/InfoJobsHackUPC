﻿// <auto-generated />
using System;
using InfoJobsHackUPC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InfoJobsHackUPC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220430093743_FourthCreate")]
    partial class FourthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("InfoJobsHackUPC.Entities.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Field")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.SkillProfile", b =>
                {
                    b.Property<int>("IdProfile")
                        .HasColumnType("integer");

                    b.Property<int?>("IDSkill")
                        .HasColumnType("integer");

                    b.Property<int>("IdSkill")
                        .HasColumnType("integer");

                    b.HasKey("IdProfile");

                    b.HasIndex("IDSkill");

                    b.HasIndex("IdProfile");

                    b.HasIndex("IdSkill");

                    b.ToTable("SkillProfile");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.UserProfile", b =>
                {
                    b.Property<int>("IdProfile")
                        .HasColumnType("integer");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.HasKey("IdProfile");

                    b.HasIndex("IdProfile");

                    b.HasIndex("IdUser");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.UserSkill", b =>
                {
                    b.Property<int>("IdSkill")
                        .HasColumnType("integer");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.HasKey("IdSkill");

                    b.HasIndex("IdSkill");

                    b.HasIndex("IdUser");

                    b.ToTable("UserSkill");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.SkillProfile", b =>
                {
                    b.HasOne("InfoJobsHackUPC.Entities.Skill", "FKSkill")
                        .WithMany("SkillProfile_FKSkill")
                        .HasForeignKey("IDSkill");

                    b.HasOne("InfoJobsHackUPC.Entities.Profile", "FKProfile")
                        .WithMany("SkillProfile_FKProfile")
                        .HasForeignKey("IdProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FKProfile");

                    b.Navigation("FKSkill");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.UserProfile", b =>
                {
                    b.HasOne("InfoJobsHackUPC.Entities.Profile", "FKProfile")
                        .WithMany("UserProfile_FKProfile")
                        .HasForeignKey("IdProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfoJobsHackUPC.Entities.User", "FKUser")
                        .WithMany("UserProfile_FKUser")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FKProfile");

                    b.Navigation("FKUser");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.UserSkill", b =>
                {
                    b.HasOne("InfoJobsHackUPC.Entities.Skill", "FKSkill")
                        .WithMany("UserSkills_FKSkill")
                        .HasForeignKey("IdSkill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfoJobsHackUPC.Entities.User", "FKUser")
                        .WithMany("UserSkills_FKUser")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FKSkill");

                    b.Navigation("FKUser");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.Profile", b =>
                {
                    b.Navigation("SkillProfile_FKProfile");

                    b.Navigation("UserProfile_FKProfile");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.Skill", b =>
                {
                    b.Navigation("SkillProfile_FKSkill");

                    b.Navigation("UserSkills_FKSkill");
                });

            modelBuilder.Entity("InfoJobsHackUPC.Entities.User", b =>
                {
                    b.Navigation("UserProfile_FKUser");

                    b.Navigation("UserSkills_FKUser");
                });
#pragma warning restore 612, 618
        }
    }
}