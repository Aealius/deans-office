using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp.DeansOfficeData;

public partial class DeansOfficeContext : DbContext
{
    public DeansOfficeContext()
    {
    }

    public DeansOfficeContext(DbContextOptions<DeansOfficeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<GroupsOfUni> GroupsOfUnis { get; set; }

    public virtual DbSet<Pass> Passes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=12345;database=deans_office");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("enrollments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Edate)
                .HasColumnType("date")
                .HasColumnName("edate");
            entity.Property(e => e.Reason)
                .HasColumnType("enum('зачислен','отчислен')")
                .HasColumnName("reason");
        });

        modelBuilder.Entity<GroupsOfUni>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("groups_of_uni");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.HasIndex(e => e.NameOfGroup, "name_of_group_uq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameOfGroup)
                .HasMaxLength(10)
                .HasColumnName("name_of_group");
            entity.Property(e => e.Speciality)
                .HasMaxLength(150)
                .HasColumnName("speciality");
            entity.Property(e => e.YearOfCreation)
                .HasColumnType("year")
                .HasColumnName("year_of_creation");
        });

        modelBuilder.Entity<Pass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("passes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Reason)
                .HasDefaultValueSql("'?'")
                .HasColumnType("enum('заявление','справка','неуважительная','?')")
                .HasColumnName("reason");
            entity.Property(e => e.SkippedDate)
                .HasColumnType("date")
                .HasColumnName("skipped_date");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PRIMARY");

            entity.ToTable("students");

            entity.HasIndex(e => e.GroupName, "group_name_fk");

            entity.HasIndex(e => e.RecBook, "rec_book_uq").IsUnique();

            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.BirthYear)
                .HasColumnType("date")
                .HasColumnName("birth_year");
            entity.Property(e => e.GroupName)
                .HasMaxLength(10)
                .HasColumnName("group_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.RecBook)
                .HasMaxLength(15)
                .HasColumnName("rec_book");
            entity.Property(e => e.Sname)
                .HasMaxLength(150)
                .HasColumnName("sname");
            entity.Property(e => e.Surname)
                .HasMaxLength(150)
                .HasColumnName("surname");

            entity.HasOne(d => d.GroupNameNavigation).WithMany(p => p.Students)
                .HasPrincipalKey(p => p.NameOfGroup)
                .HasForeignKey(d => d.GroupName)
                .HasConstraintName("group_name_fk");

            entity.HasMany(d => d.Ens).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentsEnrollment",
                    r => r.HasOne<Enrollment>().WithMany()
                        .HasForeignKey("EnId")
                        .HasConstraintName("en_en_id_fk"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .HasConstraintName("en_student_id_fk"),
                    j =>
                    {
                        j.HasKey("StudentId", "EnId").HasName("PRIMARY");
                        j.ToTable("students_enrollments");
                        j.HasIndex(new[] { "EnId" }, "en_en_id_fk_idx");
                        j.IndexerProperty<ushort>("StudentId").HasColumnName("student_id");
                        j.IndexerProperty<ushort>("EnId").HasColumnName("en_id");
                    });

            entity.HasMany(d => d.Passes).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentsPass",
                    r => r.HasOne<Pass>().WithMany()
                        .HasForeignKey("PassId")
                        .HasConstraintName("p_pass_id_fk"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .HasConstraintName("p_student_id_fk"),
                    j =>
                    {
                        j.HasKey("StudentId", "PassId").HasName("PRIMARY");
                        j.ToTable("students_passes");
                        j.HasIndex(new[] { "PassId" }, "p_pass_id_fk_idx");
                        j.IndexerProperty<ushort>("StudentId").HasColumnName("student_id");
                        j.IndexerProperty<ushort>("PassId").HasColumnName("pass_id");
                    });
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPass)
                .HasMaxLength(20)
                .HasColumnName("user_pass");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
