using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InLock.DatabaseFirst.Solution.Domains
{
    public partial class InLockContext : DbContext
    {
        public InLockContext()
        {
        }

        public InLockContext(DbContextOptions<InLockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudios> Estudios { get; set; }
        public virtual DbSet<Jogos> Jogos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=InLock_Games_Manha; User Id=sa;pwd=132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudios>(entity =>
            {
                entity.HasKey(e => e.Estudioid);

                entity.ToTable("ESTUDIOS");

                entity.Property(e => e.Estudioid).HasColumnName("ESTUDIOID");

                entity.Property(e => e.Nomeestudio)
                    .IsRequired()
                    .HasColumnName("NOMEESTUDIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jogos>(entity =>
            {
                entity.HasKey(e => e.Jogoid);

                entity.ToTable("JOGOS");

                entity.Property(e => e.Jogoid).HasColumnName("JOGOID");

                entity.Property(e => e.Datalancamento)
                    .HasColumnName("DATALANCAMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estudioid).HasColumnName("ESTUDIOID");

                entity.Property(e => e.Nomejogo)
                    .IsRequired()
                    .HasColumnName("NOMEJOGO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("money");

                entity.HasOne(d => d.Estudio)
                    .WithMany(p => p.Jogos)
                    .HasForeignKey(d => d.Estudioid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JOGOS__ESTUDIOID__571DF1D5");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Usuarioid);

                entity.ToTable("USUARIOS");

                entity.Property(e => e.Usuarioid).HasColumnName("USUARIOID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipousuario)
                    .IsRequired()
                    .HasColumnName("TIPOUSUARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
