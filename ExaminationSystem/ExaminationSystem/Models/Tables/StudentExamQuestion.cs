namespace ExaminationSystem.Models.Tables
{
    public class StudentExamQuestion
    {
        public StudentExamQuestion() 
        {
            students = new HashSet<Student>();
            exams = new HashSet<Exam>();
            questions = new HashSet<Question>();
        }

        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Exam> exams { get; set; }
        public ICollection<Question> questions { get; set; }    
    }
}
