﻿// <auto-generated />
using AnimeCDWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimeCDWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimeCDWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Psychological"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 11,
                            Name = "Slice of Life"
                        },
                        new
                        {
                            Id = 12,
                            DisplayOrder = 12,
                            Name = "Supernatural"
                        },
                        new
                        {
                            Id = 13,
                            DisplayOrder = 13,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 14,
                            DisplayOrder = 14,
                            Name = "Mecha"
                        },
                        new
                        {
                            Id = 15,
                            DisplayOrder = 15,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 16,
                            DisplayOrder = 16,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 17,
                            DisplayOrder = 17,
                            Name = "School"
                        },
                        new
                        {
                            Id = 18,
                            DisplayOrder = 18,
                            Name = "Shounen"
                        },
                        new
                        {
                            Id = 19,
                            DisplayOrder = 19,
                            Name = "Shoujo"
                        },
                        new
                        {
                            Id = 22,
                            DisplayOrder = 20,
                            Name = "Harem"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
