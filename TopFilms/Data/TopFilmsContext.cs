﻿using Microsoft.EntityFrameworkCore;
using TopFilms.Models;

namespace TopFilms.Data
{
    public class TopFilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Director> Director { get; set; }

        public TopFilmsContext(DbContextOptions<TopFilmsContext> opt) : base(opt) 
        {
        
        }
    }   
}
