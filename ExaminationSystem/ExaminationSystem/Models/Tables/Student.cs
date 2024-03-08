namespace ExaminationSystem.Models.Tables
{
    public class Student
    {

        //navigation properties
        public List<StudentCourse> StudentCourses { get; set; } 
        public List<StudentExamQuestion> StudentExamQuestions { get; set; }
    }
}
