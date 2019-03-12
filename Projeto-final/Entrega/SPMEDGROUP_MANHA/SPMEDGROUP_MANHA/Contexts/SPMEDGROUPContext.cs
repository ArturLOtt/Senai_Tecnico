using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class SPMEDGROUPContext : DbContext
    {
        public SPMEDGROUPContext()
        {
        }

        public SPMEDGROUPContext(DbContextOptions<SPMEDGROUPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaClinica> AreaClinica { get; set; }
        public virtual DbSet<Clinica> Clinica { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<ProntuarioPaciente> ProntuarioPaciente { get; set; }
        public virtual DbSet<StatusConsulta> StatusConsulta { get; set; }
        public virtual DbSet<TipoMedico> TipoMedico { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=SPMEDGROUP;User Id=sa;pwd=132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaClinica>(entity =>
            {
                entity.ToTable("AREA_CLINICA");

                entity.HasIndex(e => e.Especialidade)
                    .HasName("UQ__AREA_CLI__7FD07AA98E9E9131")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Especialidade)
                    .IsRequired()
                    .HasColumnName("ESPECIALIDADE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.ToTable("CLINICA");

                entity.HasIndex(e => e.Cnpj)
                    .HasName("UQ__CLINICA__AA57D6B4C4EBB6ED")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cnpj).HasColumnName("CNPJ");

                entity.Property(e => e.DataInicio)
                    .HasColumnName("DATA_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("ENDERECO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HorarioFuncionamento)
                    .HasColumnName("HORARIO_FUNCIONAMENTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdMedico).HasColumnName("ID_MEDICO");

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("NOME_FANTASIA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasColumnName("RAZAO_SOCIAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Clinica)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK__CLINICA__ID_MEDI__0D7A0286");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.ToTable("CONSULTA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataAgendamento)
                    .HasColumnName("DATA_AGENDAMENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdMedico).HasColumnName("ID_MEDICO");

                entity.Property(e => e.IdPaciente).HasColumnName("ID_PACIENTE");

                entity.Property(e => e.IdStatusConsulta).HasColumnName("ID_STATUS_CONSULTA");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK__CONSULTA__ID_MED__08B54D69");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK__CONSULTA__ID_PAC__09A971A2");

                entity.HasOne(d => d.IdStatusConsultaNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdStatusConsulta)
                    .HasConstraintName("FK__CONSULTA__ID_STA__07C12930");
            });

            modelBuilder.Entity<ProntuarioPaciente>(entity =>
            {
                entity.ToTable("PRONTUARIO_PACIENTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Doencas)
                    .HasColumnName("DOENCAS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remedios)
                    .HasColumnName("REMEDIOS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ProntuarioPaciente)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__PRONTUARI__ID_US__778AC167");
            });

            modelBuilder.Entity<StatusConsulta>(entity =>
            {
                entity.ToTable("STATUS_CONSULTA");

                entity.HasIndex(e => e.Status)
                    .HasName("UQ__STATUS_C__AA8A8F003D3D2A0A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMedico>(entity =>
            {
                entity.ToTable("TIPO_MEDICO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasColumnName("CRM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdAreaClinica).HasColumnName("ID_AREA_CLINICA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdAreaClinicaNavigation)
                    .WithMany(p => p.TipoMedico)
                    .HasForeignKey(d => d.IdAreaClinica)
                    .HasConstraintName("FK__TIPO_MEDI__ID_AR__6A30C649");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TipoMedico)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__TIPO_MEDI__ID_US__6B24EA82");
            });

            modelBuilder.Entity<TipoUsuarios>(entity =>
            {
                entity.ToTable("TIPO_USUARIOS");

                entity.HasIndex(e => e.Tipo)
                    .HasName("UQ__TIPO_USU__B6FCAAA28AFDC001")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIOS__161CF72447D50177")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("DATA_NASCIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("ENDERECO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoUsuario).HasColumnName("ID_TIPO_USUARIO");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneContato)
                    .HasColumnName("TELEFONE_CONTATO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__USUARIOS__ID_TIP__66603565");
            });
        }
    }
}
