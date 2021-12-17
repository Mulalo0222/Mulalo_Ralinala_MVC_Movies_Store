using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovies.Models;
using Microsoft.EntityFrameworkCore;


namespace MvcMovies.Data
{
    public class MvcMoviesContext : DbContext
    {
        public MvcMoviesContext(DbContextOptions<MvcMoviesContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }

    }