using ExaminationSystem.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Database
{
    public class ApplicationDbContext : DbContext
    {
        //tables
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Exam> Exams { get; set; }  
        //public DbSet<Question> Questions { get; set; }
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
