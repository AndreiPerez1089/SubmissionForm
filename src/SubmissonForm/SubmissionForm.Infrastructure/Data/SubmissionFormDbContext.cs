using Microsoft.EntityFrameworkCore;
using SubmissionForm.Core.Models.Entities;

namespace SubmissionForm.Infrastructure.Data;

class SubmissionFormDbContext : DbContext
{
    public SubmissionFormDbContext(DbContextOptions<SubmissionFormDbContext> dbContextOptions)
        : base(dbContextOptions)
    {

    }

    public DbSet<Submission> Submissions { get; set; }
    public DbSet<SubmissionField> SubmissionFields { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Submission>()
            .HasKey(i=>i.id)
        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        modelBuilder.Entity<Student>().ToTable("Student");
    }
}
