using System;
using System.Collections.Generic;
using KoperasiTentra.DAL.EF.Data;
using Microsoft.EntityFrameworkCore;

namespace KoperasiTentra.DAL.EF.Context;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<user> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_user");

            entity.HasIndex(e => e.email, "UQ_email").IsUnique();

            entity.HasIndex(e => e.ic_number, "UQ_icnumber").IsUnique();

            entity.HasIndex(e => e.monile_number, "UQ_phone").IsUnique();

            entity.Property(e => e.customer_name)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(320)
                .IsUnicode(false);
            entity.Property(e => e.monile_number)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.pin)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
