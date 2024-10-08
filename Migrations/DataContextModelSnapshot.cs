﻿// <auto-generated />
using System;
using Curriculum_Vitae_Project.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curriculum_Vitae_Project.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CurriculumVitaeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurriculumVitaeId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.CurriculumVitae", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurriculumVitaes");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CurriculumVitaeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurriculumVitaeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Company", b =>
                {
                    b.HasOne("Curriculum_Vitae_Project.Model.Items.CurriculumVitae", null)
                        .WithMany("Companies")
                        .HasForeignKey("CurriculumVitaeId");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Person", b =>
                {
                    b.HasOne("Curriculum_Vitae_Project.Model.Items.Project", null)
                        .WithMany("Authors")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Project", b =>
                {
                    b.HasOne("Curriculum_Vitae_Project.Model.Items.CurriculumVitae", null)
                        .WithMany("Projects")
                        .HasForeignKey("CurriculumVitaeId");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.CurriculumVitae", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Curriculum_Vitae_Project.Model.Items.Project", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
