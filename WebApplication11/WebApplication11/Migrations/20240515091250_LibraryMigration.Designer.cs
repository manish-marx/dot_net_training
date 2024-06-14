﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication11.Data;

#nullable disable

namespace WebApplication11.Migrations
{
    [DbContext(typeof(WebApplication11Context))]
    [Migration("20240515091250_LibraryMigration")]
    partial class LibraryMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication11.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearPublished")
                        .HasColumnType("int");

                    b.HasKey("BookID");

                    b.HasIndex("LibraryID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("WebApplication11.Models.Library", b =>
                {
                    b.Property<int>("LibraryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibraryID");

                    b.ToTable("Library");
                });

            modelBuilder.Entity("WebApplication11.Models.Book", b =>
                {
                    b.HasOne("WebApplication11.Models.Library", "Library")
                        .WithMany("Books")
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("WebApplication11.Models.Library", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}