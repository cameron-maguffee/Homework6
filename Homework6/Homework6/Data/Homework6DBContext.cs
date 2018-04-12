using System;
using Microsoft.EntityFrameworkCore;

namespace Homework6.Data
{
    public class Homework6DBContext: DbContext 
    {
        public Homework6DBContext( DbContextOptions<Homework6DBContext> options )
            :base(options)
        {
        }

        public DbSet<Person> People 
        { 
            get; 
            set; 
        }

        public DbSet<Club> Clubs
        {
            get;
            set;
        }

        public DbSet<ClubShow> ClubShows
        {
            get;
            set;
        }

        public DbSet<Song> Songs
        {
            get;
            set;
        }

        public DbSet<Placement> Placements
        {
            get;
            set;
        }

        public DbSet<Rating> Ratings
        {
            get;
            set;
        }

        public DbSet<User> Users
        {
            get;
            set;
        }

        public DbSet<YearShow> YearShows
        {
            get;
            set;
        }
    }
}
