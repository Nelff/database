using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApp
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server = localhost; port = 3306; UserId = root; Password = feish; database = testmanager");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tester>().HasKey(u=> u.Id_tester);
        }

        public virtual DbSet<tester> tester { get; set; }
      
        
    }
}