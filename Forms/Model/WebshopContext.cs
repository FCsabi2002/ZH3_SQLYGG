using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Forms.Model;

public partial class WebshopContext : DbContext
{
    public WebshopContext()
    {
    }

    public WebshopContext(DbContextOptions<WebshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Raktar> Raktars { get; set; }

    public virtual DbSet<Rendele> Rendeles { get; set; }

    public virtual DbSet<RendelesTetel> RendelesTetels { get; set; }

    public virtual DbSet<Termek> Termeks { get; set; }

    public virtual DbSet<Termekkategorium> Termekkategoria { get; set; }

    public virtual DbSet<Ugyfel> Ugyfels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sqlygg\\Desktop\\ZH3_SQLYGG\\Forms\\Webshop.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Raktar>(entity =>
        {
            entity.HasKey(e => e.RaktarKod);

            entity.ToTable("Raktar");

            entity.Property(e => e.RaktarKod)
                .ValueGeneratedNever()
                .HasColumnName("RAKTAR_KOD");
            entity.Property(e => e.RaktarCim)
                .HasMaxLength(255)
                .HasColumnName("RAKTAR_CIM");
            entity.Property(e => e.RaktarNev)
                .HasMaxLength(255)
                .HasColumnName("RAKTAR_NEV");
        });

        modelBuilder.Entity<Rendele>(entity =>
        {
            entity.HasKey(e => e.Sorszam);

            entity.Property(e => e.Sorszam)
                .ValueGeneratedNever()
                .HasColumnName("SORSZAM");
            entity.Property(e => e.FizMod)
                .HasMaxLength(255)
                .HasColumnName("FIZ_MOD");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("LOGIN");
            entity.Property(e => e.RendDatum)
                .HasColumnType("date")
                .HasColumnName("REND_DATUM");
            entity.Property(e => e.SzallCim)
                .HasMaxLength(255)
                .HasColumnName("SZALL_CIM");
            entity.Property(e => e.SzallDatum)
                .HasColumnType("date")
                .HasColumnName("SZALL_DATUM");
            entity.Property(e => e.SzallMod)
                .HasMaxLength(255)
                .HasColumnName("SZALL_MOD");
            entity.Property(e => e.SzamlaCim)
                .HasMaxLength(255)
                .HasColumnName("SZAMLA_CIM");
        });

        modelBuilder.Entity<RendelesTetel>(entity =>
        {
            entity.HasKey(e => new { e.Sorszam, e.Termekkod });

            entity.ToTable("Rendeles_tetel");

            entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");
            entity.Property(e => e.Termekkod)
                .HasMaxLength(255)
                .HasColumnName("TERMEKKOD");
            entity.Property(e => e.Egysegar).HasColumnName("EGYSEGAR");
            entity.Property(e => e.Mennyiseg).HasColumnName("MENNYISEG");
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Termekkod);

            entity.ToTable("Termek");

            entity.Property(e => e.Termekkod)
                .HasMaxLength(255)
                .HasColumnName("TERMEKKOD");
            entity.Property(e => e.Felvitel)
                .HasColumnType("date")
                .HasColumnName("FELVITEL");
            entity.Property(e => e.Felvitte)
                .HasMaxLength(255)
                .HasColumnName("FELVITTE");
            entity.Property(e => e.KatId).HasColumnName("KAT_ID");
            entity.Property(e => e.Keszlet).HasColumnName("KESZLET");
            entity.Property(e => e.Leiras)
                .HasMaxLength(255)
                .HasColumnName("LEIRAS");
            entity.Property(e => e.Listaar).HasColumnName("LISTAAR");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("MEGNEVEZES");
            entity.Property(e => e.Megys)
                .HasMaxLength(255)
                .HasColumnName("MEGYS");
            entity.Property(e => e.RaktarKod).HasColumnName("RAKTAR_KOD");
        });

        modelBuilder.Entity<Termekkategorium>(entity =>
        {
            entity.HasKey(e => e.KatId);

            entity.Property(e => e.KatId)
                .ValueGeneratedNever()
                .HasColumnName("KAT_ID");
            entity.Property(e => e.KatNev)
                .HasMaxLength(255)
                .HasColumnName("KAT_NEV");
            entity.Property(e => e.SzuloKat).HasColumnName("SZULO_KAT");
        });

        modelBuilder.Entity<Ugyfel>(entity =>
        {
            entity.HasKey(e => e.Login);

            entity.ToTable("Ugyfel");

            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("LOGIN");
            entity.Property(e => e.Cim)
                .HasMaxLength(255)
                .HasColumnName("CIM");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nem)
                .HasMaxLength(1)
                .HasColumnName("NEM");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .HasColumnName("NEV");
            entity.Property(e => e.Szulev).HasColumnName("SZULEV");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
