using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models.Tables
{
    public class StudentCourse
    {
        //attributes
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set;}
        //
        public int Grade { get; set;}

        //navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
