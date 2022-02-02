using System;
using Microsoft.EntityFrameworkCore;

namespace MovieSite.Models
{
    public class FilmDataContext : DbContext
    {
        //Constructor
        public FilmDataContext (DbContextOptions<FilmDataContext> options) : base (options)
        {
            //Blank for now
        }

        public DbSet<ApplicationResponse> Films { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryID = 1,
                        CategoryName = "Action/Adventure"
                    },
                    new Category
                    {
                        CategoryID = 2,
                        CategoryName = "Action/Comedy"
                    },
                    new Category
                    {
                        CategoryID = 3,
                        CategoryName = "Action/Thriller"
                    },
                    new Category
                    {
                        CategoryID = 4,
                        CategoryName = "Action/Sci-fi"
                    },
                    new Category
                    {
                        CategoryID = 5,
                        CategoryName = "Family/Adventure"
                    },
                    new Category
                    {
                        CategoryID = 6,
                        CategoryName = "Family/Comedy"
                    },
                    new Category
                    {
                        CategoryID = 7,
                        CategoryName = "Family/Drama"
                    },
                    new Category
                    {
                        CategoryID = 8,
                        CategoryName = "Horror/Comedy"
                    },
                    new Category
                    {
                        CategoryID = 9,
                        CategoryName = "Horror/Sci-fi"
                    },
                    new Category
                    {
                        CategoryID = 10,
                        CategoryName = "Horror/Thriller"
                    },
                    new Category
                    {
                        CategoryID = 11,
                        CategoryName = "Romance/Comedy"
                    },
                    new Category
                    {
                        CategoryID = 12,
                        CategoryName = "Romance/Drama"
                    }   
                );

            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        FilmID = 1,
                        Title = "Happy Feet",
                        CategoryID = 5,//"Family/Adventure",
                        Rating = "PG",
                        Year = 2006,
                        Director = "George Miller",
                        Notes = "Great Movie"
                    },
                    new ApplicationResponse
                    {
                        FilmID = 2,
                        Title = "Inception",
                        CategoryID = 4,//"Action/Sci-fi",
                        Rating = "PG-13",
                        Year = 2010,
                        Director = "Christopher Nolan",
                        Notes = "Crazy Movie"
                    },
                    new ApplicationResponse
                    {
                        FilmID = 3,
                        Title = "500 Days of Summer",
                        CategoryID = 12,//"Romance/Drama",
                        Rating = "PG-13",
                        Year = 2009,
                        Director = "Marc Webb",
                        Notes = "Funny and Sad Movie"
                    }
                ) ;
        }
    }
}
