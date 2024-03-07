using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models.Tables
{
    public class Choice
    {
        public string ChoiceText { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
    }
}
