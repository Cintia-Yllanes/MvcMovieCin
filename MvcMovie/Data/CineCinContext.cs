using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data;

public partial class CineCinContext : DbContext
{
    public CineCinContext()
    {
    }

    public CineCinContext(DbContextOptions<CineCinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movies__3214EC0784522824");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
