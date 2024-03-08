using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models.Tables
{
    public class StudentExamQuestion
    {
        //attributes
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Exam")]
        public int ExamId { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        //
        public string Answer { get; set; }


        //navigation properties
        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public Question Question { get; set; }    
    }
}
