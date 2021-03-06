using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public  class BasicProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-U59FPVB; initial catalog=BasicProject; integrated security=true");


        }
        public DbSet<Product> Products { get; set; }

        public DbSet<CardObject> CardObjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CardObject>(entity =>
            {
                entity.HasNoKey();
            });
          
 

        }

    }
}
