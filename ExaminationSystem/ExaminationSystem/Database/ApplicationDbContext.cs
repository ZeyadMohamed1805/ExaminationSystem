using ExaminationSystem.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Database
{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<StudentCourse> studentCourses { get; set; }
        //public DbSet<StudentExamQuestion> studentExamQuestions { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<StudentCourse>()
                .HasKey(c => new { c.CourseId ,c.StudentId} );
            modelBuilder
                .Entity<StudentExamQuestion>()
                .HasKey(c=> new {c.StudentId,c.ExamId,c.QuestionId});

            //base.OnModelCreating(modelBuilder);
        }

    }
}
