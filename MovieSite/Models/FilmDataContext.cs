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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        FilmID = 1,
                        Title = "Happy Feet",
                        Category = "Family/Adventure",
                        Rating = "PG",
                        Year = 2006,
                        Director = "George Miller",
                        Notes = "Great Movie"
                    },
                    new ApplicationResponse
                    {
                        FilmID = 2,
                        Title = "Inception",
                        Category = "Action/Sci-fi",
                        Rating = "PG-13",
                        Year = 2010,
                        Director = "Christopher Nolan",
                        Notes = "Crazy Movie"
                    },
                    new ApplicationResponse
                    {
                        FilmID = 3,
                        Title = "500 Days of Summer",
                        Category = "Romance/Drama",
                        Rating = "PG-13",
                        Year = 2009,
                        Director = "Marc Webb",
                        Notes = "Funny and Sad Movie"
                    }
                ) ;
        }
    }
}
