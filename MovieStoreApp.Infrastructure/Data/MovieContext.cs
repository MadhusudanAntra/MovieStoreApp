using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Data
{
    public class MovieContext:IdentityDbContext<MovieUser>
    {
        public MovieContext(DbContextOptions<MovieContext> option):base(option)
        {

        }

        public DbSet<Cast> Cast { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
    }
}
