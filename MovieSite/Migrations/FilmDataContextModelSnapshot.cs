﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieSite.Models;

namespace MovieSite.Migrations
{
    [DbContext(typeof(FilmDataContext))]
    partial class FilmDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieSite.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmID");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            Category = "Family/Adventure",
                            Director = "George Miller",
                            Edited = false,
                            Notes = "Great Movie",
                            Rating = "PG",
                            Title = "Happy Feet",
                            Year = 2006
                        },
                        new
                        {
                            FilmID = 2,
                            Category = "Action/Sci-fi",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Notes = "Crazy Movie",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            FilmID = 3,
                            Category = "Romance/Drama",
                            Director = "Marc Webb",
                            Edited = false,
                            Notes = "Funny and Sad Movie",
                            Rating = "PG-13",
                            Title = "500 Days of Summer",
                            Year = 2009
                        });
                });
#pragma warning restore 612, 618
        }
    }
}