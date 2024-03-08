namespace ExaminationSystem.Models.Tables
{
    public class StudentCourse
    {
        public StudentCourse()
        {
            Students = new HashSet<Student>();
            Courses = new HashSet<Course>();
        }
        public int CourseId { get; set; }
        public int StudentId { get; set;}
        public int Grade { get; set;}
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
