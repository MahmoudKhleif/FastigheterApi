using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Fastigheter.Models;

namespace Fastigheter.Data
{  // context and connecting between table and database 
    public partial class FastigheterContext : DbContext
    {
        public FastigheterContext()
        {
        }

        public FastigheterContext(DbContextOptions<FastigheterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Loggen> Loggens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
