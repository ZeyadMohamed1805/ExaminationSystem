namespace ExaminationSystem.Models.Tables
{
    public class Course
    {

        //navigation properties
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
