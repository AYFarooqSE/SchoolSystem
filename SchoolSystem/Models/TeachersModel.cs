using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class TeachersModel
    {
        
        public int ID { get; set; }
        //[Required(ErrorMessage ="Provide Teacher ID")]
        public string? TeacherID { get; set; }
        //[Required(ErrorMessage = "Provide Teacher Name")]
        public string? Name { get; set; }
        //[Required(ErrorMessage = "Provide DOB")]
        public DateTime DOB { get; set; }
        public string? ImageUrl { get; set; }
        public string[]? Hobbies { get; set; }
        public string? Subjects { get; set; }
        public DateTime HireDate { get; set; }
    }
}
