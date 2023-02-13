using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP_EF_Lecture.Models;

public partial class BirdDbContext : DbContext
{
    public BirdDbContext()
    {
    }

    public BirdDbContext(DbContextOptions<BirdDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=BirdDB; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3214EC07BB2D363F");

            entity.ToTable("Post");

            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.Content).HasMaxLength(256);
            entity.Property(e => e.DatePosted).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
