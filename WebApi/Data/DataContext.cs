﻿using Microsoft.EntityFrameworkCore;


namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}