namespace ExaminationSystem.Models.Tables
{
    public class Exam
    {

        //navigation properties
        public List<StudentExamQuestion> StudentExamQuestions { get; set; }
    }
}
