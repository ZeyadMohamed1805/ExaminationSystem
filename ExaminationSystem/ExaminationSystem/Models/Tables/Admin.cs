using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models.Tables
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public int AdminAge { get; set; }
        public string AdminAddress { get; set; }
        public string AdminGender { get; set; }
        public string AdminPosition { get; set; }
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string AdminEmail { get; set; }
        [ForeignKey("AdminEmail")]
        public User User { get; set; }
        
    
       

    }
}
