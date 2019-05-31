using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JSearch.Models
{
    public partial class JobSearchContext : DbContext
    {
        public JobSearchContext()
        {
        }

        public JobSearchContext(DbContextOptions<JobSearchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProspectiveEmployer> ProspectiveEmployer { get; set; }
        public virtual DbSet<ProspectiveEmployerAgent> ProspectiveEmployerAgent { get; set; }
        public virtual DbSet<ProspectiveEmployerInteraction> ProspectiveEmployerInteraction { get; set; }
        public virtual DbSet<Recruiter> Recruiter { get; set; }
        public virtual DbSet<RecruiterAgent> RecruiterAgent { get; set; }
        public virtual DbSet<RecruiterAgentInteraction> RecruiterAgentInteraction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1H3H065;Database=JobSearch;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<ProspectiveEmployer>(entity =>
            {
                entity.HasKey(e => e.PkProspectiveEmployer);

                entity.Property(e => e.PkProspectiveEmployer).HasColumnName("pkProspectiveEmployer");

                entity.Property(e => e.FkRecruiterAgent).HasColumnName("fkRecruiterAgent");

                entity.HasOne(d => d.FkRecruiterAgentNavigation)
                    .WithMany(p => p.ProspectiveEmployer)
                    .HasForeignKey(d => d.FkRecruiterAgent)
                    .HasConstraintName("FK_ProspectiveEmployer_RecruiterAgent");
            });

            modelBuilder.Entity<ProspectiveEmployerAgent>(entity =>
            {
                entity.HasKey(e => e.PkProspectiveEmployerAgent)
                    .HasName("PK_EmployerAgent_1");

                entity.Property(e => e.PkProspectiveEmployerAgent).HasColumnName("pkProspectiveEmployerAgent");

                entity.Property(e => e.FkProspectiveEmployer).HasColumnName("fkProspectiveEmployer");

                entity.HasOne(d => d.FkProspectiveEmployerNavigation)
                    .WithMany(p => p.ProspectiveEmployerAgent)
                    .HasForeignKey(d => d.FkProspectiveEmployer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectiveEmployerAgent_ProspectiveEmployer");
            });

            modelBuilder.Entity<ProspectiveEmployerInteraction>(entity =>
            {
                entity.HasKey(e => e.PkProspectiveEmployerInteraction);

                entity.Property(e => e.PkProspectiveEmployerInteraction).HasColumnName("pkProspectiveEmployerInteraction");

                entity.Property(e => e.FkProspectiveEmployer).HasColumnName("fkProspectiveEmployer");

                entity.HasOne(d => d.FkProspectiveEmployerNavigation)
                    .WithMany(p => p.ProspectiveEmployerInteraction)
                    .HasForeignKey(d => d.FkProspectiveEmployer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectiveEmployerInteraction_ProspectiveEmployer");
            });

            modelBuilder.Entity<Recruiter>(entity =>
            {
                entity.HasKey(e => e.PkRecruiter);

                entity.Property(e => e.PkRecruiter).HasColumnName("pkRecruiter");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<RecruiterAgent>(entity =>
            {
                entity.HasKey(e => e.PkRecruiterAgent)
                    .HasName("PK_RecruiterAgentx");

                entity.Property(e => e.PkRecruiterAgent).HasColumnName("pkRecruiterAgent");

                entity.Property(e => e.FkRecruiter).HasColumnName("fkRecruiter");

                entity.HasOne(d => d.FkRecruiterNavigation)
                    .WithMany(p => p.RecruiterAgent)
                    .HasForeignKey(d => d.FkRecruiter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecruiterAgent_Recruiter");
            });

            modelBuilder.Entity<RecruiterAgentInteraction>(entity =>
            {
                entity.HasKey(e => e.PkRecruiterAgentInteraction);

                entity.HasIndex(e => e.PkRecruiterAgentInteraction)
                    .HasName("IX_RecruiterAgentInteraction");

                entity.Property(e => e.PkRecruiterAgentInteraction).HasColumnName("pkRecruiterAgentInteraction");

                entity.Property(e => e.FkRecruiterAgent).HasColumnName("fkRecruiterAgent");

                entity.HasOne(d => d.FkRecruiterAgentNavigation)
                    .WithMany(p => p.RecruiterAgentInteraction)
                    .HasForeignKey(d => d.FkRecruiterAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecruiterAgentInteraction_RecruiterAgent");
            });
        }
    }
}
