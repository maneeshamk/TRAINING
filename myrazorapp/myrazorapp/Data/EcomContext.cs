﻿using Microsoft.EntityFrameworkCore;
using myrazorapp.Models;


namespace myrazorapp.Data
{
    public class EcomContext : DbContext
    {
        public EcomContext(DbContextOptions<EcomContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
